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

        public async Task<bool> IsSeatBookedForScheduleAsync(Guid seatId, Guid busScheduleId)
        {
            return await _db.Tickets
                .AnyAsync(t => t.SeatId == seatId && t.BusScheduleId == busScheduleId);
        }

        public async Task AddAsync(Ticket ticket)
        {
            await _db.Tickets.AddAsync(ticket);
        }

        public async Task<Ticket?> GetTicketByIdAsync(Guid ticketId)
        {
            return await _db.Tickets.FindAsync(ticketId);
        }
    }
}
