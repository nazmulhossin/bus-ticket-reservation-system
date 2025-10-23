using System.ComponentModel.DataAnnotations;

namespace BusTicketReservation.Domain.Entities
{
    public class RouteStop
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid RouteId { get; set; }

        [Required]
        [MaxLength(100)]
        public string StopName { get; set; } = string.Empty; // Display name (e.g., "Dhaka Airport")

        [Required]
        [MaxLength(50)]
        public string StopCode { get; set; } = string.Empty; // Unique search key (e.g., "dhaka_airport")

        [Required]
        public int StopOrder { get; set; }

        [Required]
        public TimeSpan TimeOffset { get; set; } // Time from route start

        // Navigation property
        public Route Route { get; set; } = null!;
    }
}
