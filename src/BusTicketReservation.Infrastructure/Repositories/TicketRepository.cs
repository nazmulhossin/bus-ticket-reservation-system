using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Domain.Entities;
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

        public async Task<Dictionary<Guid, Ticket>> GetTicketsForBusScheduleAsync(Guid busScheduleId)
        {
            return await _db.Tickets
                .Where(t => t.BusScheduleId == busScheduleId)
                .Include(t => t.Passenger)
                .AsNoTracking()
                .ToDictionaryAsync(t => t.SeatId, t => t);
        }
    }
}
