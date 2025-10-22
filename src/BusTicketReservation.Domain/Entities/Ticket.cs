using System.ComponentModel.DataAnnotations;

namespace BusTicketReservation.Domain.Entities
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid BusScheduleId { get; set; }

        [Required]
        public Guid SeatId { get; set; }

        [Required]
        public Guid PassengerId { get; set; }

        [Required]
        public Guid BoardingStopId { get; set; }

        [Required]
        public Guid DroppingStopId { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        // Navigation properties
        public BusSchedule BusSchedule { get; set; } = null!;
        public Seat Seat { get; set; } = null!;
        public Passenger Passenger { get; set; } = null!;
        public RouteStop BoardingStop { get; set; } = null!;
        public RouteStop DroppingStop { get; set; } = null!;
    }
}
