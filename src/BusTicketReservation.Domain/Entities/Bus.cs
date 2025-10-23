using BusTicketReservation.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusTicketReservation.Domain.Entities
{
    public class Bus
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string BusName { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public BusType BusType { get; set; }

        [Required]
        public int TotalSeats { get; set; }

        // Navigation properties
        public ICollection<BusSchedule> BusSchedules { get; set; } = new List<BusSchedule>();
        public ICollection<Seat> Seats { get; set; } = new List<Seat>();
    }
}
