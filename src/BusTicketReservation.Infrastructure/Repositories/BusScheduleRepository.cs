using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BusTicketReservation.Infrastructure.Repositories
{
    public class BusScheduleRepository : IBusScheduleRepository
    {
        private readonly ApplicationDbContext _db;

        public BusScheduleRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<BusSchedule>> GetSchedulesByRouteAndDateAsync(string from, string to, DateTime journeyDate)
        {
            return await _db.BusSchedules
                .Include(bs => bs.Bus)
                .Include(bs => bs.Route)
                    .ThenInclude(r => r.RouteStops.OrderBy(rs => rs.StopOrder))
                .Where(bs => bs.JourneyDate.Date == journeyDate.Date)
                .Where(bs => bs.Route.RouteStops.Any(rs => rs.StopCode == from) &&
                             bs.Route.RouteStops.Any(rs => rs.StopCode == to))
                .Where(bs => bs.Route.RouteStops.First(rs => rs.StopCode == from).StopOrder <
                             bs.Route.RouteStops.First(rs => rs.StopCode == to).StopOrder)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<BusSchedule?> GetBusScheduleWithBusAsync(Guid busScheduleId)
        {
            return await _db.BusSchedules
                .Include(bs => bs.Bus)
                .FirstOrDefaultAsync(bs => bs.Id == busScheduleId);
        }

        public async Task<BusSchedule?> GetBusScheduleWithBusAndRouteAsync(Guid busScheduleId)
        {
            return await _db.BusSchedules
                .Include(bs => bs.Bus)
                .Include(bs => bs.Route)
                    .ThenInclude(r => r.RouteStops)
                .FirstOrDefaultAsync(bs => bs.Id == busScheduleId);
        }
    }
}
