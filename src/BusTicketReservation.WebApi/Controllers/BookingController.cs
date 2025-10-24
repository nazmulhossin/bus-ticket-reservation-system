using BusTicketReservation.Application.Contracts.DTOs;
using BusTicketReservation.Application.Contracts.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketReservation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly ILogger<BookingController> _logger;

        public BookingController(IBookingService bookingService, ILogger<BookingController> logger)
        {
            _bookingService = bookingService;
            _logger = logger;
        }

        [HttpGet("seat-plan/{busScheduleId:guid}")]
        public async Task<ActionResult<SeatPlanDto>> GetSeatPlan(Guid busScheduleId)
        {
            try
            {
                var seatPlan = await _bookingService.GetSeatPlanAsync(busScheduleId);
                return Ok(seatPlan);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving seat plan");
                return StatusCode(500, new { message = "An error occurred while retrieving the seat plan." });
            }
        }
    }
}
