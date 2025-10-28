using BusTicketReservation.Application.Contracts.DTOs;
using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Application.Services;
using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Domain.Enums;
using Moq;

namespace BusTicketReservation.Tests.Services
{
    public class BookingServiceTests
    {
        private readonly Mock<IBusScheduleRepository> _busScheduleRepositoryMock;
        private readonly Mock<ITicketRepository> _ticketRepositoryMock;
        private readonly Mock<ISeatRepository> _seatRepositoryMock;
        private readonly Mock<IPassengerRepository> _passengerRepositoryMock;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly BookingService _bookingService;

        public BookingServiceTests()
        {
            _busScheduleRepositoryMock = new Mock<IBusScheduleRepository>();
            _ticketRepositoryMock = new Mock<ITicketRepository>();
            _seatRepositoryMock = new Mock<ISeatRepository>();
            _passengerRepositoryMock = new Mock<IPassengerRepository>();
            _unitOfWorkMock = new Mock<IUnitOfWork>();

            _bookingService = new BookingService(
                _busScheduleRepositoryMock.Object,
                _ticketRepositoryMock.Object,
                _seatRepositoryMock.Object,
                _passengerRepositoryMock.Object,
                _unitOfWorkMock.Object);
        }

        [Fact]
        public async Task GetSeatPlanAsync_WithValidBusScheduleId_ReturnsSeatPlan()
        {
            // Arrange
            var busScheduleId = Guid.NewGuid();
            var busId = Guid.NewGuid();
            var busSchedule = CreateTestBusSchedule(busScheduleId, busId);
            var seats = CreateTestSeats(busId, 2);

            _busScheduleRepositoryMock
                .Setup(repo => repo.GetBusScheduleWithBusAsync(busScheduleId))
                .ReturnsAsync(busSchedule);

            _seatRepositoryMock
                .Setup(repo => repo.GetSeatsByBusIdAsync(busId))
                .ReturnsAsync(seats);

            _ticketRepositoryMock
                .Setup(repo => repo.GetTicketsForBusScheduleAsync(busScheduleId))
                .ReturnsAsync(new Dictionary<Guid, Ticket>());

            // Act
            var result = await _bookingService.GetSeatPlanAsync(busScheduleId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(busScheduleId, result.BusScheduleId);
            Assert.Equal("Royal Premium", result.BusName);
            Assert.Equal("Royal Coach", result.CompanyName);
            Assert.Equal(500, result.Price);
            Assert.Equal(2, result.Seats.Count);
            Assert.All(result.Seats, seat => Assert.Equal("Available", seat.Status));

            _busScheduleRepositoryMock.Verify(repo => repo.GetBusScheduleWithBusAsync(busScheduleId), Times.Once);
            _seatRepositoryMock.Verify(repo => repo.GetSeatsByBusIdAsync(busId), Times.Once);
            _ticketRepositoryMock.Verify(repo => repo.GetTicketsForBusScheduleAsync(busScheduleId), Times.Once);
        }

        [Fact]
        public async Task GetSeatPlanAsync_WithEmptyGuid_ThrowsArgumentException()
        {
            // Arrange
            var emptyGuid = Guid.Empty;

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                _bookingService.GetSeatPlanAsync(emptyGuid));
        }

        [Fact]
        public async Task GetSeatPlanAsync_WithNonExistentSchedule_ThrowsInvalidOperationException()
        {
            // Arrange
            var scheduleId = Guid.NewGuid();

            _busScheduleRepositoryMock
                .Setup(repo => repo.GetBusScheduleWithBusAsync(scheduleId))
                .ReturnsAsync((BusSchedule?)null);

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(() =>
                _bookingService.GetSeatPlanAsync(scheduleId));
        }

        [Fact]
        public async Task BookSeatAsync_WithValidInput_BooksSeatsSuccessfully()
        {
            // Arrange
            var busScheduleId = Guid.NewGuid();
            var busId = Guid.NewGuid();
            var seatIds = new List<Guid> { Guid.NewGuid(), Guid.NewGuid() };

            var input = new BookSeatInputDto
            {
                BusScheduleId = busScheduleId,
                SeatIds = seatIds,
                BoardingStopCode = "kushtia_mojompur",
                DroppingStopCode = "dhaka_gabtoli",
                PassengerName = "Md Nazmul Hossain",
                MobileNumber = "+8801941101888",
                PassengerGender = Gender.Male
            };

            var busSchedule = CreateTestBusSchedule(busScheduleId, busId);
            var seats = CreateTestSeats(busId, 2);
            for (int i = 0; i < seatIds.Count; i++)
            {
                seats[i].Id = seatIds[i];
            }

            _busScheduleRepositoryMock
                .Setup(repo => repo.GetBusScheduleWithBusAndRouteAsync(busScheduleId))
                .ReturnsAsync(busSchedule);

            _seatRepositoryMock
                .Setup(repo => repo.GetSeatsByIdsAsync(seatIds))
                .ReturnsAsync(seats);

            _ticketRepositoryMock
                .Setup(repo => repo.IsSeatBookedForScheduleAsync(It.IsAny<Guid>(), busScheduleId))
                .ReturnsAsync(false);

            _passengerRepositoryMock
                .Setup(repo => repo.GetByMobileNumberAsync(input.MobileNumber))
                .ReturnsAsync((Passenger?)null);

            _passengerRepositoryMock
                .Setup(r => r.AddAsync(It.IsAny<Passenger>()))
                .ReturnsAsync((Passenger p) => p);

            _unitOfWorkMock
                .Setup(uow => uow.BeginTransactionAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            _unitOfWorkMock
                .Setup(uow => uow.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(1);
            _unitOfWorkMock.Setup(uow => uow.CommitTransactionAsync()).Returns(Task.CompletedTask);

            // Act
            var result = await _bookingService.BookSeatAsync(input);

            // Assert
            Assert.True(result.Success);
            Assert.Equal("Seat(s) booked successfully", result.Message);
            Assert.NotNull(result.BookingSummary);
            Assert.Equal("Md Nazmul Hossain", result.BookingSummary.PassengerName);
            Assert.Equal("Kushtia (Mojompur)", result.BookingSummary.BoardingStop);
            Assert.Equal("Dhaka (Gabtoli)", result.BookingSummary.DroppingStop);
            Assert.Equal(2, result.BookingSummary.SeatNumbers.Count);
            Assert.Equal(1000, result.BookingSummary.TotalPrice); // 2 seats × 500

            // Verify repository calls
            _ticketRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<Ticket>()), Times.Exactly(2));
            _seatRepositoryMock.Verify(repo => repo.UpdateSeatStatusRangeAsync(seatIds, SeatStatus.Booked), Times.Once);
            _unitOfWorkMock.Verify(uow => uow.CommitTransactionAsync(), Times.Once);
        }

        [Fact]
        public async Task BookSeatAsync_WithExistingPassenger_UpdatesPassengerDetails()
        {
            // Arrange
            var busScheduleId = Guid.NewGuid();
            var busId = Guid.NewGuid();
            var seatId = Guid.NewGuid();

            var input = new BookSeatInputDto
            {
                BusScheduleId = busScheduleId,
                SeatIds = new List<Guid> { seatId },
                BoardingStopCode = "kushtia_mojompur",
                DroppingStopCode = "dhaka_gabtoli",
                PassengerName = "Simu",
                MobileNumber = "+8801941101888",
                PassengerGender = Gender.Female
            };

            var busSchedule = CreateTestBusSchedule(busScheduleId, busId);
            var seats = CreateTestSeats(busId, 1);
            seats[0].Id = seatId;

            var existingPassenger = new Passenger
            {
                Id = Guid.NewGuid(),
                Name = "Md Nazmul Hossain",
                MobileNumber = "+8801941101888",
                Gender = Gender.Male
            };

            _busScheduleRepositoryMock
                .Setup(repo => repo.GetBusScheduleWithBusAndRouteAsync(busScheduleId))
                .ReturnsAsync(busSchedule);

            _seatRepositoryMock
                .Setup(repo => repo.GetSeatsByIdsAsync(It.IsAny<List<Guid>>()))
                .ReturnsAsync(seats);

            _ticketRepositoryMock
                .Setup(repo => repo.IsSeatBookedForScheduleAsync(It.IsAny<Guid>(), busScheduleId))
                .ReturnsAsync(false);

            _passengerRepositoryMock
                .Setup(repo => repo.GetByMobileNumberAsync(input.MobileNumber))
                .ReturnsAsync(existingPassenger);

            _unitOfWorkMock
                .Setup(uow => uow.BeginTransactionAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            _unitOfWorkMock
                .Setup(uow => uow.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(1);
            _unitOfWorkMock.Setup(uow => uow.CommitTransactionAsync()).Returns(Task.CompletedTask);

            // Act
            var result = await _bookingService.BookSeatAsync(input);

            // Assert
            Assert.True(result.Success);
            Assert.NotNull(result.BookingSummary);
            Assert.Equal("Simu", result.BookingSummary.PassengerName);
            Assert.Equal("Female", result.BookingSummary.Gender);
        }

        [Theory]
        [InlineData("invalid_stop", "dhaka_gabtoli")]
        [InlineData("kushtia_mojompur", "invalid_stop")]
        public async Task BookSeatAsync_WithInvalidStops_ReturnsFailure(string boardingStop, string droppingStop)
        {
            // Arrange
            var busScheduleId = Guid.NewGuid();
            var busId = Guid.NewGuid();
            var seatId = Guid.NewGuid();

            var input = new BookSeatInputDto
            {
                BusScheduleId = busScheduleId,
                SeatIds = new List<Guid> { seatId },
                BoardingStopCode = boardingStop,
                DroppingStopCode = droppingStop
            };

            var busSchedule = CreateTestBusSchedule(busScheduleId, busId);
            var seats = CreateTestSeats(busId, 1);
            seats[0].Id = seatId;

            _busScheduleRepositoryMock
                .Setup(repo => repo.GetBusScheduleWithBusAndRouteAsync(busScheduleId))
                .ReturnsAsync(busSchedule);

            _seatRepositoryMock
                .Setup(repo => repo.GetSeatsByIdsAsync(input.SeatIds))
                .ReturnsAsync(seats);

            _ticketRepositoryMock
                .Setup(repo => repo.IsSeatBookedForScheduleAsync(seatId, busScheduleId))
                .ReturnsAsync(false);

            _unitOfWorkMock
                .Setup(uow => uow.BeginTransactionAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _bookingService.BookSeatAsync(input);

            // Assert
            Assert.False(result.Success);
            Assert.Equal("Invalid boarding or dropping stop", result.Message);
        }

        private BusSchedule CreateTestBusSchedule(Guid scheduleId, Guid busId)
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
                Id = busId,
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
                JourneyDate = DateTime.UtcNow.AddDays(1).Date,
                DepartureTime = TimeSpan.FromHours(8),
                ArrivalTime = TimeSpan.FromHours(13),
                Price = 500,
                Bus = bus,
                Route = route
            };
        }

        private List<Seat> CreateTestSeats(Guid busId, int totalSeats = 8)
        {
            var seats = new List<Seat>();
            var seatsPerRow = 4;
            var rows = (int)Math.Ceiling((double)totalSeats / seatsPerRow);
            var seatCounter = 0;

            for (int row = 1; row <= rows; row++)
            {
                char rowLetter = (char)('A' + row - 1);

                for (int col = 1; col <= seatsPerRow && seatCounter < totalSeats; col++)
                {
                    var seatLabel = $"{rowLetter}{col}";

                    seats.Add(new Seat
                    {
                        Id = Guid.NewGuid(),
                        BusId = busId,
                        SeatNumber = seatLabel,
                        RowNumber = row,
                        Status = SeatStatus.Available
                    });

                    seatCounter++;
                }
            }
            return seats;
        }
    }
}
