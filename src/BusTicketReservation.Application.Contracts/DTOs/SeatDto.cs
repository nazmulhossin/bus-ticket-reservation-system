namespace BusTicketReservation.Application.Contracts.DTOs
{
    public class SeatDto
    {
        public Guid SeatId { get; set; }
        public string SeatNumber { get; set; } = string.Empty;
        public int RowNumber { get; set; }
        public string Status { get; set; } = string.Empty;
        public string? Gender { get; set; }
    }
}
