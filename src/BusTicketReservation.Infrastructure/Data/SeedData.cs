using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace BusTicketReservation.Infrastructure.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Generate GUIDs for Buses
            var bus1Id = Guid.NewGuid();
            var bus2Id = Guid.NewGuid();
            var bus3Id = Guid.NewGuid();
            var bus4Id = Guid.NewGuid();
            var bus5Id = Guid.NewGuid();
            var bus6Id = Guid.NewGuid();

            // Seed Buses
            var buses = new[]
            {
                new Bus
                {
                    Id = bus1Id,
                    CompanyName = "Green Line Paribahan",
                    BusName = "Dhaka Express",
                    BusType = BusType.AC,
                    TotalSeats = 40
                },
                new Bus
                {
                    Id = bus2Id,
                    CompanyName = "Shohagh Paribahan",
                    BusName = "Shohagh Luxury",
                    BusType = BusType.NonAC,
                    TotalSeats = 45
                },
                new Bus
                {
                    Id = bus3Id,
                    CompanyName = "Ena Transport",
                    BusName = "Ena Premium",
                    BusType = BusType.NonAC,
                    TotalSeats = 32
                },
                new Bus
                {
                    Id = bus4Id,
                    CompanyName = "Hanif Enterprise",
                    BusName = "Hanif Special",
                    BusType = BusType.AC,
                    TotalSeats = 36
                },
                new Bus
                {
                    Id = bus5Id,
                    CompanyName = "SB",
                    BusName = "SB Deluxe",
                    BusType = BusType.AC,
                    TotalSeats = 40
                },
                new Bus
                {
                    Id = bus6Id,
                    CompanyName = "Royal Coach",
                    BusName = "Royal Premium",
                    BusType = BusType.NonAC,
                    TotalSeats = 42
                }
            };
            modelBuilder.Entity<Bus>().HasData(buses);

            // Generate GUIDs for Routes
            var routeDhakaChittagongId = Guid.NewGuid();
            var routeDhakaSylhetId = Guid.NewGuid();
            var routeDhakaKushtiaId = Guid.NewGuid();
            var routeKushtiaDhakaId = Guid.NewGuid();

            // Seed Routes
            var routes = new[]
            {
                new Route
                {
                    Id = routeKushtiaDhakaId,
                    RouteName = "Kushtia-Dhaka"
                },
                new Route
                {
                    Id = routeDhakaChittagongId,
                    RouteName = "Dhaka-Chittagong"
                },
                new Route
                {
                    Id = routeDhakaSylhetId,
                    RouteName = "Dhaka-Sylhet"
                },
                new Route
                {
                    Id = routeDhakaKushtiaId,
                    RouteName = "Dhaka-Kushtia"
                }
            };
            modelBuilder.Entity<Route>().HasData(routes);

            // Generate GUIDs for Route Stops
            var stopIds = new Dictionary<string, Guid>();
            for (int i = 1; i <= 16; i++)
            {
                stopIds[$"stop{i}"] = Guid.NewGuid();
            }

            // Seed Route Stops
            var routeStops = new[]
            {
                // Kushtia-Dhaka Route
                new RouteStop
                {
                    Id = stopIds["stop13"],
                    RouteId = routeKushtiaDhakaId,
                    StopName = "Kushtia (Mojompur)",
                    StopCode = "kushtia_mojompur",
                    StopOrder = 1,
                    TimeOffset = TimeSpan.Zero
                },
                new RouteStop
                {
                    Id = stopIds["stop14"],
                    RouteId = routeKushtiaDhakaId,
                    StopName = "Kushtia (Mirpur)",
                    StopCode = "kushtia_mirpur",
                    StopOrder = 2,
                    TimeOffset = TimeSpan.FromHours(1.5)
                },
                new RouteStop
                {
                    Id = stopIds["stop15"],
                    RouteId = routeKushtiaDhakaId,
                    StopName = "Pabna (Ishwardi)",
                    StopCode = "pabna_ishwardi",
                    StopOrder = 3,
                    TimeOffset = TimeSpan.FromHours(3)
                },
                new RouteStop
                {
                    Id = stopIds["stop16"],
                    RouteId = routeKushtiaDhakaId,
                    StopName = "Dhaka (Gabtoli)",
                    StopCode = "dhaka_gabtoli",
                    StopOrder = 4,
                    TimeOffset = TimeSpan.FromHours(5)
                },

                // Dhaka-Chittagong Route
                new RouteStop
                {
                    Id = stopIds["stop1"],
                    RouteId = routeDhakaChittagongId,
                    StopName = "Dhaka (Sayedabad)",
                    StopCode = "dhaka_sayedabad",
                    StopOrder = 1,
                    TimeOffset = TimeSpan.Zero
                },
                new RouteStop
                {
                    Id = stopIds["stop2"],
                    RouteId = routeDhakaChittagongId,
                    StopName = "Comilla",
                    StopCode = "comilla",
                    StopOrder = 2,
                    TimeOffset = TimeSpan.FromHours(2.5)
                },
                new RouteStop
                {
                    Id = stopIds["stop3"],
                    RouteId = routeDhakaChittagongId,
                    StopName = "Feni",
                    StopCode = "feni",
                    StopOrder = 3,
                    TimeOffset = TimeSpan.FromHours(4)
                },
                new RouteStop
                {
                    Id = stopIds["stop4"],
                    RouteId = routeDhakaChittagongId,
                    StopName = "Chittagong (GEC)",
                    StopCode = "chittagong_gec",
                    StopOrder = 4,
                    TimeOffset = TimeSpan.FromHours(6)
                },
                
                // Dhaka-Sylhet Route
                new RouteStop
                {
                    Id = stopIds["stop5"],
                    RouteId = routeDhakaSylhetId,
                    StopName = "Dhaka (Mohakhali)",
                    StopCode = "dhaka_mohakhali",
                    StopOrder = 1,
                    TimeOffset = TimeSpan.Zero
                },
                new RouteStop
                {
                    Id = stopIds["stop6"],
                    RouteId = routeDhakaSylhetId,
                    StopName = "Narsingdi",
                    StopCode = "narsingdi",
                    StopOrder = 2,
                    TimeOffset = TimeSpan.FromHours(1.5)
                },
                new RouteStop
                {
                    Id = stopIds["stop7"],
                    RouteId = routeDhakaSylhetId,
                    StopName = "Habiganj",
                    StopCode = "habiganj",
                    StopOrder = 3,
                    TimeOffset = TimeSpan.FromHours(4)
                },
                new RouteStop
                {
                    Id = stopIds["stop8"],
                    RouteId = routeDhakaSylhetId,
                    StopName = "Sylhet (Amberkhana)",
                    StopCode = "sylhet_amberkhana",
                    StopOrder = 4,
                    TimeOffset = TimeSpan.FromHours(6)
                },

                // Dhaka-Kushtia Route
                new RouteStop
                {
                    Id = stopIds["stop9"],
                    RouteId = routeDhakaKushtiaId,
                    StopName = "Dhaka (Gabtoli)",
                    StopCode = "dhaka_gabtoli",
                    StopOrder = 1,
                    TimeOffset = TimeSpan.Zero
                },
                new RouteStop
                {
                    Id = stopIds["stop10"],
                    RouteId = routeDhakaKushtiaId,
                    StopName = "Dhaka (Savar)",
                    StopCode = "dhaka_savar",
                    StopOrder = 2,
                    TimeOffset = TimeSpan.FromHours(2)
                },
                new RouteStop
                {
                    Id = stopIds["stop11"],
                    RouteId = routeDhakaKushtiaId,
                    StopName = "Gazipur (Chandra)",
                    StopCode = "gazipur_chandra",
                    StopOrder = 3,
                    TimeOffset = TimeSpan.FromHours(3.5)
                },
                new RouteStop
                {
                    Id = stopIds["stop12"],
                    RouteId = routeDhakaKushtiaId,
                    StopName = "Kushtia (Mojompur)",
                    StopCode = "kushtia_mojompur",
                    StopOrder = 4,
                    TimeOffset = TimeSpan.FromHours(5)
                }
            };
            modelBuilder.Entity<RouteStop>().HasData(routeStops);

            // Generate Bus Schedules for 10 days
            var schedules = GenerateBusSchedulesFor10Days(
                bus1Id, bus2Id, bus3Id, bus4Id, bus5Id, bus6Id,
                routeDhakaChittagongId, routeDhakaSylhetId,
                routeDhakaKushtiaId, routeKushtiaDhakaId
            );
            modelBuilder.Entity<BusSchedule>().HasData(schedules);

            // Seed Seats for all buses
            var allSeats = new List<Seat>();
            allSeats.AddRange(GenerateSeats(bus1Id, 40));
            allSeats.AddRange(GenerateSeats(bus2Id, 45));
            allSeats.AddRange(GenerateSeats(bus3Id, 32));
            allSeats.AddRange(GenerateSeats(bus4Id, 36));
            allSeats.AddRange(GenerateSeats(bus5Id, 40));
            allSeats.AddRange(GenerateSeats(bus6Id, 42));
            modelBuilder.Entity<Seat>().HasData(allSeats);
        }

        private static List<BusSchedule> GenerateBusSchedulesFor10Days(
            Guid bus1Id, Guid bus2Id, Guid bus3Id, Guid bus4Id, Guid bus5Id, Guid bus6Id,
            Guid routeDhakaChittagongId, Guid routeDhakaSylhetId,
            Guid routeDhakaKushtiaId, Guid routeKushtiaDhakaId)
        {
            var schedules = new List<BusSchedule>();
            var today = DateTime.Today;

            var scheduleConfigs = new[]
            {
                // Dhaka-Chittagong
                (bus1Id, routeDhakaChittagongId, TimeSpan.FromHours(8), TimeSpan.FromHours(14), 800),
                (bus1Id, routeDhakaChittagongId, TimeSpan.FromHours(22), TimeSpan.FromHours(28), 800),
                (bus2Id, routeDhakaChittagongId, TimeSpan.FromHours(9), TimeSpan.FromHours(15), 650),
                (bus2Id, routeDhakaChittagongId, TimeSpan.FromHours(23), TimeSpan.FromHours(29), 650),
                
                // Dhaka-Sylhet
                (bus3Id, routeDhakaSylhetId, TimeSpan.FromHours(7), TimeSpan.FromHours(13), 900),
                (bus3Id, routeDhakaSylhetId, TimeSpan.FromHours(21), TimeSpan.FromHours(27), 900),
                (bus4Id, routeDhakaSylhetId, TimeSpan.FromHours(10), TimeSpan.FromHours(16), 850),
                
                // Dhaka-Kushtia
                (bus5Id, routeDhakaKushtiaId, TimeSpan.FromHours(6), TimeSpan.FromHours(11), 500),
                (bus5Id, routeDhakaKushtiaId, TimeSpan.FromHours(14), TimeSpan.FromHours(19), 500),
                (bus6Id, routeDhakaKushtiaId, TimeSpan.FromHours(8), TimeSpan.FromHours(13), 450),
                (bus6Id, routeDhakaKushtiaId, TimeSpan.FromHours(20), TimeSpan.FromHours(25), 450),
                
                // Kushtia-Dhaka
                (bus5Id, routeKushtiaDhakaId, TimeSpan.FromHours(7), TimeSpan.FromHours(12), 500),
                (bus5Id, routeKushtiaDhakaId, TimeSpan.FromHours(15), TimeSpan.FromHours(20), 500),
                (bus6Id, routeKushtiaDhakaId, TimeSpan.FromHours(9), TimeSpan.FromHours(14), 450),
                (bus6Id, routeKushtiaDhakaId, TimeSpan.FromHours(22), TimeSpan.FromHours(27), 450)
            };

            // Generate schedules for 10 days
            for (int day = 0; day < 10; day++)
            {
                var journeyDate = today.AddDays(day);

                foreach (var config in scheduleConfigs)
                {
                    schedules.Add(new BusSchedule
                    {
                        Id = Guid.NewGuid(),
                        BusId = config.Item1,
                        RouteId = config.Item2,
                        JourneyDate = journeyDate,
                        DepartureTime = config.Item3,
                        ArrivalTime = config.Item4,
                        Price = config.Item5
                    });
                }
            }

            return schedules;
        }

        private static List<Seat> GenerateSeats(Guid busId, int totalSeats)
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
