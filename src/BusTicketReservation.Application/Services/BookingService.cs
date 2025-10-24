using BusTicketReservation.Application.Contracts.DTOs;
using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Application.Contracts.Interfaces.Services;

namespace BusTicketReservation.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBusScheduleRepository _busScheduleRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly ISeatRepository _seatRepository;

        public BookingService(IBusScheduleRepository busScheduleRepository, ITicketRepository ticketRepository, ISeatRepository seatRepository)
        {
            _busScheduleRepository = busScheduleRepository;
            _ticketRepository = ticketRepository;
            _seatRepository = seatRepository;
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
                    var ticketInfo = tickets[seat.Id];
                    var genderText = ticketInfo.Passenger.Gender.ToString();
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
    }
}
