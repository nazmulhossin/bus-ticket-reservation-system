using BusTicketReservation.Domain.Entities;

namespace BusTicketReservation.Application.Contracts.Interfaces.Repositories
{
    public interface IPassengerRepository
    {
        Task<Passenger?> GetByMobileNumberAsync(string mobileNumber);
        Task<Passenger> AddAsync(Passenger passenger);
    }
}
