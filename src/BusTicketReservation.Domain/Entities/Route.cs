using System.ComponentModel.DataAnnotations;

namespace BusTicketReservation.Domain.Entities
{
    public class Route
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string RouteName { get; set; } = string.Empty; // e.g., "Dhaka-Chittagong"

        // Navigation properties
        public ICollection<RouteStop> RouteStops { get; set; } = new List<RouteStop>();
        public ICollection<BusSchedule> BusSchedules { get; set; } = new List<BusSchedule>();
    }
}
