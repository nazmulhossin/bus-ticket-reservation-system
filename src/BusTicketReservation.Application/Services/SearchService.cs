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
            // Validate inputs
            if (string.IsNullOrWhiteSpace(from))
                throw new ArgumentException("From location cannot be empty");

            if (string.IsNullOrWhiteSpace(to))
                throw new ArgumentException("To location cannot be empty");

            if (journeyDate.Date < DateTime.UtcNow.Date)
                throw new ArgumentException("Journey date cannot be in the past");

            // Get schedules
            var journeyDateUtc = journeyDate.ToUniversalTime();
            var schedules = await _busScheduleRepository.GetSchedulesByRouteAndDateAsync(from, to, journeyDateUtc);

            var availableBuses = new List<AvailableBusDto>();

            foreach (var schedule in schedules)
            {
                // Find boarding and dropping stops
                var boardingStop = schedule.Route.RouteStops
                    .First(rs => rs.StopCode == from);
                var droppingStop = schedule.Route.RouteStops
                    .First(rs => rs.StopCode == to);

                // Calculate actual boarding and dropping times using TimeOffset
                var boardingTime = schedule.DepartureTime.Add(boardingStop.TimeOffset);
                var droppingTime = schedule.DepartureTime.Add(droppingStop.TimeOffset);

                // Calculate actual start and arrival DateTimes
                var startDateTime = schedule.JourneyDate.Date.Add(boardingTime);
                var arrivalDateTime = schedule.JourneyDate.Date.Add(droppingTime);

                // Calculate seats left
                var bookedSeats = await _ticketRepository.GetBookedSeatsCountAsync(schedule.Id);
                var seatsLeft = schedule.Bus.TotalSeats - bookedSeats;

                availableBuses.Add(new AvailableBusDto
                {
                    BusScheduleId = schedule.Id,
                    CompanyName = schedule.Bus.CompanyName,
                    BusName = schedule.Bus.BusName,
                    BusType = schedule.Bus.BusType.ToString(),
                    StartTime = startDateTime.ToString("hh:mm tt"),
                    ArrivalTime = arrivalDateTime.ToString("hh:mm tt"),
                    SeatsLeft = seatsLeft,
                    Price = schedule.Price,
                    RouteName = schedule.Route.RouteName
                });
            }

            return availableBuses.OrderBy(b => b.StartTime).ToList();
        }
    }
}
