using BusTicketReservation.Application.Contracts.DTOs;

namespace BusTicketReservation.Application.Contracts.Interfaces.Services
{
    public interface IRouteService
    {
        Task<List<SearchRouteStopResultDto>> GetRouteStopSuggestionsAsync(string searchTerm, int limit = 5);
    }
}
