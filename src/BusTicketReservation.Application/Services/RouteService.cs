using BusTicketReservation.Application.Contracts.DTOs;
using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Application.Contracts.Interfaces.Services;

namespace BusTicketReservation.Application.Services
{
    public class RouteService : IRouteService
    {
        private readonly IRouteRepository _routeRepository;
        private readonly IBusScheduleRepository _busScheduleRepository;

        public RouteService(IRouteRepository routeRepository, IBusScheduleRepository busScheduleRepository)
        {
            _routeRepository = routeRepository;
            _busScheduleRepository = busScheduleRepository;
        }

        public async Task<List<SearchRouteStopResultDto>> GetRouteStopSuggestionsAsync(string searchTerm, int limit = 5)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return new List<SearchRouteStopResultDto>();

            // Get filtered route stops
            var routeStops = await _routeRepository.SearchRouteStopsAsync(searchTerm);

            if (routeStops == null || !routeStops.Any())
                return new List<SearchRouteStopResultDto>();

            var uniqueRouteStops = routeStops
                .GroupBy(rs => new {rs.StopCode, rs.StopName })
                .Select(g => new SearchRouteStopResultDto
                {
                    StopCode = g.Key.StopCode,
                    StopName = g.Key.StopName
                })
                .OrderBy(rs => rs.StopName)
                .Take(limit)
                .ToList();

            return uniqueRouteStops;
        }

        public async Task<List<RouteStopDto>> GetBoardingDroppingStopsAsync(Guid busScheduleId)
        {
            var busSchedule = await _busScheduleRepository.GetBusScheduleWithRouteAsync(busScheduleId);
            if (busSchedule == null)
                return new List<RouteStopDto>();

            return busSchedule.Route.RouteStops
                .Select(rs => new RouteStopDto
                {
                    StopCode = rs.StopCode,
                    StopName = rs.StopName,
                    StopOrder = rs.StopOrder,
                    ArrivalTime = busSchedule.JourneyDate.Date.Add(busSchedule.DepartureTime.Add(rs.TimeOffset))
                }) 
                .OrderBy(rs => rs.StopOrder)
                .ToList();
        }
    }
}
