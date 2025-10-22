using System.ComponentModel.DataAnnotations;

namespace BusTicketReservation.Domain.Entities
{
    public class Passenger
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(15)]
        public string MobileNumber { get; set; } = string.Empty;

        [Required]
        public Gender Gender { get; set; }

        // Navigation
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }
}
