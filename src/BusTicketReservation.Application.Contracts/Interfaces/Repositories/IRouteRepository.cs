using BusTicketReservation.Domain.Entities;

namespace BusTicketReservation.Application.Contracts.Interfaces.Repositories
{
    public interface IRouteRepository
    {
        Task<IReadOnlyList<RouteStop>> SearchRouteStopsAsync(string searchTerm, int limit = 5);
    }
}
