namespace BusTicketReservation.Application.Contracts.DTOs
{
    public class AvailableBusDto
    {
        public Guid BusScheduleId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string BusName { get; set; } = string.Empty;
        public string BusType { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int SeatsLeft { get; set; }
        public int Price { get; set; }
        public string RouteName { get; set; } = string.Empty;
    }
}
