namespace BusTicketReservation.Application.Contracts.DTOs
{
    public class TicketDetailsDto
    {
        public Guid TicketId { get; set; }
        public string PassengerName { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string BusName { get; set; } = string.Empty;
        public string SeatNumber { get; set; } = string.Empty;
        public string BoardingStop { get; set; } = string.Empty;
        public string DroppingStop { get; set; } = string.Empty;
        public DateTime BoardingTime { get; set; }
        public DateTime DroppingTime { get; set; }
        public DateTime JourneyDate { get; set; }
        public int Price { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
