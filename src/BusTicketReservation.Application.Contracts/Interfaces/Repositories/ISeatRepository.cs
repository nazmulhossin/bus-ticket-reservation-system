using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Domain.Enums;

namespace BusTicketReservation.Application.Contracts.Interfaces.Repositories
{
    public interface ISeatRepository
    {
        Task<List<Seat>> GetSeatsByBusIdAsync(Guid busId);
        Task<Seat?> GetSeatByIdAsync(Guid seatId);
        Task UpdateSeatStatusAsync(Guid seatId, SeatStatus status);
    }
}
