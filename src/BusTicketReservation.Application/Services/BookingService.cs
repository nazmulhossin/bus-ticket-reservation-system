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
 
                // Validate seat exists and belongs to the bus
                var seat = await _seatRepository.GetSeatByIdAsync(input.SeatId);
                if (seat == null)
                {
                    return new BookSeatResultDto
                    {
                        Success = false,
                        Message = "Seat not found"
                    };
                }

                if (seat.BusId != busSchedule.BusId)
                {
                    return new BookSeatResultDto
                    {
                        Success = false,
                        Message = "Seat does not belong to this bus"
                    };
                }

                // Check if seat is already booked for this schedule
                var isAlreadyBooked = await _ticketRepository.IsSeatBookedForScheduleAsync(input.SeatId, input.BusScheduleId);
                if (isAlreadyBooked)
                {
                    return new BookSeatResultDto
                    {
                        Success = false,
                        Message = "Seat is not available for booking"
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

                // Update or create passenger
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

                // Create ticket
                var ticket = new Ticket
                {
                    Id = Guid.NewGuid(),
                    BusScheduleId = input.BusScheduleId,
                    SeatId = input.SeatId,
                    PassengerId = passenger.Id,
                    BoardingStopId = boardingStop.Id,
                    DroppingStopId = droppingStop.Id,
                    Price = busSchedule.Price,
                    BookingDate = DateTime.UtcNow
                };

                await _ticketRepository.AddAsync(ticket);

                // Update seat status
                await _seatRepository.UpdateSeatStatusAsync(input.SeatId, SeatStatus.Booked);

                // Save all changes and commit transaction
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();

                // Build result with ticket details
                var boardingTime = busSchedule.JourneyDate.Date.Add(busSchedule.DepartureTime.Add(boardingStop.TimeOffset));
                var droppingTime = busSchedule.JourneyDate.Date.Add(busSchedule.DepartureTime.Add(droppingStop.TimeOffset));

                var ticketDetails = new TicketDetailsDto
                {
                    TicketId = ticket.Id,
                    PassengerName = passenger.Name,
                    MobileNumber = passenger.MobileNumber,
                    Gender = passenger.Gender.ToString(),
                    CompanyName = busSchedule.Bus.CompanyName,
                    BusName = busSchedule.Bus.BusName,
                    SeatNumber = seat.SeatNumber,
                    BoardingStop = boardingStop.StopName,
                    DroppingStop = droppingStop.StopName,
                    BoardingTime = boardingTime,
                    DroppingTime = droppingTime,
                    JourneyDate = busSchedule.JourneyDate,
                    Price = ticket.Price,
                    BookingDate = ticket.BookingDate
                };

                return new BookSeatResultDto
                {
                    Success = true,
                    Message = $"Seat {seat.SeatNumber} booked successfully",
                    TicketDetails = ticketDetails
                };
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
                throw;
            }
        }

        public async Task<ConfirmTicketResultDto> ConfirmTicketAsync(Guid ticketId)
        {
            await _unitOfWork.BeginTransactionAsync();

            try
            {
                // Validate ticket exists
                var ticket = await _ticketRepository.GetTicketByIdAsync(ticketId);
                if (ticket == null)
                {
                    return new ConfirmTicketResultDto
                    {
                        Success = false,
                        Message = "Ticket not found"
                    };
                }

                // Get seat information
                var seat = await _seatRepository.GetSeatByIdAsync(ticket.SeatId);
                if (seat == null)
                {
                    return new ConfirmTicketResultDto
                    {
                        Success = false,
                        Message = "Seat not found"
                    };
                }

                // Check if seat is already sold
                if (seat.Status == SeatStatus.Sold)
                {
                    return new ConfirmTicketResultDto
                    {
                        Success = false,
                        Message = "Ticket is already confirmed"
                    };
                }

                // Update seat status to Sold
                await _seatRepository.UpdateSeatStatusAsync(ticket.SeatId, SeatStatus.Sold);

                // Save all changes and commit transaction
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();

                return new ConfirmTicketResultDto
                {
                    Success = true,
                    Message = $"Ticket confirmed successfully",
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
