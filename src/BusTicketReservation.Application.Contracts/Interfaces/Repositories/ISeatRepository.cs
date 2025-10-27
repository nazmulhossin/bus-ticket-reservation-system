using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Domain.Enums;

namespace BusTicketReservation.Application.Contracts.Interfaces.Repositories
{
    public interface ISeatRepository
    {
        Task<List<Seat>> GetSeatsByBusIdAsync(Guid busId);
        Task<Seat?> GetSeatByIdAsync(Guid seatId);
        Task<List<Seat>> GetSeatsByIdsAsync(List<Guid> seatIds);
        Task UpdateSeatStatusAsync(Guid seatId, SeatStatus status);
        Task UpdateSeatStatusRangeAsync(List<Guid> seatIds, SeatStatus status);
    }
}
