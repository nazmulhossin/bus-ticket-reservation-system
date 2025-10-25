using BusTicketReservation.Application.Common.Validation;
using BusTicketReservation.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusTicketReservation.Application.Contracts.DTOs
{
    public class BookSeatInputDto
    {
        [NotEmptyGuid(ErrorMessage = "Bus schedule ID is required")]
        public Guid BusScheduleId { get; set; }

        [NotEmptyGuid(ErrorMessage = "Seat ID is required")]
        public Guid SeatId { get; set; }

        [Required(ErrorMessage = "Boarding stop code is required")]
        public string BoardingStopCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Dropping stop code is required")]
        public string DroppingStopCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Passenger name is required")]
        [StringLength(100, ErrorMessage = "Name must be less than or equal to 100 characters")]
        public string PassengerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^\+8801[3-9]\d{8}$", ErrorMessage = "Invalid Bangladesh mobile number")]
        public string MobileNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Gender is required")]
        public Gender PassengerGender { get; set; }
    }
}
