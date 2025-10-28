using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Domain.Enums;
using BusTicketReservation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BusTicketReservation.Infrastructure.Repositories
{
    public class SeatRepository : ISeatRepository
    {
        private readonly ApplicationDbContext _db;

        public SeatRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Seat>> GetSeatsByBusIdAsync(Guid busId)
        {
            return await _db.Seats
                .Where(s => s.BusId == busId)
                .OrderBy(s => s.RowNumber)
                .ThenBy(s => s.SeatNumber)
                .ToListAsync();
        }

        public async Task<Seat?> GetSeatByIdAsync(Guid seatId)
        {
            return await _db.Seats.FindAsync(seatId);
        }

        public async Task<List<Seat>> GetSeatsByIdsAsync(List<Guid> seatIds)
        {
            return await _db.Seats
                .Where(s => seatIds.Contains(s.Id))
                .ToListAsync();
        }

        public async Task UpdateSeatStatusAsync(Guid seatId, SeatStatus status)
        {
            var seat = await GetSeatByIdAsync(seatId);
            if (seat != null)
            {
                seat.Status = status;
                _db.Seats.Update(seat);
            }
        }

        public async Task UpdateSeatStatusRangeAsync(List<Guid> seatIds, SeatStatus status)
        {
            var seats = await _db.Seats
                .Where(s => seatIds.Contains(s.Id))
                .ToListAsync();

            foreach (var seat in seats)
            {
                seat.Status = status;
            }

            _db.Seats.UpdateRange(seats);
        }
    }
}
