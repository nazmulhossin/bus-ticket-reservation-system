using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Application.Services;
using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Domain.Enums;
using Moq;

namespace BusTicketReservation.Tests.Services
{
    public class SearchServiceTests
    {
        private readonly Mock<IBusScheduleRepository> _mockBusScheduleRepo;
        private readonly Mock<ITicketRepository> _mockTicketRepo;
        private readonly SearchService _searchService;

        public SearchServiceTests()
        {
            _mockBusScheduleRepo = new Mock<IBusScheduleRepository>();
            _mockTicketRepo = new Mock<ITicketRepository>();
            _searchService = new SearchService(_mockBusScheduleRepo.Object, _mockTicketRepo.Object);
        }

        [Fact]
        public async Task SearchAvailableBusesAsync_WithValidCriteria_ReturnsAvailableBuses()
        {
            // Arrange
            var from = "kushtia_mojompur";
            var to = "dhaka_gabtoli";
            var journeyDate = DateTime.UtcNow.AddDays(1);
            var scheduleId = Guid.NewGuid();

            var busSchedule = CreateTestBusSchedule(scheduleId, from, to, journeyDate);
            var busSchedules = new List<BusSchedule> { busSchedule };

            _mockBusScheduleRepo
                .Setup(repo => repo.GetSchedulesByRouteAndDateAsync(from, to, journeyDate.ToUniversalTime()))
                .ReturnsAsync(busSchedules);

            _mockTicketRepo
                .Setup(repo => repo.GetBookedSeatsCountAsync(scheduleId))
                .ReturnsAsync(10);

            // Act
            var result = await _searchService.SearchAvailableBusesAsync(from, to, journeyDate);

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);

            var availableBus = result[0];
            Assert.Equal(scheduleId, availableBus.BusScheduleId);
            Assert.Equal("Royal Coach", availableBus.CompanyName);
            Assert.Equal("Royal Premium", availableBus.BusName);
            Assert.Equal("NonAC", availableBus.BusType);
            Assert.Equal(32, availableBus.SeatsLeft); // 42 total - 10 booked = 32 seats left
            Assert.Equal(500, availableBus.Price);
            Assert.Equal("Kushtia-Dhaka", availableBus.RouteName);

            // Verify time calculations
            var expectedStartTime = journeyDate.Date.Add(TimeSpan.FromHours(8)); // 8:00 AM + 0 offset
            var expectedArrivalTime = journeyDate.Date.Add(TimeSpan.FromHours(13)); // 8:00 AM + 5 hours offset
            Assert.Equal(expectedStartTime, availableBus.StartTime);
            Assert.Equal(expectedArrivalTime, availableBus.ArrivalTime);

            _mockBusScheduleRepo.Verify(repo =>
                repo.GetSchedulesByRouteAndDateAsync(from, to, journeyDate.ToUniversalTime()),
                Times.Once);
            _mockTicketRepo.Verify(repo =>
                repo.GetBookedSeatsCountAsync(scheduleId),
                Times.Once);
        }

        [Fact]
        public async Task SearchAvailableBusesAsync_WithMultipleBuses_ReturnsOrderedByStartTime()
        {
            // Arrange
            var from = "kushtia_mojompur";
            var to = "dhaka_gabtoli";
            var journeyDate = DateTime.UtcNow.AddDays(1);

            var earlySchedule = CreateTestBusSchedule(Guid.NewGuid(), from, to, journeyDate);
            earlySchedule.DepartureTime = TimeSpan.FromHours(6); // 6:00 AM

            var lateSchedule = CreateTestBusSchedule(Guid.NewGuid(), from, to, journeyDate);
            lateSchedule.DepartureTime = TimeSpan.FromHours(10); // 10:00 AM

            var busSchedules = new List<BusSchedule> { lateSchedule, earlySchedule };

            _mockBusScheduleRepo
                .Setup(repo => repo.GetSchedulesByRouteAndDateAsync(from, to, journeyDate.ToUniversalTime()))
                .ReturnsAsync(busSchedules);

            _mockTicketRepo
                .Setup(repo => repo.GetBookedSeatsCountAsync(It.IsAny<Guid>()))
                .ReturnsAsync(0);

            // Act
            var result = await _searchService.SearchAvailableBusesAsync(from, to, journeyDate);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.True(result[0].StartTime < result[1].StartTime); // Ordered by start time
            Assert.Equal(TimeSpan.FromHours(6), result[0].StartTime.TimeOfDay); // Early bus first
            Assert.Equal(TimeSpan.FromHours(10), result[1].StartTime.TimeOfDay); // Late bus second
        }

        [Theory]
        [InlineData("", "dhaka_gabtoli")]
        [InlineData(null, "dhaka_gabtoli")]
        [InlineData("  ", "dhaka_gabtoli")]
        [InlineData("kushtia_mojompur", "")]
        [InlineData("kushtia_mojompur", null)]
        [InlineData("kushtia_mojompur", "  ")]
        public async Task SearchAvailableBusesAsync_WithInvalidLocations_ThrowsArgumentException(string from, string to)
        {
            // Arrange
            var journeyDate = DateTime.UtcNow.AddDays(1);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                _searchService.SearchAvailableBusesAsync(from, to, journeyDate));
        }

        [Fact]
        public async Task SearchAvailableBusesAsync_WithPastJourneyDate_ThrowsArgumentException()
        {
            // Arrange
            var from = "kushtia_mojompur";
            var to = "dhaka_gabtoli";
            var pastDate = DateTime.UtcNow.AddDays(-1);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                _searchService.SearchAvailableBusesAsync(from, to, pastDate));
        }

        [Fact]
        public async Task SearchAvailableBusesAsync_WithNoAvailableBuses_ReturnsEmptyList()
        {
            // Arrange
            var from = "kushtia_mojompur";
            var to = "dhaka_gabtoli";
            var journeyDate = DateTime.UtcNow.AddDays(1);

            _mockBusScheduleRepo
                .Setup(repo => repo.GetSchedulesByRouteAndDateAsync(from, to, journeyDate.ToUniversalTime()))
                .ReturnsAsync(new List<BusSchedule>());

            // Act
            var result = await _searchService.SearchAvailableBusesAsync(from, to, journeyDate);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task SearchAvailableBusesAsync_WithFullyBookedBus_ReturnsBusWithZeroSeatsLeft()
        {
            // Arrange
            var from = "kushtia_mojompur";
            var to = "dhaka_gabtoli";
            var journeyDate = DateTime.UtcNow.AddDays(1);
            var scheduleId = Guid.NewGuid();

            var busSchedule = CreateTestBusSchedule(scheduleId, from, to, journeyDate);

            _mockBusScheduleRepo
                .Setup(repo => repo.GetSchedulesByRouteAndDateAsync(from, to, journeyDate.ToUniversalTime()))
                .ReturnsAsync(new List<BusSchedule> { busSchedule });

            _mockTicketRepo
                .Setup(repo => repo.GetBookedSeatsCountAsync(scheduleId))
                .ReturnsAsync(42); // All seats booked

            // Act
            var result = await _searchService.SearchAvailableBusesAsync(from, to, journeyDate);

            // Assert
            Assert.Single(result);
            Assert.Equal(0, result[0].SeatsLeft); // No seats left
        }

        [Fact]
        public async Task SearchAvailableBusesAsync_WithIntermediateStops_CalculatesCorrectTimes()
        {
            // Arrange
            var from = "kushtia_mirpur";
            var to = "dhaka_gabtoli";
            var journeyDate = DateTime.UtcNow.AddDays(1);
            var scheduleId = Guid.NewGuid();

            var busSchedule = CreateTestBusSchedule(scheduleId, from, to, journeyDate);

            _mockBusScheduleRepo
                .Setup(repo => repo.GetSchedulesByRouteAndDateAsync(from, to, journeyDate.ToUniversalTime()))
                .ReturnsAsync(new List<BusSchedule> { busSchedule });

            _mockTicketRepo
                .Setup(repo => repo.GetBookedSeatsCountAsync(scheduleId))
                .ReturnsAsync(0);

            // Act
            var result = await _searchService.SearchAvailableBusesAsync(from, to, journeyDate);

            // Assert
            Assert.Single(result);

            // Boarding at Kushtia (Mirpur) (2 hours offset from start)
            var expectedStartTime = journeyDate.Date.Add(TimeSpan.FromHours(8 + 1.5));
            // Dropping at Chittagong (5 hours offset from start)
            var expectedArrivalTime = journeyDate.Date.Add(TimeSpan.FromHours(8 + 5));

            Assert.Equal(expectedStartTime, result[0].StartTime);
            Assert.Equal(expectedArrivalTime, result[0].ArrivalTime);
        }

        private BusSchedule CreateTestBusSchedule(
            Guid scheduleId,
            string fromStopCode = "kushtia_mojompur",
            string toStopCode = "dhaka_gabtoli",
            DateTime? journeyDate = null)
        {
            var route = new Route
            {
                Id = Guid.NewGuid(),
                RouteName = "Kushtia-Dhaka",
                RouteStops = new List<RouteStop>
                {
                    new() { Id = Guid.NewGuid(), StopName = "Kushtia (Mojompur)", StopCode = "kushtia_mojompur", StopOrder = 1, TimeOffset = TimeSpan.Zero },
                    new() { Id = Guid.NewGuid(), StopName = "Kushtia (Mirpur)", StopCode = "kushtia_mirpur", StopOrder = 2, TimeOffset = TimeSpan.FromHours(1.5) },
                    new() { Id = Guid.NewGuid(), StopName = "Dhaka (Gabtoli)", StopCode = "dhaka_gabtoli", StopOrder = 3, TimeOffset = TimeSpan.FromHours(5) }
                }
            };

            var bus = new Bus
            {
                Id = Guid.NewGuid(),
                CompanyName = "Royal Coach",
                BusName = "Royal Premium",
                BusType = BusType.NonAC,
                TotalSeats = 42
            };

            return new BusSchedule
            {
                Id = scheduleId,
                BusId = bus.Id,
                RouteId = route.Id,
                JourneyDate = journeyDate ?? DateTime.UtcNow.AddDays(1).Date,
                DepartureTime = TimeSpan.FromHours(8), // 8:00 AM
                ArrivalTime = TimeSpan.FromHours(13),  // 1:00 PM
                Price = 500,
                Bus = bus,
                Route = route
            };
        }
    }
}
