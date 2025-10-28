using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BusTicketReservation.Infrastructure.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        private readonly ApplicationDbContext _db;

        public RouteRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IReadOnlyList<RouteStop>> SearchRouteStopsAsync(string searchTerm, int limit = 5)
        {
            var normalizedSearchTerm = searchTerm.Trim().ToLower();

            return await _db.RouteStops
                .Where(rs => rs.StopName.ToLower().Contains(normalizedSearchTerm))
                .OrderBy(rs => rs.StopName)
                .ToListAsync();
        }
    }
}
