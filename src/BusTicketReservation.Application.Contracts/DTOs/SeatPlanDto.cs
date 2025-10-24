namespace BusTicketReservation.Application.Contracts.DTOs
{
    public class SeatPlanDto
    {
        public Guid BusScheduleId { get; set; }
        public string BusName { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public int Price { get; set; }
        public List<SeatDto> Seats { get; set; } = new();
    }
}
