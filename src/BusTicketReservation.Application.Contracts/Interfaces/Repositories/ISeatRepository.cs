using BusTicketReservation.Domain.Entities;

namespace BusTicketReservation.Application.Contracts.Interfaces.Repositories
{
    public interface ISeatRepository
    {
        Task<List<Seat>> GetSeatsByBusIdAsync(Guid busId);
    }
}
