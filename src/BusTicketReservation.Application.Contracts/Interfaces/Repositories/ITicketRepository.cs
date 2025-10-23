namespace BusTicketReservation.Application.Contracts.Interfaces.Repositories
{
    public interface ITicketRepository
    {
        Task<int> GetBookedSeatsCountAsync(Guid busScheduleId);
    }
}
