using BusTicketReservation.Application.Contracts.DTOs;
using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Application.Contracts.Interfaces.Services;
using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Domain.Enums;

namespace BusTicketReservation.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBusScheduleRepository _busScheduleRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly ISeatRepository _seatRepository;
        private readonly IPassengerRepository _passengerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BookingService(
            IBusScheduleRepository busScheduleRepository, 
            ITicketRepository ticketRepository, 
            ISeatRepository seatRepository, 
            IPassengerRepository passengerRepository,
            IUnitOfWork unitOfWork)
        {
            _busScheduleRepository = busScheduleRepository;
            _ticketRepository = ticketRepository;
            _seatRepository = seatRepository;
            _passengerRepository = passengerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<SeatPlanDto> GetSeatPlanAsync(Guid busScheduleId)
        {
            // Validate input
            if (busScheduleId == Guid.Empty)
                throw new ArgumentException("Bus schedule ID cannot be empty");

            // Get bus schedule with bus information
            var busSchedule = await _busScheduleRepository.GetBusScheduleWithBusAsync(busScheduleId);

            if (busSchedule == null)
                throw new InvalidOperationException($"Bus schedule with ID {busScheduleId} not found");

            // Get all seats for this bus
            var seats = await _seatRepository.GetSeatsByBusIdAsync(busSchedule.BusId);

            if (seats.Count == 0)
                throw new InvalidOperationException($"No seats found for bus {busSchedule.Bus.BusName}");

            // Get all tickets for this bus schedule
            var tickets = await _ticketRepository.GetTicketsForBusScheduleAsync(busScheduleId);

            var seatDtos = seats.Select(seat =>
            {
                var dto = new SeatDto
                {
                    SeatId = seat.Id,
                    SeatNumber = seat.SeatNumber,
                    RowNumber = seat.RowNumber,
                    Status = seat.Status.ToString()
                };

                if (tickets.ContainsKey(seat.Id))
                {
                    dto.Gender = tickets[seat.Id].Passenger.Gender.ToString();
                }

                return dto;
            }).ToList();

            return new SeatPlanDto
            {
                BusScheduleId = busScheduleId,
                BusName = busSchedule.Bus.BusName,
                CompanyName = busSchedule.Bus.CompanyName,
                Price = busSchedule.Price,
                Seats = seatDtos
            };
        }

        public async Task<BookSeatResultDto> BookSeatAsync(BookSeatInputDto input)
        {
            await _unitOfWork.BeginTransactionAsync();

            try
            {  
                // Validate bus schedule exists
                var busSchedule = await _busScheduleRepository.GetBusScheduleWithBusAndRouteAsync(input.BusScheduleId);
                if (busSchedule == null)
                {
                    return new BookSeatResultDto
                    {
                        Success = false,
                        Message = "Bus schedule not found"
                    };
                }

                // Validate all seats exist and belong to the bus
                var seats = await _seatRepository.GetSeatsByIdsAsync(input.SeatIds);
                var seatDictionary = seats.ToDictionary(s => s.Id, s => s);

                // Check for invalid seats
                foreach (var seatId in input.SeatIds)
                {
                    if (!seatDictionary.ContainsKey(seatId))
                    {
                        return new BookSeatResultDto
                        {
                            Success = false,
                            Message = "Seat not found"
                        };
                    }
                    else if (seatDictionary[seatId].BusId != busSchedule.BusId)
                    {
                        return new BookSeatResultDto
                        {
                            Success = false,
                            Message = "Seat does not belong to this bus"
                        };
                    }
                }

                // Check for already booked seats for this schedule
                var bookedSeats = new List<string>();
                foreach (var seat in seats)
                {
                    bool isBooked = await _ticketRepository.IsSeatBookedForScheduleAsync(seat.Id, input.BusScheduleId);
                    if (isBooked)
                    {
                        bookedSeats.Add(seat.SeatNumber);
                    }
                }

                if (bookedSeats.Any())
                {
                    return new BookSeatResultDto
                    {
                        Success = false,
                        Message = $"These seats are not available: {string.Join(", ", bookedSeats)}"
                    };
                }

                // Validate boarding and dropping stops
                var boardingStop = busSchedule.Route.RouteStops.FirstOrDefault(rs => rs.StopCode == input.BoardingStopCode);
                var droppingStop = busSchedule.Route.RouteStops.FirstOrDefault(rs => rs.StopCode == input.DroppingStopCode);

                if (boardingStop == null || droppingStop == null)
                {
                    return new BookSeatResultDto
                    {
                        Success = false,
                        Message = "Invalid boarding or dropping stop"
                    };
                }

                if (boardingStop.StopOrder >= droppingStop.StopOrder)
                {
                    return new BookSeatResultDto
                    {
                        Success = false,
                        Message = "Boarding stop must come before dropping stop"
                    };
                }

                // Create or update passenger
                var passenger = await _passengerRepository.GetByMobileNumberAsync(input.MobileNumber);
                if (passenger == null)
                {
                    passenger = new Passenger
                    {
                        Id = Guid.NewGuid(),
                        Name = input.PassengerName,
                        MobileNumber = input.MobileNumber,
                        Gender = input.PassengerGender
                    };
                    passenger = await _passengerRepository.AddAsync(passenger);
                }
                else
                {
                    // Update passenger details if they exist
                    passenger.Name = input.PassengerName;
                    passenger.Gender = input.PassengerGender;
                }

                // Create tickets
                var totalPrice = 0;
                foreach (var seat in seats)
                {
                    var ticket = new Ticket
                    {
                        Id = Guid.NewGuid(),
                        BusScheduleId = input.BusScheduleId,
                        SeatId = seat.Id,
                        PassengerId = passenger.Id,
                        BoardingStopId = boardingStop.Id,
                        DroppingStopId = droppingStop.Id,
                        Price = busSchedule.Price,
                        BookingDate = DateTime.UtcNow
                    };

                    totalPrice += busSchedule.Price;
                    await _ticketRepository.AddAsync(ticket);
                }
                
                // Update seat status
                await _seatRepository.UpdateSeatStatusRangeAsync(input.SeatIds, SeatStatus.Booked);

                // Save all changes and commit transaction
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();

                // Build result with ticket details
                var boardingTime = busSchedule.JourneyDate.Date.Add(busSchedule.DepartureTime.Add(boardingStop.TimeOffset));
                var droppingTime = busSchedule.JourneyDate.Date.Add(busSchedule.DepartureTime.Add(droppingStop.TimeOffset));

                var bookingSummary = new BookingSummaryDto
                {
                    PassengerName = passenger.Name,
                    MobileNumber = passenger.MobileNumber,
                    Gender = passenger.Gender.ToString(),
                    CompanyName = busSchedule.Bus.CompanyName,
                    BusName = busSchedule.Bus.BusName,
                    SeatNumbers = seats.OrderBy(s => s.SeatNumber).Select(s => s.SeatNumber).ToList(),
                    BoardingStop = boardingStop.StopName,
                    DroppingStop = droppingStop.StopName,
                    BoardingTime = boardingTime,
                    DroppingTime = droppingTime,
                    JourneyDate = busSchedule.JourneyDate,
                    TotalPrice = totalPrice,
                    BookingDate = DateTime.UtcNow
                };

                return new BookSeatResultDto
                {
                    Success = true,
                    Message = $"Seat(s) booked successfully",
                    BookingSummary = bookingSummary
                };
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
                throw;
            }
        }
    }
}
