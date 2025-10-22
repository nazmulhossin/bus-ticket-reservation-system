using System.ComponentModel.DataAnnotations;

namespace BusTicketReservation.Domain.Entities
{
    public class Seat
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid BusId { get; set; }

        [Required]
        [MaxLength(10)]
        public string SeatNumber { get; set; } = string.Empty;

        [Required]
        public int RowNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public Staus Status { get; set; }

        // Navigation properties
        public Bus Bus { get; set; } = null!;
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }

    public enum Staus
    {
        Available = 0,
        Booked = 1,
        Sold = 2
    }
}
