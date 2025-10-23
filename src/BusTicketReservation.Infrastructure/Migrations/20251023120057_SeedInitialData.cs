using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusTicketReservation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "BusName", "BusType", "CompanyName", "TotalSeats" },
                values: new object[,]
                {
                    { new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), "Kushtia Deluxe", 1, "Kushtia Express", 40 },
                    { new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), "Shohagh Luxury", 2, "Shohagh Paribahan", 45 },
                    { new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), "Dhaka Express", 1, "Green Line Paribahan", 40 },
                    { new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), "Royal Premium", 2, "Royal Coach", 42 },
                    { new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), "Ena Premium", 2, "Ena Transport", 32 },
                    { new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), "Hanif Special", 1, "Hanif Enterprise", 36 }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "RouteName" },
                values: new object[,]
                {
                    { new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead"), "Dhaka-Kushtia" },
                    { new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9"), "Kushtia-Dhaka" },
                    { new Guid("454f8995-5266-4dd8-a285-f85c75f038ed"), "Dhaka-Chittagong" },
                    { new Guid("46485165-99a4-4b81-b370-9de4c08898a5"), "Dhaka-Sylhet" }
                });

            migrationBuilder.InsertData(
                table: "BusSchedules",
                columns: new[] { "Id", "ArrivalTime", "BusId", "DepartureTime", "JourneyDate", "Price", "RouteId" },
                values: new object[,]
                {
                    { new Guid("007059c8-0ce1-46f8-9083-8b21279cc9ea"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("06ddcf62-8106-4be9-9613-09795cbf938c"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("0779b05b-a9cf-4655-8e06-d02cdbddd7c5"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("0b309cf1-6ce4-4ffd-b2c1-08e898a8aad1"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("0bb7ac0c-a820-488c-b5b9-0664a3a03c81"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("1000e3c7-74ad-4ed6-809b-12a94c1bb3a8"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("112969ac-4429-4dca-b3fb-5cab0546cc6e"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("15d9b750-336a-4d76-b246-20d50d55d742"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("17358322-661c-4dc0-b8dd-3fc7c290227a"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("1a7def9d-287e-409e-ac9f-7cd423ed95ec"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("1a8a6472-ff5b-4a54-83e7-33e64c6b9d72"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("1c031fbd-34b3-424d-8595-0a6b4a60d96e"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("1ca705cb-897e-48fa-a7e6-761a3c5ceed1"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("1d583354-1397-4f4c-b48e-97268e6306c8"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("1d71ff8a-a5c1-4ccb-a4c2-04e99bef7243"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("1e34d647-1c87-4a14-a5ff-8b2679b283fc"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("20bc23f2-66ee-4fac-9b59-ee010f01a36c"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("20f07257-9555-49b0-98bf-e9e67b6f548b"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("218e31ef-2858-41db-b042-9480e8a7e6ca"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("242656ae-8429-4005-8049-8933c0832db3"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("25b16fa8-0917-40eb-a238-99faa016f1ad"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("2638159b-30db-49c3-adcd-4dfe07651a31"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("26586622-6f69-41b0-bf53-d2b7f33ecb9e"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("27610c64-73bd-462c-88eb-6abba58e387c"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("2a0651df-9c6b-4ee1-8ecd-fdb380b3bbbb"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("2ac43d1f-a847-48b5-a260-3f980b8fb8c9"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("2bf4708a-c23b-4f9c-ac46-67a480375dd1"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("2d226b27-af1a-4640-87af-0ab180bbf544"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("2e5d7449-5232-4d2c-9aad-d65c07702e79"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("2fc257a3-8315-4a6e-9c4b-8d5eb415b334"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("33602a47-3780-433e-b158-669747b39032"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("378ace0a-d0c8-4a9f-af57-3b3ef4cd7b19"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("37e66bfe-9331-4273-80db-9318ed16d905"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("3a7ef1c5-43c1-4a91-ace9-afa3cb6f3505"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("3e213dc2-152f-40c6-80c5-65f1680b74ff"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("3e21a80c-461d-4abe-abbc-4544837a9385"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("416c78e8-e793-4946-b707-e3ba15ac0fd1"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("45b50058-b1ac-4cb2-8357-f3f67fabfbf3"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("46b66d72-6c43-4cfd-a9b0-be887e8bc723"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("497ad4b9-a789-4dcc-bbb6-fb349ff4041b"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("499a18c5-e92a-4f02-865e-d9c21170489f"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("5065b1ce-37b2-4e25-baff-9f75200aa208"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("5108c6d6-bf76-44d7-b182-7747834d411d"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("517c2983-1a3b-4ac7-9728-400d06693820"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("53851591-c037-4c6e-843e-28093b4e86ca"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("54da2b14-0ac2-4f18-89c3-58470d868925"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("551020e1-f82f-42d0-b9d0-e89d68e9c05b"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("55ae47a9-3d06-43b1-a9db-de967b955c4e"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("586acad3-e1fe-42cf-9231-27aef0997a71"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("60596c9c-1bd5-4778-b74b-70d8c6d4dd05"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("60e4ae26-bd37-4b5c-89a5-712161f70560"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("60f6e0aa-07fb-4118-9522-79616e5872da"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("61474356-fc08-4b9f-8e21-c6e13c387cfd"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("61a7b747-92d6-44ee-bc8a-812f245523ae"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("6546c233-530e-4c6f-a012-835d746b0c76"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("661871b7-dc37-423f-90d4-4af890a32748"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("673e5ae0-2ff8-4744-9f29-0135d5152b59"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("6749c398-c6dd-407f-bb11-1d5b0a5baa8a"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("67b2b0a2-e149-434a-813a-8999be0c7d0e"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("67b7f99d-fe03-4d1d-833d-56d1efd09feb"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("68bae80f-5e24-461d-814f-6cdc053b0b40"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("6a1a6ce4-5d57-4b87-a638-d3920abebf46"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("6a433652-81e1-4432-877d-25d380d43f5c"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("6aa4334e-bbca-4406-97d5-d1618ef4c341"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("6ab7b788-c691-4ed8-bea6-4a860ca3b7a3"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("6cde0181-e172-475f-a68f-e8dadc182804"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("6eac906c-6e91-48ac-950b-3d3906b8aa06"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("6fa50e9e-cbf2-41c3-923f-be5164488b62"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("7a20b700-536f-4e64-af59-e07e5875bcaa"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("7c1c4f85-57e7-4406-8912-2b2b0e0c3b2f"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("7ee4288c-c789-444b-96a0-c5fd4ebce92c"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("80f9ca36-ff5b-41fc-82d6-ec3c2e33a579"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("816ef938-022b-4362-8412-9e88ba227268"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("817c55d2-d067-46ae-a21e-b2af96596c2f"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("81f12af2-8f1c-4eb9-a604-87ed5c3db828"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("822fbbf4-f6aa-465b-8acd-081627e6a806"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("83fa9bcc-054a-4c11-8012-9df993fb5f27"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("843403b8-1562-4b6f-8cfc-6f1a2210edf4"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("844c3b8e-cec6-4265-8ff7-72d0b840519f"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("84db35c1-fdaa-408d-9fef-de8f84403cb7"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("85e19913-8108-4297-bce8-56156e44ad14"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("89bf590d-fa3b-4c70-a11a-2df744a488bc"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("8a51ef28-cbaf-440b-a63d-0918357969b7"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("8c71cd28-e81e-447c-b6cc-7fc6610955ff"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("926b0673-0070-4f8e-bf5a-e1e0cc488f9d"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("9e9528d3-c87f-499b-801a-3bb9e7cf6545"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("9eaa013e-c813-47fa-917b-77a914f4cb04"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("9eea2918-2b1d-4728-bf56-2ccd0e3042ed"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("a0db3c09-d76c-4af2-abcb-e02356fcc0d4"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("a1bacaeb-fd45-4d40-bece-93b7991e369f"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("a1fdf893-a5b4-45bc-9fa5-8be3af05fd37"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("a2224978-9555-4f46-b021-3fdbe85c8175"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("a5883f1d-fe8e-4769-a6e1-40349cd58cb9"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("a63237de-91b5-4db0-9668-96ffe24122b4"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("a65f90fd-3521-4d2e-bc82-e8c8594aeb03"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("a7a06fd9-899d-467f-a656-1f5846ad201b"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("a7dc17fa-eaac-4526-9764-2b4ac6ee11ac"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("aaaebe68-fe66-455e-89a4-caf5dba5c856"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("ab488c38-51a0-47b6-a6d1-949394e3d898"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("abf95f04-8949-4351-a31c-fa2435c6ef00"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("ac526502-9f8b-44a3-800c-b13d8e3667f0"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("acc63e6e-f11b-45c7-9b0c-6944664f2ecf"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("af1ac032-9bce-4957-abf7-90e61e5ec1ae"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("afbc42ec-9358-4ea0-ae94-da38f17a8c8d"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("b21e3807-5d59-439e-b6ad-1c073883d369"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("b4f2cba9-f4e4-4516-8dc2-2a2e2a1642a4"), new TimeSpan(0, 12, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("b5b8bf24-5592-4535-bf6c-0e0a72782e9b"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("b621a326-1aa5-43ac-9400-e705b1283e3d"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("b643c56a-ec2c-4072-965d-8a0c09b49651"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("b717c538-bb8c-49f1-ab34-8efcd9dec2a0"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("b7fe72ba-ec01-4372-8fb1-c281b08ded64"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("b88b3ff1-7d34-40cf-a9b2-6f488ad70c9d"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("bb2e881e-c343-4fd9-88d8-b077a72346ae"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("bb5509b8-dfbe-4ab8-ba10-ab6dec265d6c"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("bbebee65-abab-42b0-9892-667d6af50047"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("bc4263f4-619a-4cf0-9c72-b9ae67f15606"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("bea9c8f8-7cba-40d9-8059-3e966e48a683"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("c062c41d-4d0b-4d40-a1da-e8ed15f0a61d"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("c06d2f61-f1b4-476e-858c-efaedf758ede"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("c5adb818-9fde-4fd6-a56b-ca9edef1ba4a"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("c64cf6b2-a3fd-414f-b276-71445b98680f"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("c673db0a-74ac-480b-8905-b38980f8e28b"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("c7238495-517b-473b-896d-e9d7d58e6e57"), new TimeSpan(1, 5, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("c77eb3e2-3168-42e4-bd95-a41538cf1024"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("c7ce8152-6275-413f-a6e6-07fc094d253a"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("c91c644e-1d4a-43f6-a743-54c76d123abf"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("cd0cb5c7-8846-4235-a6f4-2c88cad5ee89"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("d488b06f-9c75-4379-9947-02f235ed7ff6"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("d84445ff-8dd4-40ba-932a-228bc01723b5"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("d98a6599-03e4-4421-b9cb-ed32ef18660a"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("d9b5a094-6cfa-48d3-961f-c69f0bdb6cfe"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("dc8c7ad6-ecb0-44a4-ab14-acdd45039308"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("ddee37db-cad2-4b7a-807a-79b21d6eb443"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("de50ba9c-b58f-4d81-927c-38c2eb314cc9"), new TimeSpan(0, 16, 0, 0, 0), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("deb2b630-48a6-4591-8516-eeb58462c4b7"), new TimeSpan(1, 1, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("e6570320-4079-4941-ba7c-8dd8842dc7ab"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("e80783ad-740d-4da1-a31c-8bef1742bdca"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("e8a9e5b5-77bc-4e62-a393-3e768d275ab0"), new TimeSpan(0, 11, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("e8df27dc-a7ac-481b-b55e-86a357eefe89"), new TimeSpan(0, 14, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("ebc6b64d-8c55-4e1a-9d4e-9aecbe72bdbe"), new TimeSpan(0, 20, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("ec4469d0-21f6-4484-a284-14f674c5f79c"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("edd7f91e-bc99-414d-9a2f-03383145939c"), new TimeSpan(1, 3, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("f3dd1114-e664-47f2-aad1-6a095b5e966b"), new TimeSpan(0, 15, 0, 0, 0), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("f42c6295-43ca-4292-8722-913bf05c6ffb"), new TimeSpan(0, 14, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("f475cf15-acef-4100-a323-23a30604e181"), new TimeSpan(0, 19, 0, 0, 0), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("f94f9361-884e-409d-9c87-c088939e4d7f"), new TimeSpan(0, 13, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 23, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead") },
                    { new Guid("f9f9ba45-bafb-4a57-8f40-e5eb3bf6251e"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") },
                    { new Guid("fb13675b-c677-4497-8c17-035d2feda29b"), new TimeSpan(1, 3, 0, 0, 0), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9") },
                    { new Guid("fe6f0e7a-195e-4186-bb31-d012a97adacc"), new TimeSpan(1, 4, 0, 0, 0), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("454f8995-5266-4dd8-a285-f85c75f038ed") },
                    { new Guid("fec2ba42-297f-48ad-b77a-13bd16b244a4"), new TimeSpan(0, 13, 0, 0, 0), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("46485165-99a4-4b81-b370-9de4c08898a5") }
                });

            migrationBuilder.InsertData(
                table: "RouteStops",
                columns: new[] { "Id", "RouteId", "StopCode", "StopName", "StopOrder", "TimeOffset" },
                values: new object[,]
                {
                    { new Guid("44726618-38d2-4e82-80a1-e9e1559da53c"), new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead"), "dhaka_gabtoli", "Dhaka (Gabtoli)", 1, new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("45068e7e-e245-4609-a07f-9d8befe0647e"), new Guid("46485165-99a4-4b81-b370-9de4c08898a5"), "narsingdi", "Narsingdi", 2, new TimeSpan(0, 1, 30, 0, 0) },
                    { new Guid("4e5aa261-8d78-4526-95bf-c3b9d043e77c"), new Guid("46485165-99a4-4b81-b370-9de4c08898a5"), "dhaka_mohakhali", "Dhaka (Mohakhali)", 1, new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("696e8ae8-afbe-4b2c-841e-a7fcd98a7db5"), new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead"), "kushtia_mojompur", "Kushtia (Mojompur)", 4, new TimeSpan(0, 5, 0, 0, 0) },
                    { new Guid("6df473cb-51e4-45ad-b259-224351402ad4"), new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9"), "kushtia_mirpur", "Kushtia (Mirpur)", 2, new TimeSpan(0, 1, 30, 0, 0) },
                    { new Guid("70f979b5-4738-4f48-bfd2-61ca2ed80fc6"), new Guid("454f8995-5266-4dd8-a285-f85c75f038ed"), "comilla", "Comilla", 2, new TimeSpan(0, 2, 30, 0, 0) },
                    { new Guid("8fb8d708-d508-421c-8117-88747c4caf71"), new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9"), "pabna_ishwardi", "Pabna (Ishwardi)", 3, new TimeSpan(0, 3, 0, 0, 0) },
                    { new Guid("9b621b1f-ba13-47f4-b73c-261c59bc95fa"), new Guid("454f8995-5266-4dd8-a285-f85c75f038ed"), "chittagong_gec", "Chittagong (GEC)", 4, new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("b6a4994e-f9b1-4cdd-a2ed-f676938e1b67"), new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead"), "dhaka_savar", "Dhaka (Savar)", 2, new TimeSpan(0, 2, 0, 0, 0) },
                    { new Guid("b6e29505-fdd8-478e-b50f-d9383b0c2adb"), new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead"), "gazipur_chandra", "Gazipur (Chandra)", 3, new TimeSpan(0, 3, 30, 0, 0) },
                    { new Guid("bc49a107-70a8-4493-8851-9eed204668af"), new Guid("46485165-99a4-4b81-b370-9de4c08898a5"), "habiganj", "Habiganj", 3, new TimeSpan(0, 4, 0, 0, 0) },
                    { new Guid("cf9eef4d-c4db-45e8-b21b-035a8f52c8c0"), new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9"), "dhaka_gabtoli", "Dhaka (Gabtoli)", 4, new TimeSpan(0, 5, 0, 0, 0) },
                    { new Guid("e26a6854-a89e-4222-bd95-e3b7bd9bed1c"), new Guid("46485165-99a4-4b81-b370-9de4c08898a5"), "sylhet_amberkhana", "Sylhet (Amberkhana)", 4, new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("e2a0a7e1-6de6-46b7-a67d-33c3295bdd61"), new Guid("454f8995-5266-4dd8-a285-f85c75f038ed"), "dhaka_sayedabad", "Dhaka (Sayedabad)", 1, new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("e8ef2011-3987-475b-a4a9-f7f11e4b6fe8"), new Guid("454f8995-5266-4dd8-a285-f85c75f038ed"), "feni", "Feni", 3, new TimeSpan(0, 4, 0, 0, 0) },
                    { new Guid("fb8af5eb-4cfc-4ff9-9fb6-137451b92dfc"), new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9"), "kushtia_mojompur", "Kushtia (Mojompur)", 1, new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "BusId", "RowNumber", "SeatNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("00080eb8-9ee3-45f8-9e03-da387ff3fefe"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 5, "E1", 0 },
                    { new Guid("002fd2b4-2339-40ec-b9c9-75df84e23203"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 6, "F3", 0 },
                    { new Guid("00eedbb2-a86f-4585-ada8-a9c162cbd413"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 6, "F1", 0 },
                    { new Guid("017a6bf5-e8ed-4e65-8ca3-641642ee22c1"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 8, "H4", 0 },
                    { new Guid("07894d82-3d3e-4ee7-9982-4239a0ea81f2"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 6, "F3", 0 },
                    { new Guid("0a036ef7-6085-4c42-8248-b01e05f2f9f3"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 3, "C2", 0 },
                    { new Guid("0b7c1ee4-aed9-4a06-a781-7b261beed410"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 1, "A3", 0 },
                    { new Guid("0c5ea79a-d5d2-437d-8d56-e2a54c1763c0"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 8, "H3", 0 },
                    { new Guid("0d56cdb8-bb0d-465e-8f43-c38ca6661061"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 8, "H4", 0 },
                    { new Guid("0de3d7b7-6fa8-4d0e-8463-0b174d56e086"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 2, "B4", 0 },
                    { new Guid("0df88b98-a872-493c-b944-fdc3f0dc4193"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 4, "D1", 0 },
                    { new Guid("0fe5cbc2-1e28-4226-b4ba-c6703719557e"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 2, "B3", 0 },
                    { new Guid("10cff327-aeaa-4eb9-8de2-f08e76391204"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 1, "A1", 0 },
                    { new Guid("12155b73-3833-4e14-838c-29e2ff985bb7"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 3, "C1", 0 },
                    { new Guid("1386c42c-2012-4dea-a9b4-61437044a0a5"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 5, "E3", 0 },
                    { new Guid("13bed441-c398-4ef4-abda-c5ee48f9167a"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 6, "F1", 0 },
                    { new Guid("15103f97-60ac-4644-bcdc-692df9dc23e2"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 8, "H2", 0 },
                    { new Guid("17643e63-0d6f-421b-ba1d-cc27fdebee7a"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 6, "F1", 0 },
                    { new Guid("1b700d89-b0c9-4de2-b478-98fc0135ae87"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 6, "F1", 0 },
                    { new Guid("1becb987-7828-4064-b37d-556de496ca27"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 8, "H4", 0 },
                    { new Guid("1e37b201-30ac-4728-9948-d63ea954b728"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 9, "I2", 0 },
                    { new Guid("1e5d49cc-c059-4070-a78a-3914dd95920e"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 6, "F4", 0 },
                    { new Guid("1f356b67-35b3-41e2-af12-2ff85a950fc8"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 7, "G1", 0 },
                    { new Guid("20ae083d-2f88-4256-9895-bb5993c53dad"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 9, "I4", 0 },
                    { new Guid("21a37f38-4dc1-4880-b393-5fac93b86ff6"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 1, "A2", 0 },
                    { new Guid("2295e6f5-a98e-4273-a68b-d3e34c57c3a9"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 7, "G1", 0 },
                    { new Guid("2400e22e-c74d-4c8f-9438-53015ee6490b"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 6, "F1", 0 },
                    { new Guid("246ed318-e6ba-4614-bf90-6108563beb0c"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 5, "E2", 0 },
                    { new Guid("24f6b947-8948-44cb-b4a5-f1266504ab5a"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 8, "H1", 0 },
                    { new Guid("260d4c68-b0f4-4091-9e19-2e4528b5473e"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 8, "H4", 0 },
                    { new Guid("2a7ea8c8-b366-40cb-8376-a71c8aaeb535"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 7, "G4", 0 },
                    { new Guid("2a823824-d998-418f-bec7-1bafa2ba724e"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 1, "A4", 0 },
                    { new Guid("2c37df0f-9417-47be-8f3f-b223e44a3311"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 5, "E2", 0 },
                    { new Guid("2cbbdba0-5f03-4c70-9136-2b24cbb44524"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 2, "B4", 0 },
                    { new Guid("2cc5ddfe-af38-4502-8ed2-3a84f59031e0"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 7, "G3", 0 },
                    { new Guid("2e6fd722-0c1b-4be7-9f78-0f531739474a"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 2, "B2", 0 },
                    { new Guid("30328496-b2bd-4b14-b5f7-f9cc0c0153ab"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 7, "G4", 0 },
                    { new Guid("32bf7372-4d9b-416e-8473-adeeeb0dc54a"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 5, "E2", 0 },
                    { new Guid("3380f84f-2914-4a52-ae94-35897d10840c"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 2, "B4", 0 },
                    { new Guid("35888cdb-2c6a-4083-b5d5-cc923eaa48a3"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 5, "E3", 0 },
                    { new Guid("391fff5c-41da-43c2-8f58-35e793582762"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 1, "A3", 0 },
                    { new Guid("393551d4-c9df-48b9-9c6e-e33476059c37"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 7, "G4", 0 },
                    { new Guid("39d692f1-a1c9-430b-9500-85a384a15f56"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 3, "C1", 0 },
                    { new Guid("3a8326f2-085f-48ea-88f8-8714c71f4db2"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 3, "C3", 0 },
                    { new Guid("3c1ed382-f834-44a8-9900-f70ec1018af3"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 7, "G1", 0 },
                    { new Guid("3ddbb2cf-ef74-4e3a-b711-032ecbba6847"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 1, "A4", 0 },
                    { new Guid("3fa01597-a8f9-4207-a347-39694bcf9c01"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 3, "C4", 0 },
                    { new Guid("40578813-1399-44db-a019-04a513bbb81c"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 7, "G3", 0 },
                    { new Guid("4394cf7d-6e88-45da-845c-0dbdc06745fb"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 4, "D4", 0 },
                    { new Guid("443f9dc7-30c4-4f42-907d-85fb29ec8a6b"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 9, "I2", 0 },
                    { new Guid("44a80887-60e8-46d4-a76d-1d1b979837e8"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 3, "C3", 0 },
                    { new Guid("45be5ca5-cf9c-4fbb-853d-d11d8eab03e5"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 2, "B4", 0 },
                    { new Guid("47c4ea5c-5b8f-488a-9c47-57c8726c65e2"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 5, "E4", 0 },
                    { new Guid("4a4a0591-7910-4095-98c4-ad20599896e0"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 9, "I1", 0 },
                    { new Guid("4aaefc76-11d0-4bff-96be-0f6f87fbb5d2"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 11, "K2", 0 },
                    { new Guid("4adfcd26-dfd7-4aac-9fcf-781c3f38e6a4"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 2, "B1", 0 },
                    { new Guid("4ba9ad6d-a52f-454c-aeed-e78c4b5b54bb"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 3, "C1", 0 },
                    { new Guid("4d8aa1cb-2adc-4a07-8ca8-694e599f52bb"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 6, "F4", 0 },
                    { new Guid("4ea30a7d-9248-4a50-95f2-47dce2b1555f"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 6, "F3", 0 },
                    { new Guid("4eb6c357-37e3-477b-bbbb-da19ac8ba092"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 3, "C3", 0 },
                    { new Guid("4feff0ac-5228-43e1-a3dd-d1f7975d6293"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 1, "A3", 0 },
                    { new Guid("505063de-9984-4612-9174-4e09b7c570a4"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 4, "D1", 0 },
                    { new Guid("5505be7b-c878-4a89-8abd-50b0a5fda7e5"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 2, "B4", 0 },
                    { new Guid("5572f69a-4e14-4e83-86f1-70ca03b0726f"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 4, "D2", 0 },
                    { new Guid("584a9b05-7747-4dbe-b1f8-84b6cf95c678"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 7, "G1", 0 },
                    { new Guid("584ba665-eaca-42d9-af41-d57f7ad5964a"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 5, "E1", 0 },
                    { new Guid("589cc710-87b6-417f-8304-bf2e3b5c2ea0"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 7, "G3", 0 },
                    { new Guid("5974feb3-0adb-4b85-9b27-a7724162a32a"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 10, "J3", 0 },
                    { new Guid("5c665694-4f53-493b-8bb1-d10bbd75c8d6"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 3, "C1", 0 },
                    { new Guid("5e9651d7-28dc-4b8a-bbde-dfe49a102031"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 4, "D3", 0 },
                    { new Guid("5ed596ec-5976-4e44-a98b-88a0091c55fa"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 11, "K4", 0 },
                    { new Guid("5f448331-3149-48aa-8d66-51dc07185f63"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 7, "G3", 0 },
                    { new Guid("5fe0eb18-393a-4f5e-8559-7ded904fad4d"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 4, "D1", 0 },
                    { new Guid("607ba899-57b3-4974-900b-cfc4ac1eb30d"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 6, "F2", 0 },
                    { new Guid("629f1688-4b9e-4648-92da-8ba8a66808bb"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 6, "F3", 0 },
                    { new Guid("63373568-25b3-47cb-b11b-d592ddf57c03"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 1, "A3", 0 },
                    { new Guid("65043d46-7228-4183-8996-0059bd43d33e"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 5, "E2", 0 },
                    { new Guid("675620c8-7cd2-4fd9-9c9a-b1f211bd9645"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 8, "H1", 0 },
                    { new Guid("678bef63-e5b7-42f2-9733-b683a48dc1ae"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 1, "A2", 0 },
                    { new Guid("67f0231c-37cf-4fe8-84d8-ba27509209b2"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 7, "G3", 0 },
                    { new Guid("688ff2e5-9445-4707-b7c8-fe53c132fcf8"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 2, "B2", 0 },
                    { new Guid("691ae9f2-928e-4dfc-8ee4-8a4609ece4c2"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 1, "A4", 0 },
                    { new Guid("6aace38b-7988-4f89-855e-c90996f5bce0"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 7, "G2", 0 },
                    { new Guid("6b699a25-75a6-4c2d-8362-bfebf633e1d6"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 6, "F4", 0 },
                    { new Guid("6b6f5295-00e3-4a72-a1a9-0475f7d46e2d"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 4, "D3", 0 },
                    { new Guid("6c915752-f861-4970-8b3f-7e236bc0e1bc"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 2, "B3", 0 },
                    { new Guid("6c961329-2933-4d79-a48c-47013e548e36"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 8, "H3", 0 },
                    { new Guid("6d1fe1a4-2f15-4da2-93ca-42b2f17d156b"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 9, "I4", 0 },
                    { new Guid("6eecb2e5-9a9f-4d56-884d-491ad81173b4"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 10, "J4", 0 },
                    { new Guid("6f48c96a-b34a-4e34-aa7e-66ed47b348cc"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 2, "B4", 0 },
                    { new Guid("6fdbf5d9-be46-4a5a-a09b-16557cd6eb5e"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 3, "C3", 0 },
                    { new Guid("7171b021-79fd-44b4-9ad2-9c480d29c5fb"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 1, "A1", 0 },
                    { new Guid("72092ce6-49f3-4122-973f-fd7ede9a70b2"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 6, "F2", 0 },
                    { new Guid("72aabc57-db5f-4f4a-b1e0-6ff0686fe21f"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 8, "H2", 0 },
                    { new Guid("778a954c-6ca5-49a2-8461-9eab2dc436d2"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 11, "K3", 0 },
                    { new Guid("78b50911-bb40-4890-a206-e2c77a186c5a"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 9, "I1", 0 },
                    { new Guid("795c27d6-660e-4326-890a-645889c0d59f"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 7, "G2", 0 },
                    { new Guid("7a693e52-bbcd-412e-a190-31dd4bb64a40"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 7, "G4", 0 },
                    { new Guid("7c84df1c-df7c-4895-8239-46833b29be23"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 6, "F3", 0 },
                    { new Guid("7c87a265-12f7-4982-a3b9-9a4e829c2c81"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 8, "H2", 0 },
                    { new Guid("7ca8ca4a-817e-40c9-ba41-acf57b337f4d"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 1, "A2", 0 },
                    { new Guid("7cee77ad-3602-44c0-9dbc-74f40e67189b"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 4, "D4", 0 },
                    { new Guid("7d531b5e-29ca-48d2-9bb2-2ef12618f533"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 4, "D1", 0 },
                    { new Guid("80e18ade-880c-4f79-9413-12acf514faf9"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 3, "C4", 0 },
                    { new Guid("8170c3bf-61d4-4c49-8784-37cbd20b5406"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 1, "A2", 0 },
                    { new Guid("8294bcb8-0a7b-4828-9b01-bded5b5a46ab"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 8, "H3", 0 },
                    { new Guid("83731584-ce43-4164-897e-7f05ac8511f1"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 3, "C4", 0 },
                    { new Guid("8404c9d0-ea5b-480e-89de-6c0620c85f92"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 4, "D2", 0 },
                    { new Guid("86ce50b2-26ed-4c68-b29b-f5592c1c7951"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 9, "I1", 0 },
                    { new Guid("879bf139-ed1f-4194-b8c7-eb4660a78b19"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 3, "C2", 0 },
                    { new Guid("8815c3f0-8954-41c3-8f3f-a8c9c133de75"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 1, "A4", 0 },
                    { new Guid("88c94c80-6de0-4c30-b3a6-702be547deaa"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 5, "E3", 0 },
                    { new Guid("894d7f64-830a-4b91-95a0-6c1159882491"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 3, "C1", 0 },
                    { new Guid("8a776a03-7534-47f1-be7f-686c843b72bb"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 8, "H1", 0 },
                    { new Guid("8b81b454-6f41-4b47-baf6-4535c581b008"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 2, "B1", 0 },
                    { new Guid("8b8c3fb0-fd41-4892-ad42-bf2a96411b99"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 6, "F2", 0 },
                    { new Guid("8c0ba964-8fbb-42dc-8a44-5c29d99aa376"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 10, "J2", 0 },
                    { new Guid("8e2da394-58bd-4475-b951-4822f73fc4dd"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 7, "G1", 0 },
                    { new Guid("8eb5a136-fd85-4281-b29d-fa35e0b9b776"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 7, "G4", 0 },
                    { new Guid("8f41a87b-f9d8-41e8-85d8-3e6ed08e55f1"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 3, "C4", 0 },
                    { new Guid("8f87578a-51ba-4f89-a690-9937076b85a4"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 2, "B3", 0 },
                    { new Guid("905cb8ea-94cd-486d-ab42-eed32f97c8cf"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 7, "G2", 0 },
                    { new Guid("9496cb02-1003-47fb-8868-857fd244b279"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 9, "I3", 0 },
                    { new Guid("9c2bdba8-51bb-4421-98b2-3c675ae04f94"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 9, "I2", 0 },
                    { new Guid("9dc516d3-25cd-4b17-806e-561dfb984b9f"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 8, "H1", 0 },
                    { new Guid("9eabc6d9-d54e-4c19-b44a-298dcffdd912"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 8, "H1", 0 },
                    { new Guid("9f408075-dd66-4e68-9ce2-4b26f36704f7"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 9, "I4", 0 },
                    { new Guid("a28a5118-196e-4771-b9da-75e58bebcd65"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 10, "J1", 0 },
                    { new Guid("a2980261-51eb-4570-a188-443cdcf4fae7"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 5, "E4", 0 },
                    { new Guid("a499c524-35f9-4e38-9bb6-3ac83f15e0c1"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 4, "D2", 0 },
                    { new Guid("a5a7ce2d-291c-4b5a-a341-12a805bd1cac"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 5, "E1", 0 },
                    { new Guid("a5edd9a6-e244-4eb6-896a-5b2cdb1751d1"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 6, "F4", 0 },
                    { new Guid("a6609795-9ef1-4309-b1ff-8d0bc2961fce"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 7, "G2", 0 },
                    { new Guid("a694506a-c555-402b-a61c-2ea7c7fe48a3"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 8, "H3", 0 },
                    { new Guid("a6a734d7-5ddb-4ddf-b8d0-f41c5d59c964"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 4, "D3", 0 },
                    { new Guid("a7565d92-38f0-4922-8250-5ca54b0a91d5"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 7, "G4", 0 },
                    { new Guid("a7d9ec78-0657-4598-aba7-ab20af96e313"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 8, "H2", 0 },
                    { new Guid("a82420bf-7df5-4810-93b7-f00f30ac6564"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 9, "I3", 0 },
                    { new Guid("a97bc579-d268-487c-924b-509946060900"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 4, "D4", 0 },
                    { new Guid("a9d25262-0f2a-49d7-8346-70710b58cd9d"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 2, "B3", 0 },
                    { new Guid("abb7441f-1b81-4844-874e-0135f5eafce6"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 1, "A1", 0 },
                    { new Guid("ac9beb43-c3f8-484c-b1fa-301981421dcd"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 6, "F4", 0 },
                    { new Guid("ace211de-fe34-447c-8848-49140867b8f3"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 10, "J2", 0 },
                    { new Guid("ad825fb0-586b-44e6-b0b0-73cfa64e66ad"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 5, "E2", 0 },
                    { new Guid("addd1a88-f320-45ba-971c-76d8d1e0e083"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 7, "G2", 0 },
                    { new Guid("ae69ec17-e5bd-4117-9764-0578cd3d16b2"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 5, "E4", 0 },
                    { new Guid("af14963a-f2e9-43f9-85e8-c0f5d472f1e0"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 5, "E3", 0 },
                    { new Guid("af7bc32d-b924-4e76-a9f3-713da0407521"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 2, "B2", 0 },
                    { new Guid("b1010064-2289-4121-8041-eeea4858f61e"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 2, "B1", 0 },
                    { new Guid("b1892200-3cf7-4bcf-999c-cb1c98c19c6b"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 5, "E2", 0 },
                    { new Guid("b342c395-bca6-4271-aca0-8b92c160b709"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 4, "D1", 0 },
                    { new Guid("b6f32307-63bd-4a36-81a0-4792b6da91c8"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 4, "D3", 0 },
                    { new Guid("b7604c18-eb6f-4ca9-a149-64bc377148bb"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 6, "F2", 0 },
                    { new Guid("b99589aa-793e-4629-abc4-02276018a66a"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 1, "A2", 0 },
                    { new Guid("bf58736c-8b1a-4586-806e-82e075a73ee9"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 5, "E1", 0 },
                    { new Guid("c146c35b-a6f2-4bb1-a9a6-113b05da52ee"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 2, "B3", 0 },
                    { new Guid("c1865857-c8fb-4d43-8637-bc76f7c45996"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 4, "D4", 0 },
                    { new Guid("c218cd5d-e9f0-4bc1-9e7f-7fc0f1b22742"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 8, "H4", 0 },
                    { new Guid("c237ae54-db54-4013-a0ec-a9beca5952a6"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 5, "E4", 0 },
                    { new Guid("c297503e-20ad-4309-9e84-65628664acfe"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 1, "A4", 0 },
                    { new Guid("c3032c01-f5cb-4c04-b121-cc29f94da3e9"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 9, "I4", 0 },
                    { new Guid("c55b200f-240e-4149-9744-35ab1935a5b5"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 6, "F4", 0 },
                    { new Guid("c6630965-0dfb-45ae-85db-61c49caae024"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 10, "J3", 0 },
                    { new Guid("c73e9940-b84f-4436-b3c5-180239499417"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 4, "D4", 0 },
                    { new Guid("c763d8eb-5157-4644-a36d-54c8ef784548"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 4, "D2", 0 },
                    { new Guid("c8e8387d-6509-492a-b0cb-d611cf8d77f7"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 4, "D2", 0 },
                    { new Guid("c920cea1-63dc-4cbe-bb4f-e762ca6f9217"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 9, "I1", 0 },
                    { new Guid("ca561833-e33e-4f64-96ea-b28515dce175"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 3, "C2", 0 },
                    { new Guid("cc163118-13ca-45d4-b9b7-9d1cc2e5fbc5"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 10, "J4", 0 },
                    { new Guid("cc3d0761-2a1f-4a87-a4c8-2e63ef67b5a9"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 3, "C2", 0 },
                    { new Guid("cc59e9fd-ef66-46a6-a994-71cfc8a8688d"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 4, "D3", 0 },
                    { new Guid("cdf0d428-3ce6-481d-bf22-8772538e7579"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 4, "D4", 0 },
                    { new Guid("ce3f4c6f-1221-4bf8-bbfd-ae80596d4191"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 3, "C4", 0 },
                    { new Guid("d076d1cd-63af-45ff-bb1d-594808e74b4c"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 10, "J1", 0 },
                    { new Guid("d0aa55df-2a05-4125-b645-7f11dc7eadcb"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 9, "I3", 0 },
                    { new Guid("d1f10759-73bb-48c0-8c03-2c34e02b867b"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 2, "B2", 0 },
                    { new Guid("d22d76aa-7065-4345-8c3d-ee77580ff651"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 4, "D1", 0 },
                    { new Guid("d3041cda-a21e-4130-ac87-434de0a9e50b"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 1, "A3", 0 },
                    { new Guid("d3b93e9d-311c-42a9-ba52-ca228a5f434f"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 6, "F2", 0 },
                    { new Guid("d4704d3d-9518-4f00-a0d5-11f32eadfab7"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 11, "K1", 0 },
                    { new Guid("d74e6b25-feef-4002-8a4c-2f0199cf3479"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 5, "E1", 0 },
                    { new Guid("d8a8b760-5656-42f3-bd3a-bdf17b535769"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 3, "C3", 0 },
                    { new Guid("d8b80023-dfb9-4388-8136-59cd6d18a70c"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 3, "C1", 0 },
                    { new Guid("dce9a099-5efa-43ac-851a-cfd69a2ae2e1"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 2, "B1", 0 },
                    { new Guid("de242aab-7135-4664-a174-5ea4d0a5678e"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 9, "I2", 0 },
                    { new Guid("df4a8794-e854-46c4-88c5-d56886eb3c03"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 1, "A1", 0 },
                    { new Guid("df908c18-caa7-44ff-9a54-b3ef95e7e167"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 1, "A2", 0 },
                    { new Guid("e180a499-b293-4fd1-9e17-90c39799f2c0"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 5, "E1", 0 },
                    { new Guid("e1a3c2e4-cc98-4c3b-90c7-71d05e4f236c"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 1, "A1", 0 },
                    { new Guid("e38dca5b-2b61-4201-8433-920f9514ae67"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 1, "A3", 0 },
                    { new Guid("e4986273-2fa8-41f3-b048-1f135b10a62c"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 4, "D3", 0 },
                    { new Guid("e5d3c488-c23a-4ad1-bbac-5d4fee55d0e4"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 9, "I3", 0 },
                    { new Guid("e60d2bbc-193c-4932-ba2e-3ea05d9fddc2"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 1, "A4", 0 },
                    { new Guid("e68e7ee2-760d-43ee-a0cc-2fc56a5ab7f2"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 2, "B1", 0 },
                    { new Guid("e7c2e4be-ebb1-4553-a294-b899423d6697"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 7, "G3", 0 },
                    { new Guid("e84ee3f8-2d5c-4802-b014-1436d2168137"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 8, "H2", 0 },
                    { new Guid("e9674589-c450-427b-98a1-6d9dbabc899e"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 2, "B3", 0 },
                    { new Guid("eae4f038-109c-4adf-a7f1-dae6de6ddb9a"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 3, "C2", 0 },
                    { new Guid("ec5a3358-2dc7-49b4-b187-fad4efaea932"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 3, "C3", 0 },
                    { new Guid("ecb8defe-e614-4e29-b8f0-a375caca97dc"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 2, "B2", 0 },
                    { new Guid("ed1b397e-1117-4773-8828-68f268bafe4e"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 2, "B1", 0 },
                    { new Guid("eeefa27f-de55-4640-a4bd-9dc7d0d60db2"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 8, "H3", 0 },
                    { new Guid("f2431306-944e-4de0-a7ae-ec6cc4e61a11"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 6, "F3", 0 },
                    { new Guid("f26bd997-99b0-4b1f-b5b0-82bfd602d932"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 5, "E4", 0 },
                    { new Guid("f4999c2d-fe6a-4cb6-82a4-9f2e079c3d53"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 5, "E3", 0 },
                    { new Guid("f826937f-d8b7-4484-a5cc-1f6e7adc4118"), new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"), 5, "E3", 0 },
                    { new Guid("fb1d9fdd-8b5b-467a-93ee-399889219700"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 3, "C2", 0 },
                    { new Guid("fb235f44-7726-4a84-bba0-5c7784bb1bd9"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 4, "D2", 0 },
                    { new Guid("fb2602da-db67-477c-85ab-952538e16329"), new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"), 6, "F1", 0 },
                    { new Guid("fb3aa81b-4ab6-42a9-953b-99632952df0d"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 2, "B2", 0 },
                    { new Guid("fb6dab30-9bbe-4ef9-bc16-205d88d4e0c3"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 5, "E4", 0 },
                    { new Guid("fcc13a55-d1df-4eaf-99be-3625f727d5a7"), new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"), 3, "C4", 0 },
                    { new Guid("fcd6c2f7-5691-428b-bada-6b7362529266"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 1, "A1", 0 },
                    { new Guid("fd5064b4-90de-43a5-9387-0bff478ac66e"), new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"), 6, "F2", 0 },
                    { new Guid("fd919a0e-da70-4543-8346-a0b84738467f"), new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"), 7, "G2", 0 },
                    { new Guid("feb9c057-bb5d-4226-a52d-87049e5cbb6f"), new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"), 7, "G1", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("007059c8-0ce1-46f8-9083-8b21279cc9ea"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("06ddcf62-8106-4be9-9613-09795cbf938c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0779b05b-a9cf-4655-8e06-d02cdbddd7c5"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0b309cf1-6ce4-4ffd-b2c1-08e898a8aad1"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0bb7ac0c-a820-488c-b5b9-0664a3a03c81"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1000e3c7-74ad-4ed6-809b-12a94c1bb3a8"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("112969ac-4429-4dca-b3fb-5cab0546cc6e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("15d9b750-336a-4d76-b246-20d50d55d742"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("17358322-661c-4dc0-b8dd-3fc7c290227a"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1a7def9d-287e-409e-ac9f-7cd423ed95ec"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1a8a6472-ff5b-4a54-83e7-33e64c6b9d72"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1c031fbd-34b3-424d-8595-0a6b4a60d96e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1ca705cb-897e-48fa-a7e6-761a3c5ceed1"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1d583354-1397-4f4c-b48e-97268e6306c8"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1d71ff8a-a5c1-4ccb-a4c2-04e99bef7243"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1e34d647-1c87-4a14-a5ff-8b2679b283fc"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("20bc23f2-66ee-4fac-9b59-ee010f01a36c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("20f07257-9555-49b0-98bf-e9e67b6f548b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("218e31ef-2858-41db-b042-9480e8a7e6ca"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("242656ae-8429-4005-8049-8933c0832db3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("25b16fa8-0917-40eb-a238-99faa016f1ad"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2638159b-30db-49c3-adcd-4dfe07651a31"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("26586622-6f69-41b0-bf53-d2b7f33ecb9e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("27610c64-73bd-462c-88eb-6abba58e387c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2a0651df-9c6b-4ee1-8ecd-fdb380b3bbbb"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2ac43d1f-a847-48b5-a260-3f980b8fb8c9"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2bf4708a-c23b-4f9c-ac46-67a480375dd1"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2d226b27-af1a-4640-87af-0ab180bbf544"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2e5d7449-5232-4d2c-9aad-d65c07702e79"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2fc257a3-8315-4a6e-9c4b-8d5eb415b334"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("33602a47-3780-433e-b158-669747b39032"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("378ace0a-d0c8-4a9f-af57-3b3ef4cd7b19"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("37e66bfe-9331-4273-80db-9318ed16d905"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3a7ef1c5-43c1-4a91-ace9-afa3cb6f3505"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3e213dc2-152f-40c6-80c5-65f1680b74ff"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3e21a80c-461d-4abe-abbc-4544837a9385"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("416c78e8-e793-4946-b707-e3ba15ac0fd1"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("45b50058-b1ac-4cb2-8357-f3f67fabfbf3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("46b66d72-6c43-4cfd-a9b0-be887e8bc723"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("497ad4b9-a789-4dcc-bbb6-fb349ff4041b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("499a18c5-e92a-4f02-865e-d9c21170489f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5065b1ce-37b2-4e25-baff-9f75200aa208"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5108c6d6-bf76-44d7-b182-7747834d411d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("517c2983-1a3b-4ac7-9728-400d06693820"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("53851591-c037-4c6e-843e-28093b4e86ca"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("54da2b14-0ac2-4f18-89c3-58470d868925"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("551020e1-f82f-42d0-b9d0-e89d68e9c05b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("55ae47a9-3d06-43b1-a9db-de967b955c4e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("586acad3-e1fe-42cf-9231-27aef0997a71"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("60596c9c-1bd5-4778-b74b-70d8c6d4dd05"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("60e4ae26-bd37-4b5c-89a5-712161f70560"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("60f6e0aa-07fb-4118-9522-79616e5872da"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("61474356-fc08-4b9f-8e21-c6e13c387cfd"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("61a7b747-92d6-44ee-bc8a-812f245523ae"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6546c233-530e-4c6f-a012-835d746b0c76"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("661871b7-dc37-423f-90d4-4af890a32748"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("673e5ae0-2ff8-4744-9f29-0135d5152b59"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6749c398-c6dd-407f-bb11-1d5b0a5baa8a"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("67b2b0a2-e149-434a-813a-8999be0c7d0e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("67b7f99d-fe03-4d1d-833d-56d1efd09feb"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("68bae80f-5e24-461d-814f-6cdc053b0b40"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6a1a6ce4-5d57-4b87-a638-d3920abebf46"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6a433652-81e1-4432-877d-25d380d43f5c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6aa4334e-bbca-4406-97d5-d1618ef4c341"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6ab7b788-c691-4ed8-bea6-4a860ca3b7a3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6cde0181-e172-475f-a68f-e8dadc182804"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6eac906c-6e91-48ac-950b-3d3906b8aa06"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6fa50e9e-cbf2-41c3-923f-be5164488b62"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7a20b700-536f-4e64-af59-e07e5875bcaa"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7c1c4f85-57e7-4406-8912-2b2b0e0c3b2f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7ee4288c-c789-444b-96a0-c5fd4ebce92c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("80f9ca36-ff5b-41fc-82d6-ec3c2e33a579"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("816ef938-022b-4362-8412-9e88ba227268"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("817c55d2-d067-46ae-a21e-b2af96596c2f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("81f12af2-8f1c-4eb9-a604-87ed5c3db828"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("822fbbf4-f6aa-465b-8acd-081627e6a806"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("83fa9bcc-054a-4c11-8012-9df993fb5f27"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("843403b8-1562-4b6f-8cfc-6f1a2210edf4"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("844c3b8e-cec6-4265-8ff7-72d0b840519f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("84db35c1-fdaa-408d-9fef-de8f84403cb7"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("85e19913-8108-4297-bce8-56156e44ad14"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("89bf590d-fa3b-4c70-a11a-2df744a488bc"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8a51ef28-cbaf-440b-a63d-0918357969b7"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8c71cd28-e81e-447c-b6cc-7fc6610955ff"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("926b0673-0070-4f8e-bf5a-e1e0cc488f9d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("9e9528d3-c87f-499b-801a-3bb9e7cf6545"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("9eaa013e-c813-47fa-917b-77a914f4cb04"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("9eea2918-2b1d-4728-bf56-2ccd0e3042ed"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a0db3c09-d76c-4af2-abcb-e02356fcc0d4"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a1bacaeb-fd45-4d40-bece-93b7991e369f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a1fdf893-a5b4-45bc-9fa5-8be3af05fd37"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a2224978-9555-4f46-b021-3fdbe85c8175"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a5883f1d-fe8e-4769-a6e1-40349cd58cb9"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a63237de-91b5-4db0-9668-96ffe24122b4"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a65f90fd-3521-4d2e-bc82-e8c8594aeb03"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a7a06fd9-899d-467f-a656-1f5846ad201b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a7dc17fa-eaac-4526-9764-2b4ac6ee11ac"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("aaaebe68-fe66-455e-89a4-caf5dba5c856"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ab488c38-51a0-47b6-a6d1-949394e3d898"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("abf95f04-8949-4351-a31c-fa2435c6ef00"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ac526502-9f8b-44a3-800c-b13d8e3667f0"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("acc63e6e-f11b-45c7-9b0c-6944664f2ecf"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("af1ac032-9bce-4957-abf7-90e61e5ec1ae"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("afbc42ec-9358-4ea0-ae94-da38f17a8c8d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b21e3807-5d59-439e-b6ad-1c073883d369"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b4f2cba9-f4e4-4516-8dc2-2a2e2a1642a4"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b5b8bf24-5592-4535-bf6c-0e0a72782e9b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b621a326-1aa5-43ac-9400-e705b1283e3d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b643c56a-ec2c-4072-965d-8a0c09b49651"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b717c538-bb8c-49f1-ab34-8efcd9dec2a0"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b7fe72ba-ec01-4372-8fb1-c281b08ded64"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b88b3ff1-7d34-40cf-a9b2-6f488ad70c9d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bb2e881e-c343-4fd9-88d8-b077a72346ae"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bb5509b8-dfbe-4ab8-ba10-ab6dec265d6c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bbebee65-abab-42b0-9892-667d6af50047"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bc4263f4-619a-4cf0-9c72-b9ae67f15606"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bea9c8f8-7cba-40d9-8059-3e966e48a683"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c062c41d-4d0b-4d40-a1da-e8ed15f0a61d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c06d2f61-f1b4-476e-858c-efaedf758ede"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c5adb818-9fde-4fd6-a56b-ca9edef1ba4a"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c64cf6b2-a3fd-414f-b276-71445b98680f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c673db0a-74ac-480b-8905-b38980f8e28b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c7238495-517b-473b-896d-e9d7d58e6e57"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c77eb3e2-3168-42e4-bd95-a41538cf1024"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c7ce8152-6275-413f-a6e6-07fc094d253a"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c91c644e-1d4a-43f6-a743-54c76d123abf"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("cd0cb5c7-8846-4235-a6f4-2c88cad5ee89"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d488b06f-9c75-4379-9947-02f235ed7ff6"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d84445ff-8dd4-40ba-932a-228bc01723b5"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d98a6599-03e4-4421-b9cb-ed32ef18660a"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d9b5a094-6cfa-48d3-961f-c69f0bdb6cfe"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dc8c7ad6-ecb0-44a4-ab14-acdd45039308"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ddee37db-cad2-4b7a-807a-79b21d6eb443"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("de50ba9c-b58f-4d81-927c-38c2eb314cc9"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("deb2b630-48a6-4591-8516-eeb58462c4b7"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e6570320-4079-4941-ba7c-8dd8842dc7ab"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e80783ad-740d-4da1-a31c-8bef1742bdca"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e8a9e5b5-77bc-4e62-a393-3e768d275ab0"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e8df27dc-a7ac-481b-b55e-86a357eefe89"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ebc6b64d-8c55-4e1a-9d4e-9aecbe72bdbe"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ec4469d0-21f6-4484-a284-14f674c5f79c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("edd7f91e-bc99-414d-9a2f-03383145939c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f3dd1114-e664-47f2-aad1-6a095b5e966b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f42c6295-43ca-4292-8722-913bf05c6ffb"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f475cf15-acef-4100-a323-23a30604e181"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f94f9361-884e-409d-9c87-c088939e4d7f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f9f9ba45-bafb-4a57-8f40-e5eb3bf6251e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("fb13675b-c677-4497-8c17-035d2feda29b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("fe6f0e7a-195e-4186-bb31-d012a97adacc"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("fec2ba42-297f-48ad-b77a-13bd16b244a4"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("44726618-38d2-4e82-80a1-e9e1559da53c"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("45068e7e-e245-4609-a07f-9d8befe0647e"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("4e5aa261-8d78-4526-95bf-c3b9d043e77c"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("696e8ae8-afbe-4b2c-841e-a7fcd98a7db5"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("6df473cb-51e4-45ad-b259-224351402ad4"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("70f979b5-4738-4f48-bfd2-61ca2ed80fc6"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("8fb8d708-d508-421c-8117-88747c4caf71"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("9b621b1f-ba13-47f4-b73c-261c59bc95fa"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("b6a4994e-f9b1-4cdd-a2ed-f676938e1b67"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("b6e29505-fdd8-478e-b50f-d9383b0c2adb"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("bc49a107-70a8-4493-8851-9eed204668af"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("cf9eef4d-c4db-45e8-b21b-035a8f52c8c0"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("e26a6854-a89e-4222-bd95-e3b7bd9bed1c"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("e2a0a7e1-6de6-46b7-a67d-33c3295bdd61"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("e8ef2011-3987-475b-a4a9-f7f11e4b6fe8"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("fb8af5eb-4cfc-4ff9-9fb6-137451b92dfc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00080eb8-9ee3-45f8-9e03-da387ff3fefe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("002fd2b4-2339-40ec-b9c9-75df84e23203"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00eedbb2-a86f-4585-ada8-a9c162cbd413"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("017a6bf5-e8ed-4e65-8ca3-641642ee22c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07894d82-3d3e-4ee7-9982-4239a0ea81f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a036ef7-6085-4c42-8248-b01e05f2f9f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b7c1ee4-aed9-4a06-a781-7b261beed410"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c5ea79a-d5d2-437d-8d56-e2a54c1763c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d56cdb8-bb0d-465e-8f43-c38ca6661061"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0de3d7b7-6fa8-4d0e-8463-0b174d56e086"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0df88b98-a872-493c-b944-fdc3f0dc4193"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fe5cbc2-1e28-4226-b4ba-c6703719557e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10cff327-aeaa-4eb9-8de2-f08e76391204"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12155b73-3833-4e14-838c-29e2ff985bb7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1386c42c-2012-4dea-a9b4-61437044a0a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13bed441-c398-4ef4-abda-c5ee48f9167a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15103f97-60ac-4644-bcdc-692df9dc23e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17643e63-0d6f-421b-ba1d-cc27fdebee7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b700d89-b0c9-4de2-b478-98fc0135ae87"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1becb987-7828-4064-b37d-556de496ca27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e37b201-30ac-4728-9948-d63ea954b728"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e5d49cc-c059-4070-a78a-3914dd95920e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f356b67-35b3-41e2-af12-2ff85a950fc8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("20ae083d-2f88-4256-9895-bb5993c53dad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21a37f38-4dc1-4880-b393-5fac93b86ff6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2295e6f5-a98e-4273-a68b-d3e34c57c3a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2400e22e-c74d-4c8f-9438-53015ee6490b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("246ed318-e6ba-4614-bf90-6108563beb0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24f6b947-8948-44cb-b4a5-f1266504ab5a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("260d4c68-b0f4-4091-9e19-2e4528b5473e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a7ea8c8-b366-40cb-8376-a71c8aaeb535"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a823824-d998-418f-bec7-1bafa2ba724e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c37df0f-9417-47be-8f3f-b223e44a3311"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2cbbdba0-5f03-4c70-9136-2b24cbb44524"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2cc5ddfe-af38-4502-8ed2-3a84f59031e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e6fd722-0c1b-4be7-9f78-0f531739474a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30328496-b2bd-4b14-b5f7-f9cc0c0153ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32bf7372-4d9b-416e-8473-adeeeb0dc54a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3380f84f-2914-4a52-ae94-35897d10840c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("35888cdb-2c6a-4083-b5d5-cc923eaa48a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("391fff5c-41da-43c2-8f58-35e793582762"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("393551d4-c9df-48b9-9c6e-e33476059c37"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39d692f1-a1c9-430b-9500-85a384a15f56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a8326f2-085f-48ea-88f8-8714c71f4db2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c1ed382-f834-44a8-9900-f70ec1018af3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ddbb2cf-ef74-4e3a-b711-032ecbba6847"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3fa01597-a8f9-4207-a347-39694bcf9c01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40578813-1399-44db-a019-04a513bbb81c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4394cf7d-6e88-45da-845c-0dbdc06745fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("443f9dc7-30c4-4f42-907d-85fb29ec8a6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44a80887-60e8-46d4-a76d-1d1b979837e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45be5ca5-cf9c-4fbb-853d-d11d8eab03e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("47c4ea5c-5b8f-488a-9c47-57c8726c65e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a4a0591-7910-4095-98c4-ad20599896e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4aaefc76-11d0-4bff-96be-0f6f87fbb5d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4adfcd26-dfd7-4aac-9fcf-781c3f38e6a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ba9ad6d-a52f-454c-aeed-e78c4b5b54bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d8aa1cb-2adc-4a07-8ca8-694e599f52bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ea30a7d-9248-4a50-95f2-47dce2b1555f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4eb6c357-37e3-477b-bbbb-da19ac8ba092"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4feff0ac-5228-43e1-a3dd-d1f7975d6293"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("505063de-9984-4612-9174-4e09b7c570a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5505be7b-c878-4a89-8abd-50b0a5fda7e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5572f69a-4e14-4e83-86f1-70ca03b0726f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("584a9b05-7747-4dbe-b1f8-84b6cf95c678"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("584ba665-eaca-42d9-af41-d57f7ad5964a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("589cc710-87b6-417f-8304-bf2e3b5c2ea0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5974feb3-0adb-4b85-9b27-a7724162a32a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5c665694-4f53-493b-8bb1-d10bbd75c8d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e9651d7-28dc-4b8a-bbde-dfe49a102031"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ed596ec-5976-4e44-a98b-88a0091c55fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f448331-3149-48aa-8d66-51dc07185f63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5fe0eb18-393a-4f5e-8559-7ded904fad4d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("607ba899-57b3-4974-900b-cfc4ac1eb30d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("629f1688-4b9e-4648-92da-8ba8a66808bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63373568-25b3-47cb-b11b-d592ddf57c03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65043d46-7228-4183-8996-0059bd43d33e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("675620c8-7cd2-4fd9-9c9a-b1f211bd9645"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("678bef63-e5b7-42f2-9733-b683a48dc1ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67f0231c-37cf-4fe8-84d8-ba27509209b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("688ff2e5-9445-4707-b7c8-fe53c132fcf8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("691ae9f2-928e-4dfc-8ee4-8a4609ece4c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6aace38b-7988-4f89-855e-c90996f5bce0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b699a25-75a6-4c2d-8362-bfebf633e1d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b6f5295-00e3-4a72-a1a9-0475f7d46e2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c915752-f861-4970-8b3f-7e236bc0e1bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c961329-2933-4d79-a48c-47013e548e36"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d1fe1a4-2f15-4da2-93ca-42b2f17d156b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6eecb2e5-9a9f-4d56-884d-491ad81173b4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f48c96a-b34a-4e34-aa7e-66ed47b348cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fdbf5d9-be46-4a5a-a09b-16557cd6eb5e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7171b021-79fd-44b4-9ad2-9c480d29c5fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72092ce6-49f3-4122-973f-fd7ede9a70b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72aabc57-db5f-4f4a-b1e0-6ff0686fe21f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("778a954c-6ca5-49a2-8461-9eab2dc436d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78b50911-bb40-4890-a206-e2c77a186c5a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("795c27d6-660e-4326-890a-645889c0d59f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a693e52-bbcd-412e-a190-31dd4bb64a40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c84df1c-df7c-4895-8239-46833b29be23"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c87a265-12f7-4982-a3b9-9a4e829c2c81"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ca8ca4a-817e-40c9-ba41-acf57b337f4d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7cee77ad-3602-44c0-9dbc-74f40e67189b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d531b5e-29ca-48d2-9bb2-2ef12618f533"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80e18ade-880c-4f79-9413-12acf514faf9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8170c3bf-61d4-4c49-8784-37cbd20b5406"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8294bcb8-0a7b-4828-9b01-bded5b5a46ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83731584-ce43-4164-897e-7f05ac8511f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8404c9d0-ea5b-480e-89de-6c0620c85f92"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86ce50b2-26ed-4c68-b29b-f5592c1c7951"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("879bf139-ed1f-4194-b8c7-eb4660a78b19"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8815c3f0-8954-41c3-8f3f-a8c9c133de75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("88c94c80-6de0-4c30-b3a6-702be547deaa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("894d7f64-830a-4b91-95a0-6c1159882491"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a776a03-7534-47f1-be7f-686c843b72bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b81b454-6f41-4b47-baf6-4535c581b008"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b8c3fb0-fd41-4892-ad42-bf2a96411b99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c0ba964-8fbb-42dc-8a44-5c29d99aa376"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e2da394-58bd-4475-b951-4822f73fc4dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8eb5a136-fd85-4281-b29d-fa35e0b9b776"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f41a87b-f9d8-41e8-85d8-3e6ed08e55f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f87578a-51ba-4f89-a690-9937076b85a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("905cb8ea-94cd-486d-ab42-eed32f97c8cf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9496cb02-1003-47fb-8868-857fd244b279"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c2bdba8-51bb-4421-98b2-3c675ae04f94"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9dc516d3-25cd-4b17-806e-561dfb984b9f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9eabc6d9-d54e-4c19-b44a-298dcffdd912"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f408075-dd66-4e68-9ce2-4b26f36704f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a28a5118-196e-4771-b9da-75e58bebcd65"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2980261-51eb-4570-a188-443cdcf4fae7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a499c524-35f9-4e38-9bb6-3ac83f15e0c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5a7ce2d-291c-4b5a-a341-12a805bd1cac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5edd9a6-e244-4eb6-896a-5b2cdb1751d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6609795-9ef1-4309-b1ff-8d0bc2961fce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a694506a-c555-402b-a61c-2ea7c7fe48a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6a734d7-5ddb-4ddf-b8d0-f41c5d59c964"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7565d92-38f0-4922-8250-5ca54b0a91d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7d9ec78-0657-4598-aba7-ab20af96e313"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a82420bf-7df5-4810-93b7-f00f30ac6564"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a97bc579-d268-487c-924b-509946060900"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9d25262-0f2a-49d7-8346-70710b58cd9d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abb7441f-1b81-4844-874e-0135f5eafce6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac9beb43-c3f8-484c-b1fa-301981421dcd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ace211de-fe34-447c-8848-49140867b8f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad825fb0-586b-44e6-b0b0-73cfa64e66ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("addd1a88-f320-45ba-971c-76d8d1e0e083"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae69ec17-e5bd-4117-9764-0578cd3d16b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af14963a-f2e9-43f9-85e8-c0f5d472f1e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af7bc32d-b924-4e76-a9f3-713da0407521"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1010064-2289-4121-8041-eeea4858f61e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1892200-3cf7-4bcf-999c-cb1c98c19c6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b342c395-bca6-4271-aca0-8b92c160b709"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b6f32307-63bd-4a36-81a0-4792b6da91c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7604c18-eb6f-4ca9-a149-64bc377148bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b99589aa-793e-4629-abc4-02276018a66a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf58736c-8b1a-4586-806e-82e075a73ee9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c146c35b-a6f2-4bb1-a9a6-113b05da52ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1865857-c8fb-4d43-8637-bc76f7c45996"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c218cd5d-e9f0-4bc1-9e7f-7fc0f1b22742"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c237ae54-db54-4013-a0ec-a9beca5952a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c297503e-20ad-4309-9e84-65628664acfe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3032c01-f5cb-4c04-b121-cc29f94da3e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c55b200f-240e-4149-9744-35ab1935a5b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6630965-0dfb-45ae-85db-61c49caae024"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c73e9940-b84f-4436-b3c5-180239499417"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c763d8eb-5157-4644-a36d-54c8ef784548"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8e8387d-6509-492a-b0cb-d611cf8d77f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c920cea1-63dc-4cbe-bb4f-e762ca6f9217"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca561833-e33e-4f64-96ea-b28515dce175"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc163118-13ca-45d4-b9b7-9d1cc2e5fbc5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc3d0761-2a1f-4a87-a4c8-2e63ef67b5a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc59e9fd-ef66-46a6-a994-71cfc8a8688d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cdf0d428-3ce6-481d-bf22-8772538e7579"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce3f4c6f-1221-4bf8-bbfd-ae80596d4191"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d076d1cd-63af-45ff-bb1d-594808e74b4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0aa55df-2a05-4125-b645-7f11dc7eadcb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1f10759-73bb-48c0-8c03-2c34e02b867b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d22d76aa-7065-4345-8c3d-ee77580ff651"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3041cda-a21e-4130-ac87-434de0a9e50b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3b93e9d-311c-42a9-ba52-ca228a5f434f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4704d3d-9518-4f00-a0d5-11f32eadfab7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d74e6b25-feef-4002-8a4c-2f0199cf3479"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8a8b760-5656-42f3-bd3a-bdf17b535769"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8b80023-dfb9-4388-8136-59cd6d18a70c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dce9a099-5efa-43ac-851a-cfd69a2ae2e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de242aab-7135-4664-a174-5ea4d0a5678e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df4a8794-e854-46c4-88c5-d56886eb3c03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df908c18-caa7-44ff-9a54-b3ef95e7e167"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e180a499-b293-4fd1-9e17-90c39799f2c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1a3c2e4-cc98-4c3b-90c7-71d05e4f236c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e38dca5b-2b61-4201-8433-920f9514ae67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4986273-2fa8-41f3-b048-1f135b10a62c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5d3c488-c23a-4ad1-bbac-5d4fee55d0e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e60d2bbc-193c-4932-ba2e-3ea05d9fddc2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e68e7ee2-760d-43ee-a0cc-2fc56a5ab7f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e7c2e4be-ebb1-4553-a294-b899423d6697"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e84ee3f8-2d5c-4802-b014-1436d2168137"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9674589-c450-427b-98a1-6d9dbabc899e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eae4f038-109c-4adf-a7f1-dae6de6ddb9a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec5a3358-2dc7-49b4-b187-fad4efaea932"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ecb8defe-e614-4e29-b8f0-a375caca97dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed1b397e-1117-4773-8828-68f268bafe4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eeefa27f-de55-4640-a4bd-9dc7d0d60db2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2431306-944e-4de0-a7ae-ec6cc4e61a11"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f26bd997-99b0-4b1f-b5b0-82bfd602d932"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4999c2d-fe6a-4cb6-82a4-9f2e079c3d53"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f826937f-d8b7-4484-a5cc-1f6e7adc4118"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb1d9fdd-8b5b-467a-93ee-399889219700"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb235f44-7726-4a84-bba0-5c7784bb1bd9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb2602da-db67-477c-85ab-952538e16329"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb3aa81b-4ab6-42a9-953b-99632952df0d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb6dab30-9bbe-4ef9-bc16-205d88d4e0c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fcc13a55-d1df-4eaf-99be-3625f727d5a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fcd6c2f7-5691-428b-bada-6b7362529266"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd5064b4-90de-43a5-9387-0bff478ac66e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd919a0e-da70-4543-8346-a0b84738467f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("feb9c057-bb5d-4226-a52d-87049e5cbb6f"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("4e84319a-b78d-426e-8d1a-eeee538c8f34"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("5eb22cc5-5103-4c36-b542-09fe5dc442a1"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("606ef574-11b4-4235-9453-a77a47adc3d6"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("7b8ed68e-1cbc-4b61-8ac1-4411599ae791"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("f44dbb15-34f8-4b62-b930-f0cecb6de9cd"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("f5020e54-efb0-4c9e-83d8-23cabd885bea"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("0ead6381-f32a-41ba-9aa6-a1b8d28c7ead"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("14c078e5-fd72-4b61-ae52-775ebd1d62a9"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("454f8995-5266-4dd8-a285-f85c75f038ed"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("46485165-99a4-4b81-b370-9de4c08898a5"));
        }
    }
}
