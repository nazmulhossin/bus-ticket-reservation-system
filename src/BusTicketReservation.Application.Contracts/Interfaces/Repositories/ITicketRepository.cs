using BusTicketReservation.Domain.Entities;

namespace BusTicketReservation.Application.Contracts.Interfaces.Repositories
{
    public interface ITicketRepository
    {
        Task<int> GetBookedSeatsCountAsync(Guid busScheduleId);
        Task<Dictionary<Guid, Ticket>> GetTicketsForBusScheduleAsync(Guid busScheduleId);
    }
}
