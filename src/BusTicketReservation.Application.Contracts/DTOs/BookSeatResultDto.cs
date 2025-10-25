namespace BusTicketReservation.Application.Contracts.DTOs
{
    public class BookSeatResultDto
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public TicketDetailsDto? TicketDetails { get; set; }
    }
}
