namespace BusTicketReservation.Application.Contracts.DTOs
{
    public class BookingSummaryDto
    {
        public string PassengerName { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string BusName { get; set; } = string.Empty;
        public List<string> SeatNumbers { get; set; } = new List<string>();
        public string BoardingStop { get; set; } = string.Empty;
        public string DroppingStop { get; set; } = string.Empty;
        public DateTime BoardingTime { get; set; }
        public DateTime DroppingTime { get; set; }
        public DateTime JourneyDate { get; set; }
        public int TotalPrice { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
