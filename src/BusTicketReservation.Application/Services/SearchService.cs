using BusTicketReservation.Application.Contracts.DTOs;
using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Application.Contracts.Interfaces.Services;

namespace BusTicketReservation.Application.Services
{
    public class SearchService : ISearchService
    {
        private readonly IBusScheduleRepository _busScheduleRepository;
        private readonly ITicketRepository _ticketRepository;

        public SearchService(IBusScheduleRepository busScheduleRepository, ITicketRepository ticketRepository)
        {
            _busScheduleRepository = busScheduleRepository;
            _ticketRepository = ticketRepository;
        }

        public async Task<List<AvailableBusDto>> SearchAvailableBusesAsync(string from, string to, DateTime journeyDate)
        {
            // Normalize journey date to UTC
            var journeyDateUtc = journeyDate.ToUniversalTime();

            // Validate inputs
            if (string.IsNullOrWhiteSpace(from))
                throw new ArgumentException("From location cannot be empty");

            if (string.IsNullOrWhiteSpace(to))
                throw new ArgumentException("To location cannot be empty");

            if (journeyDateUtc < DateTime.UtcNow)
                throw new ArgumentException("Journey date-time cannot be in the past");

            // Get schedules
            var busSchedules = await _busScheduleRepository.GetSchedulesByRouteAndDateAsync(from, to, journeyDateUtc);

            var availableBuses = new List<AvailableBusDto>();

            foreach (var busSchedule in busSchedules)
            {
                // Find boarding and dropping stops
                var boardingStop = busSchedule.Route.RouteStops
                    .First(rs => rs.StopCode == from);
                var droppingStop = busSchedule.Route.RouteStops
                    .First(rs => rs.StopCode == to);

                // Calculate actual boarding and dropping times using TimeOffset
                var boardingTime = busSchedule.DepartureTime.Add(boardingStop.TimeOffset);
                var droppingTime = busSchedule.DepartureTime.Add(droppingStop.TimeOffset);

                // Calculate actual start and arrival DateTimes
                var startDateTime = busSchedule.JourneyDate.Date.Add(boardingTime);
                var arrivalDateTime = busSchedule.JourneyDate.Date.Add(droppingTime);

                // Calculate seats left
                var bookedSeats = await _ticketRepository.GetBookedSeatsCountAsync(busSchedule.Id);
                var seatsLeft = busSchedule.Bus.TotalSeats - bookedSeats;

                availableBuses.Add(new AvailableBusDto
                {
                    BusScheduleId = busSchedule.Id,
                    CompanyName = busSchedule.Bus.CompanyName,
                    BusName = busSchedule.Bus.BusName,
                    BusType = busSchedule.Bus.BusType.ToString(),
                    StartTime = startDateTime,
                    ArrivalTime = arrivalDateTime,
                    SeatsLeft = seatsLeft,
                    Price = busSchedule.Price,
                    RouteName = busSchedule.Route.RouteName
                });
            }

            return availableBuses.OrderBy(b => b.StartTime).ToList();
        }
    }
}
