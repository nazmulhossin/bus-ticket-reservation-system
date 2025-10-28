using BusTicketReservation.Application.Contracts.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketReservation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;
        private readonly ILogger<SearchController> _logger;

        public SearchController(ISearchService searchService, ILogger<SearchController> logger)
        {
            _searchService = searchService;
            _logger = logger;
        }

        [HttpGet("available-buses")]
        public async Task<IActionResult> SearchAvailableBuses([FromQuery] string from, [FromQuery] string to, [FromQuery] DateTime journeyDate)
        {
            try
            {
                var availableBuses = await _searchService.SearchAvailableBusesAsync(from, to, journeyDate);
                return Ok(availableBuses);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching for available buses");
                return StatusCode(500, new { message = "An error occurred while searching for buses." });
            }
        }
    }
}
