using BusTicketReservation.Application.Contracts.DTOs;

namespace BusTicketReservation.Application.Contracts.Interfaces.Services
{
    public interface IBookingService
    {
        Task<SeatPlanDto> GetSeatPlanAsync(Guid busScheduleId);
        Task<BookSeatResultDto> BookSeatAsync(BookSeatInputDto input);
    }
}
