using BusTicketReservation.Domain.Enums;
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
        public string SeatNumber { get; set; } = string.Empty; // i.e., A1, A2,...

        [Required]
        public int RowNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public SeatStatus Status { get; set; }

        // Navigation properties
        public Bus Bus { get; set; } = null!;
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
