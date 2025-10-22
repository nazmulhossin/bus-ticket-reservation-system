using System.ComponentModel.DataAnnotations;

namespace BusTicketReservation.Domain.Entities
{
    public class BusSchedule
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid BusId { get; set; }

        [Required]
        public Guid RouteId { get; set; }

        [Required]
        public DateTime JourneyDate { get; set; }

        [Required]
        public TimeSpan DepartureTime { get; set; }

        [Required]
        public TimeSpan ArrivalTime { get; set; }

        [Required]
        public int Price { get; set; }

        // Navigation properties
        public Bus Bus { get; set; } = null!;
        public Route Route { get; set; } = null!;
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
