using BusTicketReservation.Application.Contracts.DTOs;
using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Application.Contracts.Interfaces.Services;
using BusTicketReservation.Domain.Entities;
using System.Collections.Generic;

namespace BusTicketReservation.Application.Services
{
    public class RouteService : IRouteService
    {
        private readonly IRouteRepository _routeRepository;

        public RouteService(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
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
    }
}
