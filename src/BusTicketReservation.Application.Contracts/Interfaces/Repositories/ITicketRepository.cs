using BusTicketReservation.Domain.Entities;

namespace BusTicketReservation.Application.Contracts.Interfaces.Repositories
{
    public interface ITicketRepository
    {
        Task<int> GetBookedSeatsCountAsync(Guid busScheduleId);
        Task<Dictionary<Guid, Ticket>> GetTicketsForBusScheduleAsync(Guid busScheduleId);
        Task<bool> IsSeatBookedForScheduleAsync(Guid seatId, Guid busScheduleId);
        Task AddAsync(Ticket ticket);
        Task AddRangeAsync(List<Ticket> tickets);
        Task<Ticket?> GetTicketByIdAsync(Guid ticketId);
    }
}
