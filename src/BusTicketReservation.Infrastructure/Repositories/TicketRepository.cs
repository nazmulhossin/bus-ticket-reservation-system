using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BusTicketReservation.Infrastructure.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext _db;

        public TicketRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<int> GetBookedSeatsCountAsync(Guid busScheduleId)
        {
            return await _db.Tickets
                .Where(t => t.BusScheduleId == busScheduleId)
                .CountAsync();
        }
    }
}
