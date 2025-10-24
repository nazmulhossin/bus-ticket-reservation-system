using BusTicketReservation.Domain.Entities;

namespace BusTicketReservation.Application.Contracts.Interfaces.Repositories
{
    public interface IBusScheduleRepository
    {
        Task<List<BusSchedule>> GetSchedulesByRouteAndDateAsync(string from, string to, DateTime journeyDate);
        Task<BusSchedule?> GetBusScheduleWithBusAsync(Guid busScheduleId);
    }
}
