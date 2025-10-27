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

        [HttpPost("book-seat")]
        public async Task<ActionResult<BookSeatResultDto>> BookSeat([FromBody] BookSeatInputDto input)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new
                    {
                        Success = false,
                        Message = "Invalid input data",
                        Errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage))
                    });
                }

                var result = await _bookingService.BookSeatAsync(input);

                if (!result.Success)
                {
                    if (result.Message.Contains("not found"))
                    {
                        return NotFound(new
                        {
                            Success = false,
                            Message = result.Message
                        });
                    }

                    return BadRequest(new
                    {
                        Success = false,
                        Message = result.Message
                    });
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while booking seat.");
                return StatusCode(500, new
                {
                    Success = false,
                    Message = "An error occurred while booking the seat. Please try again later."
                });
            }
        }
    }
}
