using BusTicketReservation.Application.Contracts.DTOs;
using BusTicketReservation.Application.Contracts.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketReservation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IRouteService _routeService;
        private readonly ILogger<RouteController> _logger;

        public RouteController(IRouteService routeService, ILogger<RouteController> logger)
        {
            _routeService = routeService;
            _logger = logger;
        }

        [HttpGet("route-stops/suggestions")]
        public async Task<IActionResult> GetRouteStopSuggestions([FromQuery] string search)
        {
            try
            {
                var result = await _routeService.GetRouteStopSuggestionsAsync(search);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving route stop suggestions");
                return StatusCode(500, new { Message = "An error occurred while retrieving route stop suggestions" });
            }
        }

        [HttpGet("bus-schedule/{busScheduleId:guid}/stops")]
        public async Task<IActionResult> GetBoardingDroppingStops(Guid busScheduleId)
        {
            try
            {
                if (busScheduleId == Guid.Empty)
                    return BadRequest(new { Message = "Invalid bus schedule ID" });
                
                var result = await _routeService.GetBoardingDroppingStopsAsync(busScheduleId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving available stops");
                return StatusCode(500, new { Message = "An error occurred while retrieving stops" });
            }
        }
    }
}
