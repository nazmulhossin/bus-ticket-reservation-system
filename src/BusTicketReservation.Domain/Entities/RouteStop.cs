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
        public string StopName { get; set; } = string.Empty;

        [Required]
        public int StopOrder { get; set; }

        [Required]
        public TimeSpan TimeOffset { get; set; } // Time from route start

        // Navigation property
        public Route Route { get; set; } = null!;
    }
}
