using BusTicketReservation.Application.Contracts.DTOs;

namespace BusTicketReservation.Application.Contracts.Interfaces.Services
{
    public interface ISearchService
    {
        Task<List<AvailableBusDto>> SearchAvailableBusesAsync(string from, string to, DateTime journeyDate);
    }
}
