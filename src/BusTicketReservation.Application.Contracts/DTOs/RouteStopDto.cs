namespace BusTicketReservation.Application.Contracts.DTOs
{
    public class RouteStopDto
    {
        public string StopName { get; set; } = string.Empty;
        public string StopCode { get; set; } = string.Empty;
        public int StopOrder { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
