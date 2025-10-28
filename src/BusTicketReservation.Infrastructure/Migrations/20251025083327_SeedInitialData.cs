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
                    { new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), "Royal Premium", 2, "Royal Coach", 42 },
                    { new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), "Hanif Special", 1, "Hanif Enterprise", 36 },
                    { new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), "Shohagh Luxury", 2, "Shohagh Paribahan", 45 },
                    { new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), "Ena Premium", 2, "Ena Transport", 32 },
                    { new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), "Kushtia Deluxe", 1, "Kushtia Express", 40 },
                    { new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), "Dhaka Express", 1, "Green Line Paribahan", 40 }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "RouteName" },
                values: new object[,]
                {
                    { new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a"), "Kushtia-Dhaka" },
                    { new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411"), "Dhaka-Sylhet" },
                    { new Guid("81c48208-6579-4cfc-91f9-347274f7486e"), "Dhaka-Kushtia" },
                    { new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991"), "Dhaka-Chittagong" }
                });

            migrationBuilder.InsertData(
                table: "BusSchedules",
                columns: new[] { "Id", "ArrivalTime", "BusId", "DepartureTime", "JourneyDate", "Price", "RouteId" },
                values: new object[,]
                {
                    { new Guid("0013897a-99cb-41af-b02e-a338e4d5ac37"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("00ab8b56-7fff-4a73-a867-64a9c75c8829"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("01b95170-4242-4170-88fc-8921719fa800"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("04f48998-a514-4e2d-822b-f7aab9e889b2"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("05c42bd1-a1c7-4868-9f4a-46527c660d60"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("06002804-672d-450e-9891-2cb88dd8a947"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("0737e688-24a2-4093-af21-4e09bd382921"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("077677e5-0e15-43a3-920e-81480d868abf"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("08d33076-885a-45b4-90f7-84d6c910e420"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("0bd8b0c6-8fd1-48cf-ae96-5634bcf5e2bb"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("0e8126a5-a59c-44bb-bf8e-7f2b745c5386"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("0ee0d059-5f55-41ac-994c-5bbb5b04670b"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("0ff908e0-27d2-448f-8571-9068641f45df"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("1038a8f5-5457-41f4-94bd-f8ab719e7b2f"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("12653b3c-72cc-4ccd-a638-ce827b2d3c2d"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("13703625-5fe9-4052-a2b2-5a46559c190b"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("1460d031-5ca9-47c2-926d-8563b5b292f9"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("1538f25b-4657-4a73-9032-16bd89f7df81"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("168c7b35-08a3-4a35-acf0-b3ab848fc0d1"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("16d1d80b-f4b3-4f44-a8a7-b68bcd668f6c"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("1b38d27e-17ae-4e79-91e5-655900adcd3f"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("1ca70e8f-2777-4259-a75d-f117db4596ff"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("1d520cd3-0f35-456d-a766-37ba2bd0e041"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("1f3d5d76-44d2-4698-b639-b1ba3d8eaf1f"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("1f710794-ea46-4ce7-9b8f-d957cb32c039"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("20f1f7e1-b3c8-4d90-b834-96bdf01f3cc2"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("2237003c-3669-4fa5-8bdc-0b68dd92716d"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("22b2f509-9ed8-418c-91c5-e193961193b3"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("23a39fb2-fbb7-492f-b264-65c49905524e"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("290f457d-9987-421f-ae8e-526500c76fe3"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("2ae2c740-6063-4433-b805-9ab2a8c03ec3"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("2bd15095-da5a-4522-9bfe-b476f1286ee2"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("2bd20ff8-82e9-40c8-98bc-c8c90b742df6"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("2bea26eb-6904-4ed8-9b11-34ba8f6ee215"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("2dda8452-2a8c-4fea-8620-f8095facf336"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("314e894e-222a-4d56-a948-4852b14cd42a"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("3162818e-a1b2-4aec-b985-e23bfb181348"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("31fb066e-b81f-4da7-8d10-2244b3ff55fe"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("359865fe-bf0c-45dd-aeb5-5ece9b71d512"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("370c8109-26be-495d-9263-a7173ac110ef"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("39e70c59-3b92-4769-afc9-0a673367077c"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("3b0ef97e-1b03-47be-b2ee-2fac0cd0dafe"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("3ecba312-0de6-46ed-ab54-dff90c71f265"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("3f3af808-7a19-4665-9ad6-cb6fcd42b179"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("40e749de-e686-4b4b-992b-908d68b47ad3"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("41bb6e2b-3ab5-4efb-b5a5-012c3556d71f"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("41e2e649-9490-4d7e-ac77-1ec2f5e678d3"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("4271cb7b-e679-456e-81dc-6e1b2ff96a1f"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("442a9bd9-4a20-4f8e-8243-94f5bfbe40a3"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("4546fac3-576e-41ec-b917-0ec6c429fafd"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("48d98c8c-5c65-41d9-8f9c-7ef56c6821da"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("494eba4b-a068-4335-a74a-ce133c2cc34f"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("4a79bdf7-9ae0-427f-a084-1ceaff209d82"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("4d0187f4-2610-4a61-80ee-f7712c1d822c"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("4d24a870-27af-4392-a1da-ec9ffe643d64"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("4dea23f2-8514-4d65-8d79-fe0812c0c8ce"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("51f0db8c-0df6-4a43-a3b0-46c37969a2d7"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("56f0ff49-5d2a-433c-803c-7719958a3714"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("5a5131c1-7d75-4ed0-a1f1-6356a17d0980"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("5ae2c117-d913-4b58-adad-0f7b9de4cbd0"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("5c2dd318-f402-40c4-b03e-70385313dd1d"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("5d260c75-4bb0-4c70-b5df-fff440d8753d"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("5e7a8686-78ee-4cd8-8d7b-dd5456d76af3"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("6397f707-2733-4187-8cfe-2e29d63612b7"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("69f2c0e9-58f2-48ea-a6df-f2c1e8a77d0c"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("6d4d514a-32f4-4819-8290-95d176369dd6"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("6e5d8d96-fdb5-4964-9706-04c54c839775"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("6e8d8caf-f461-4972-ac6e-d9ccb9f0ca4b"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("6fd597d8-6a3f-4176-baab-2949b43d6735"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("73cc6607-4719-4264-814b-ec8605f293bd"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("74c896b6-b5b8-416d-a46a-b0098eff2d0b"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("7832fac3-50dd-4a39-bd5a-5b26f349feed"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("79aef723-8e72-4765-a0c5-b67f67e6dc99"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("7a74c9e5-0161-426f-8a81-1ce4394af835"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("7d90e6a7-b808-4fd1-b113-721cd4717203"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("7e526f5a-f586-4185-a0e4-6681a5971d75"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("7f3393ac-cc65-4331-b7c5-e66dbca63831"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("7f6ef402-a3df-4e14-bf6f-a1f31ce00fc0"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("80f83b2e-26d1-45d6-a918-fb33d91fb67f"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("8119ab5c-77cd-4c99-9ce0-dc805624ca8d"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("82038148-b05f-417a-b5ff-26d1fa77da1f"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("8215828c-ce0c-410c-a04a-15319da0326e"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("832e0248-62ff-40b0-9d40-a9d1af171476"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("84199f32-51af-4ec9-9697-82ab937054f6"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("841b01a3-d573-4d76-9add-0f2543cb2eaf"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("8586e137-e23a-4c8c-9ae5-539789314d6d"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("88be9b32-2916-455f-97f1-5425abd9a15c"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("8b59a0cc-e0a3-4360-bc22-a7f8efdde662"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("8c8c332e-a4f3-4882-99ec-814ce278c1b7"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("8c9879b3-89f3-4354-aca4-adfc9f32bde4"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("8cb20c8c-4353-4308-89a0-4dfcd11ba8b9"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("8ed44aa8-68b8-4834-8c0d-672b1b3cedde"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("92b28654-f063-4568-867e-9e708c47007c"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("9a0ef29a-065e-4bd3-a0c3-62e57bbbb285"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("9a5b69d1-4229-4e47-b80b-11edb2602195"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("a04dc015-5177-41f0-9fac-ef8426fc9cf7"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("a0c8f740-04f3-48ab-ae40-6ddec811258e"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("a2b41cd9-635e-4f14-be84-386bf7e47bd0"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("a31c5e1b-aa75-4d3f-ada2-20b757d28bf0"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("a4dc0c6a-0fb5-4eb1-9c6f-70df13df0367"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("a5d9f1b6-9f89-4280-86ec-b02850a37090"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("a73b5e0b-645d-49cb-898a-ee1927100c85"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("a9c479bc-4ea4-4032-b116-a2e92582c332"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("aa971a86-b164-4359-af14-0482af406c49"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("abc03b4c-cca4-48af-928c-47c8f9cbfdcf"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("ac600135-0e03-4822-84ac-1ee7ee3e08bb"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("aea2c5e6-8c9e-4110-9f23-74f4d8e5ff65"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("b0d312d8-196e-4c4d-9cb3-fd6cc9fea4bc"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("b130046f-9d99-4bf7-90bb-1f0bacba9a3e"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("bc168ec9-df31-4cc8-bdac-d44c27985151"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("bd40e345-9488-446b-a66e-6f26999275da"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("bffa205d-88cf-4a4f-ac67-45918be47372"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("c14839ea-9cf6-4dd2-96cc-e1f964fc70f0"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("c3cb42a8-77b3-42d4-b9fa-54314970466b"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("c586f211-2c7a-4b13-b2d2-598cb1674309"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("c6d2d2f3-c813-42a1-a195-359649da7979"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("caaa1d62-d641-4893-a6bb-203b78cec1ef"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("cb64329a-90bb-423a-9325-e2882407f34a"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("cdb7ff7b-7e68-4dcb-9781-7eb0998190a7"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("ce2e2750-02e9-43a4-985b-c4531f4a7281"), new TimeSpan(1, 1, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("cf508092-615b-49a5-923f-e489ffd5c8a5"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("cfab1391-23b0-4e6b-9ee1-79a4cf83561d"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("d0d28517-0ad2-40e3-ad9b-9a2a260aa099"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("d0f10a83-a563-4776-a0cb-e51055b4fc1e"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("d14ef16d-03be-439c-b9e3-c06c9442a98b"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("d2d58c65-7f03-4af1-a655-1484e2f698e7"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("d363fa0c-aec4-4152-ba49-af0b0c4c53bc"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("d3fd0f84-5613-4bd9-8ede-9fa496b430cf"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("d6105b80-ac5e-45f1-86f2-64d36317ff18"), new TimeSpan(1, 5, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 23, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("d6c042f4-8455-4c13-8fca-fe6c7c649775"), new TimeSpan(0, 14, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("d8409ace-7ffa-477f-adf2-403e9835891f"), new TimeSpan(0, 16, 0, 0, 0), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 850, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("d993a653-9413-4718-b805-8418b53a59c9"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("dacb40e4-9d14-4877-8fac-0e0a9a2b507b"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("daf68367-a390-4df1-a6f2-a4ac342a5f36"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 28, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("e122f703-262d-4b52-b920-81c5156ab261"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("e1b32b84-7544-4bb1-9ad1-2694e63adba5"), new TimeSpan(0, 13, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("e5129caa-be29-4c64-b827-debcd4d54392"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 11, 2, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("e571e6bc-c9c5-4c74-91f6-39068600bd41"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("e7f5574f-371e-4c68-a6ab-4d6a446034a6"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") },
                    { new Guid("ec4784a5-9a30-4b23-9883-f29d8c2ee548"), new TimeSpan(0, 19, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2025, 10, 31, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("eee3771d-e00e-461a-8846-6381dfd24130"), new TimeSpan(0, 20, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("f1af71cd-181e-4a37-9294-f8e0eaffc850"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 24, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("f206d04b-70dc-4f69-ac3b-f7c161c38ab3"), new TimeSpan(1, 4, 0, 0, 0), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 800, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("f5d92f1d-815e-40cd-8bc2-b8cc7978c8ad"), new TimeSpan(1, 3, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 22, 0, 0, 0), new DateTime(2025, 11, 1, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("f69c141c-ebc8-4ebc-881f-62ea05df0a9b"), new TimeSpan(0, 15, 0, 0, 0), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 650, new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991") },
                    { new Guid("f7c16c40-1d3d-41cf-aaab-17745735f5c9"), new TimeSpan(0, 11, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 6, 0, 0, 0), new DateTime(2025, 10, 30, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("f9e7209d-c3c1-4fea-b203-27ce600b1625"), new TimeSpan(0, 13, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2025, 10, 26, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("81c48208-6579-4cfc-91f9-347274f7486e") },
                    { new Guid("fb438fc6-c6a0-48b5-8cc7-654206a64629"), new TimeSpan(0, 12, 0, 0, 0), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), new TimeSpan(0, 7, 0, 0, 0), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Utc), 500, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("fe8a4bac-8f1d-43f4-87f3-ab63a1a01186"), new TimeSpan(0, 14, 0, 0, 0), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2025, 10, 29, 18, 0, 0, 0, DateTimeKind.Utc), 450, new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a") },
                    { new Guid("ff45e5cb-f319-4294-a4b4-5dc15278429e"), new TimeSpan(1, 3, 0, 0, 0), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), new TimeSpan(0, 21, 0, 0, 0), new DateTime(2025, 10, 27, 18, 0, 0, 0, DateTimeKind.Utc), 900, new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411") }
                });

            migrationBuilder.InsertData(
                table: "RouteStops",
                columns: new[] { "Id", "RouteId", "StopCode", "StopName", "StopOrder", "TimeOffset" },
                values: new object[,]
                {
                    { new Guid("1d02a383-455b-4573-958e-c6ec7f10be7a"), new Guid("81c48208-6579-4cfc-91f9-347274f7486e"), "gazipur_chandra", "Gazipur (Chandra)", 3, new TimeSpan(0, 3, 30, 0, 0) },
                    { new Guid("2123defe-4758-4414-8605-8c87fee3cfb9"), new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991"), "chittagong_gec", "Chittagong (GEC)", 4, new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("25b54f58-0612-44ab-8079-d916a1ec4944"), new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411"), "sylhet_amberkhana", "Sylhet (Amberkhana)", 4, new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("35a26008-9a00-45d1-ad8d-c7a29a2f42d3"), new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991"), "dhaka_sayedabad", "Dhaka (Sayedabad)", 1, new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("368356a2-0584-4cd2-92ab-3c100b1f8c36"), new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a"), "kushtia_mirpur", "Kushtia (Mirpur)", 2, new TimeSpan(0, 1, 30, 0, 0) },
                    { new Guid("579339ac-01de-473c-92ab-667047a3c3f3"), new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411"), "dhaka_mohakhali", "Dhaka (Mohakhali)", 1, new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("70cc0370-fa97-44cf-8b49-1da034a3e44a"), new Guid("81c48208-6579-4cfc-91f9-347274f7486e"), "kushtia_mojompur", "Kushtia (Mojompur)", 4, new TimeSpan(0, 5, 0, 0, 0) },
                    { new Guid("77f75f1a-2daa-4642-9a38-3c31553c529e"), new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a"), "pabna_ishwardi", "Pabna (Ishwardi)", 3, new TimeSpan(0, 3, 0, 0, 0) },
                    { new Guid("87e449f3-877b-40ab-b82e-d578c29908c5"), new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411"), "habiganj", "Habiganj", 3, new TimeSpan(0, 4, 0, 0, 0) },
                    { new Guid("8e687827-d97c-4a22-8bea-6524061db1f5"), new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991"), "comilla", "Comilla", 2, new TimeSpan(0, 2, 30, 0, 0) },
                    { new Guid("ae691172-42aa-49e2-bf1f-2f88f99f53ca"), new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a"), "dhaka_gabtoli", "Dhaka (Gabtoli)", 4, new TimeSpan(0, 5, 0, 0, 0) },
                    { new Guid("b075bec6-db7f-4138-bc31-bde4a22e54bd"), new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991"), "feni", "Feni", 3, new TimeSpan(0, 4, 0, 0, 0) },
                    { new Guid("d17ef4d1-0463-4f51-9fb6-a22da703e531"), new Guid("81c48208-6579-4cfc-91f9-347274f7486e"), "dhaka_gabtoli", "Dhaka (Gabtoli)", 1, new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("ef23f603-e7ab-42be-afc2-f5d446778195"), new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411"), "narsingdi", "Narsingdi", 2, new TimeSpan(0, 1, 30, 0, 0) },
                    { new Guid("f1a3163c-59d3-4f0f-8edf-b9b4daf869c4"), new Guid("81c48208-6579-4cfc-91f9-347274f7486e"), "dhaka_savar", "Dhaka (Savar)", 2, new TimeSpan(0, 2, 0, 0, 0) },
                    { new Guid("feb7779d-3e65-41ed-a0cd-3aa8b6eca05c"), new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a"), "kushtia_mojompur", "Kushtia (Mojompur)", 1, new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "BusId", "RowNumber", "SeatNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("008868c7-bab5-4212-9dd1-2476ceb7feeb"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 7, "G1", 0 },
                    { new Guid("018c7b19-8f39-47ad-bbb2-b2dc9869c924"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 2, "B2", 0 },
                    { new Guid("030695d0-9774-4351-8951-614779cc552e"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 10, "J3", 0 },
                    { new Guid("05db311a-76bf-46c7-b84e-754afd543593"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 10, "J1", 0 },
                    { new Guid("06571603-983e-404f-8121-cbeb4bdffb40"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 4, "D2", 0 },
                    { new Guid("06986ef9-8e5d-4e8f-9dcf-e9cff310ffe2"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 1, "A3", 0 },
                    { new Guid("0702ae09-59d3-45b1-979b-b650c82acbe6"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 7, "G2", 0 },
                    { new Guid("07e869f4-145b-4eac-b840-cce4e724e48a"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 3, "C1", 0 },
                    { new Guid("08599db2-a7da-40d3-83f3-d47bbe853a71"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 3, "C3", 0 },
                    { new Guid("098dbc37-8001-4aec-9d3c-8e6fde08e1bd"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 2, "B2", 0 },
                    { new Guid("09a55095-4bc2-4b03-a3f6-90b27ebc7ea7"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 2, "B3", 0 },
                    { new Guid("0a161b60-0f78-4968-b9c3-a075de4957c9"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 4, "D4", 0 },
                    { new Guid("0b7a62cb-4b85-45ce-ad41-a1e1ba800aba"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 8, "H1", 0 },
                    { new Guid("0b843d24-eddc-46d9-9eec-dec81b56c618"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 3, "C2", 0 },
                    { new Guid("0bd3474b-48e0-418c-8079-c537440138dc"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 2, "B1", 0 },
                    { new Guid("0c281bd8-6641-410f-88ff-d7e4f50fbd3b"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 1, "A4", 0 },
                    { new Guid("0d34fbc5-8199-4ce3-994a-693ab7992b96"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 9, "I1", 0 },
                    { new Guid("102c0510-2357-475a-8580-b4fc886416e7"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 4, "D2", 0 },
                    { new Guid("11ad2990-648c-4345-9241-4ee53296b293"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 5, "E4", 0 },
                    { new Guid("12891b4f-54c9-40cf-9e1c-07d0aa1174b2"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 5, "E4", 0 },
                    { new Guid("131a809d-dc97-4254-a963-06226c89cd5f"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 2, "B4", 0 },
                    { new Guid("1377b294-1a8d-4f42-bee7-8c3ad257041e"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 5, "E1", 0 },
                    { new Guid("1470011e-4311-49cd-a61e-a4e61171b8c3"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 5, "E4", 0 },
                    { new Guid("15d8746c-e224-4040-a6bf-fcedaa873708"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 4, "D1", 0 },
                    { new Guid("16d0e123-1134-4c2b-a4e4-bbde7368009d"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 7, "G3", 0 },
                    { new Guid("181251e0-4ff2-4b31-a10f-6419b6673743"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 4, "D1", 0 },
                    { new Guid("18a9c720-87ed-4066-b2c3-a5d04a0dbf67"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 7, "G4", 0 },
                    { new Guid("18fa93ca-e8e9-4b73-ad54-686bdd83722c"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 4, "D4", 0 },
                    { new Guid("1d2339fe-150c-46d9-9614-e0900e2b2c73"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 7, "G1", 0 },
                    { new Guid("1e48d6bc-7f0f-4b93-86f4-1df27d2a380f"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 1, "A3", 0 },
                    { new Guid("1eff0233-ca8c-4997-85fc-86c31eebe28d"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 6, "F2", 0 },
                    { new Guid("201f66b6-1e47-445f-af2b-21ff1b23f255"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 7, "G2", 0 },
                    { new Guid("2071c976-6a59-4f34-9298-5cf6f42c5e0e"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 1, "A2", 0 },
                    { new Guid("2142d572-52c9-40da-8791-3b963639cd50"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 6, "F1", 0 },
                    { new Guid("26b96aa8-5207-4460-9af5-78b99c1d3d71"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 6, "F4", 0 },
                    { new Guid("26e49a1f-5f27-43f6-bcc9-ec47c6f57d08"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 1, "A4", 0 },
                    { new Guid("26f0056a-c35b-478b-bf05-77b47ac162f7"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 7, "G2", 0 },
                    { new Guid("27a13208-0065-490a-ab17-a3145a23dcda"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 2, "B2", 0 },
                    { new Guid("28510b82-8c9a-4a4e-a98f-bb133b0046a5"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 4, "D2", 0 },
                    { new Guid("2a36c625-1947-43a6-99b9-1c91a14fa7a2"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 1, "A1", 0 },
                    { new Guid("2ab9520c-f77f-40f4-b919-266471458098"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 7, "G4", 0 },
                    { new Guid("2d48ff52-e74e-4875-b810-25c1380f4027"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 5, "E3", 0 },
                    { new Guid("2f2bd528-83c4-43ca-acf7-c9a039a57825"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 8, "H2", 0 },
                    { new Guid("2fc0c95f-a8f7-49ff-8abd-f4556b81c26e"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 6, "F1", 0 },
                    { new Guid("304c6511-2ff6-45bd-acce-d0267b7d58fa"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 9, "I2", 0 },
                    { new Guid("30de677f-5e7e-436d-8c35-a24e6e0f0070"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 7, "G3", 0 },
                    { new Guid("312103cf-0e35-4fbc-b147-d4c74b50752f"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 10, "J1", 0 },
                    { new Guid("3168a6a3-4696-4f3a-a75c-0594b910b30b"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 2, "B1", 0 },
                    { new Guid("32d1c58b-338a-46c7-ab34-3a3729565d45"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 9, "I4", 0 },
                    { new Guid("33cfbb9d-e415-41e1-82c5-ad12a6d809ca"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 5, "E3", 0 },
                    { new Guid("34f7cc82-b9b4-4788-bc10-16cc163dd540"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 1, "A4", 0 },
                    { new Guid("38ac85e0-f86b-4ff7-83da-303d7d9111dc"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 4, "D4", 0 },
                    { new Guid("399db65f-36c9-41a4-a05c-642411f01944"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 2, "B1", 0 },
                    { new Guid("39ce283a-f218-4005-bf7f-0876cdd9d8d5"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 4, "D2", 0 },
                    { new Guid("3b3a8530-a4aa-48ca-82ec-631888b9d13f"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 4, "D3", 0 },
                    { new Guid("3b46809a-472b-423f-bdfc-cf2e3f45e06c"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 3, "C4", 0 },
                    { new Guid("3b64bf1c-02d8-4c1a-a1b1-39c983610359"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 2, "B4", 0 },
                    { new Guid("3b7ee995-3fb0-408a-95a1-b97ba99b3d22"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 2, "B4", 0 },
                    { new Guid("3c50298a-1c7a-4d76-8398-22a5496cd8c9"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 4, "D1", 0 },
                    { new Guid("3c87a823-d4a0-449d-a731-fadddc0ec188"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 3, "C4", 0 },
                    { new Guid("3d4cd82b-407c-42eb-b282-61c7097df311"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 1, "A3", 0 },
                    { new Guid("3d5102c6-4d7c-437e-8ceb-6dc54b9d3582"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 8, "H4", 0 },
                    { new Guid("3f66b79b-f01f-4d19-adb4-191d89f475e2"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 4, "D4", 0 },
                    { new Guid("413283e3-d381-46fa-8afa-2ae7e483ef47"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 9, "I1", 0 },
                    { new Guid("4221d8ea-b712-4b47-b0ca-4d22457f3899"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 4, "D3", 0 },
                    { new Guid("426cfe3e-9382-4d3f-a3e5-a8a72d63b95c"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 5, "E3", 0 },
                    { new Guid("4315e8f4-9012-4178-a9a9-92dffc328cd9"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 1, "A4", 0 },
                    { new Guid("432ac49c-1e08-4a83-b9c4-618081a4b641"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 6, "F4", 0 },
                    { new Guid("437fc1c6-68e2-433a-9b73-285c323a76a9"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 6, "F2", 0 },
                    { new Guid("450796e7-3114-41a0-89d0-cf5dce9cee6a"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 4, "D2", 0 },
                    { new Guid("454aa1c3-60f9-4002-9ff7-2957acb8f41c"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 4, "D3", 0 },
                    { new Guid("497c11c6-5381-4360-8b1f-1c9b6e260831"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 1, "A4", 0 },
                    { new Guid("4aab2902-be6e-4fc9-9727-97f355d27cf7"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 6, "F3", 0 },
                    { new Guid("4ad386e3-bf99-472e-a67d-20e726465e10"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 6, "F3", 0 },
                    { new Guid("4bfdde8c-f385-466b-b564-7730b23b92f1"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 3, "C3", 0 },
                    { new Guid("4c82b704-9156-4bb0-97e5-5e05684a3ba7"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 3, "C4", 0 },
                    { new Guid("4f98a86d-77fe-4fc7-9eb8-9c8973a343ce"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 9, "I3", 0 },
                    { new Guid("5090cebb-148c-4ebd-88c2-cd81ef6c146e"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 3, "C3", 0 },
                    { new Guid("517474ec-71a3-4539-ad2b-ef50266d28cf"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 11, "K1", 0 },
                    { new Guid("5381fde8-b89b-4072-a804-f4f0b328f875"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 6, "F4", 0 },
                    { new Guid("549617c3-91d3-424d-8abd-6dd2b4de815d"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 3, "C3", 0 },
                    { new Guid("551c0d3c-0900-401d-ba2d-4278d0831a95"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 3, "C1", 0 },
                    { new Guid("5630fe1e-e137-4603-bf38-3ddaebb3cd62"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 1, "A1", 0 },
                    { new Guid("57000026-2303-4498-b702-b596afe16cc3"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 2, "B2", 0 },
                    { new Guid("57630f7d-fd12-45b0-82fd-a274f8e4581d"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 3, "C1", 0 },
                    { new Guid("58e8f383-0cca-4877-8184-948c495548c5"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 7, "G1", 0 },
                    { new Guid("59559832-eac5-4dcf-b4e1-63488b6bc8ed"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 2, "B4", 0 },
                    { new Guid("5a5eaa9c-8a4d-442f-a432-8afaa5c7b0c1"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 11, "K4", 0 },
                    { new Guid("5b2826c2-cb67-4437-ada2-984673575687"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 1, "A1", 0 },
                    { new Guid("5d22862d-3975-49b6-be1c-036a0193c53b"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 5, "E1", 0 },
                    { new Guid("5ddaf06a-178e-4112-85b0-eb11b7cd9897"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 7, "G4", 0 },
                    { new Guid("5fa95d42-12d0-47f2-a811-dff4bf510510"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 5, "E2", 0 },
                    { new Guid("5fd2be2f-aa86-43a7-b91f-d97a985f29c0"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 9, "I2", 0 },
                    { new Guid("6193c8bd-e1ca-4bd1-a0de-d463382e8217"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 6, "F4", 0 },
                    { new Guid("63c3538b-5262-4c74-bb04-3a64dc2d6f0e"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 5, "E2", 0 },
                    { new Guid("646e8dec-1db2-4c66-a125-ca90408dff8b"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 7, "G3", 0 },
                    { new Guid("6654ba82-87d7-477f-b92b-9d05b90adff4"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 5, "E1", 0 },
                    { new Guid("666b2d9b-9213-417d-9421-9a8295ebf85a"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 1, "A3", 0 },
                    { new Guid("6a99f71a-ef56-4f9c-8cdf-d35a9ececad1"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 9, "I2", 0 },
                    { new Guid("6e8e7b5b-2977-43f5-a4a5-974d1f2d424f"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 4, "D1", 0 },
                    { new Guid("6f1daa02-be34-4cc4-90bf-80ec721bdf68"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 7, "G1", 0 },
                    { new Guid("71034bd2-eb80-4086-bc06-1c6d84d2a5d1"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 3, "C4", 0 },
                    { new Guid("72249e46-908b-4bc8-9265-41ae81a80e61"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 8, "H1", 0 },
                    { new Guid("743680ce-5a77-4f67-b109-16fbf2b16f7f"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 8, "H3", 0 },
                    { new Guid("75749893-7f5f-4f41-9c12-0de1da9d5648"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 5, "E2", 0 },
                    { new Guid("7672f571-4177-4046-83ea-6250d53f78bc"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 3, "C2", 0 },
                    { new Guid("77e14805-35f5-4a75-8fbd-7a9c60972f24"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 5, "E1", 0 },
                    { new Guid("783cd025-578c-4e69-b5c0-b0a8fb9f03e2"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 5, "E1", 0 },
                    { new Guid("7919d3de-2e60-4ef4-9b72-3933b8eae927"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 7, "G3", 0 },
                    { new Guid("79fae71a-023f-4f0d-871f-5bb536655305"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 3, "C2", 0 },
                    { new Guid("7a1623ed-d8fa-4288-83d5-961e05ab770e"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 2, "B1", 0 },
                    { new Guid("7a4163e6-7c22-4ea0-8b14-3d10c02e11ad"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 3, "C2", 0 },
                    { new Guid("7abf95b1-1a15-459a-9392-5c9c426d62d7"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 7, "G2", 0 },
                    { new Guid("7b04871c-4777-4b82-be2c-7133cee42c67"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 8, "H1", 0 },
                    { new Guid("7b4435d8-bb0f-4b30-af2e-b80f0456bc1c"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 1, "A2", 0 },
                    { new Guid("7cccc28c-fc3c-4766-9a59-575506581142"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 8, "H3", 0 },
                    { new Guid("7d6685e5-b0c1-4dbb-be3f-de356d9dcd81"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 8, "H3", 0 },
                    { new Guid("808ae88a-56f1-42db-af20-1262185d626a"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 6, "F4", 0 },
                    { new Guid("842196eb-c2d2-437e-8dd5-f3a3ca33a131"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 3, "C1", 0 },
                    { new Guid("8469e3a3-177c-497a-a2cb-9902841e0567"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 6, "F4", 0 },
                    { new Guid("84b9017b-878a-4648-aa48-90179fc66ac4"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 7, "G4", 0 },
                    { new Guid("86adb1b7-8dd3-4931-8991-1ea3a100e1c9"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 5, "E4", 0 },
                    { new Guid("896c6a55-46c4-4ab1-be66-0d4fb6ed55e8"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 8, "H2", 0 },
                    { new Guid("89741bb9-fab8-449f-a87f-94454ac5c8a3"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 7, "G4", 0 },
                    { new Guid("89edc4ee-99df-496b-bb70-b5075c7c78c9"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 1, "A1", 0 },
                    { new Guid("8b66d70b-6ed7-44dd-aabb-6aec6e91b830"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 6, "F1", 0 },
                    { new Guid("8b772457-c6e5-4ee5-9634-9a5f24057bd4"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 9, "I3", 0 },
                    { new Guid("8c6f620a-c5d3-44c0-a8ab-40d8b27f1799"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 6, "F2", 0 },
                    { new Guid("8d3c8cfb-0d71-407e-9a35-83b75a9efd04"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 7, "G1", 0 },
                    { new Guid("8d663a2c-9de8-40a1-8ee0-93ac08149e88"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 6, "F1", 0 },
                    { new Guid("8db030af-eca1-460a-a2d8-ed0cd19cc64a"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 9, "I1", 0 },
                    { new Guid("8dc485be-32e2-4727-9a15-d0ef729fae6b"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 2, "B4", 0 },
                    { new Guid("8ee09718-3274-4515-ab3c-5bc18a0845dc"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 5, "E3", 0 },
                    { new Guid("906e40de-4b54-4d5a-8a3d-61195b3628c1"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 1, "A3", 0 },
                    { new Guid("911a403e-78e3-4d6a-bd67-66d8cb4aee97"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 6, "F2", 0 },
                    { new Guid("927ce8e4-ec56-4010-9889-c9945e4419a8"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 9, "I4", 0 },
                    { new Guid("9694c8de-3755-4297-8032-af7f67a41769"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 2, "B2", 0 },
                    { new Guid("972390f6-5658-49bb-91f5-58c10a193380"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 3, "C4", 0 },
                    { new Guid("996b89c2-3a3f-4e09-89c3-af90c6f0562f"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 6, "F3", 0 },
                    { new Guid("9c2388ff-4a31-46cd-acc4-6da533da636c"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 2, "B3", 0 },
                    { new Guid("9cfad200-3c91-49c5-92e3-ddb62b42e8fd"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 2, "B3", 0 },
                    { new Guid("9d1f7d28-ce68-4030-8fb4-0db71f279a0c"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 1, "A4", 0 },
                    { new Guid("9ea598cf-4065-46e2-bfa6-936bb1e66ceb"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 5, "E2", 0 },
                    { new Guid("9fa4488b-6ebd-43cc-8c8f-2730fda865fe"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 9, "I2", 0 },
                    { new Guid("a0512f05-cb62-4dad-80c1-1b03eb39037f"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 2, "B1", 0 },
                    { new Guid("a29d8cb0-8ead-46ad-a921-2d7e7bd16b01"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 8, "H4", 0 },
                    { new Guid("a2bdd749-b9f5-4159-881f-06b9918c7967"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 3, "C3", 0 },
                    { new Guid("a5356b0c-bdd1-46e7-830e-d7336868ab14"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 7, "G1", 0 },
                    { new Guid("a6d19931-f6b1-43ed-b2ee-c704d097259b"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 3, "C3", 0 },
                    { new Guid("a9160cf2-6ae4-477d-ac96-fef2feee6fd8"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 8, "H4", 0 },
                    { new Guid("a9483cc5-4629-4f09-8628-f85819b4b578"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 5, "E3", 0 },
                    { new Guid("aac0fe0d-e543-448e-8391-7825b6cbd310"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 2, "B4", 0 },
                    { new Guid("aaee1ae4-e1c4-4366-9177-72476fc24040"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 7, "G2", 0 },
                    { new Guid("ab9ced04-8923-4fa8-a1d8-19099e05d5d8"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 5, "E4", 0 },
                    { new Guid("abade14d-f1d8-49a6-8d7e-7abf1ec7e9f2"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 3, "C1", 0 },
                    { new Guid("ac0ba0eb-a1ff-42c5-ac91-bcd6b13f6401"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 6, "F2", 0 },
                    { new Guid("ac4a453f-66a9-4299-80f9-d2ae61924930"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 3, "C2", 0 },
                    { new Guid("acc3d834-f14e-41fa-8a2d-cda99f7cd193"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 7, "G4", 0 },
                    { new Guid("ad9ccb12-8d07-4e7e-b6a0-c660149b6d4f"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 8, "H2", 0 },
                    { new Guid("adcef931-39da-4254-8980-959a7a5f92b1"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 1, "A2", 0 },
                    { new Guid("b2636ad9-009d-4a27-bf20-023394887c3c"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 6, "F3", 0 },
                    { new Guid("b2cd32f7-c04a-4749-baf6-ad7763178a52"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 10, "J4", 0 },
                    { new Guid("b2d3aebe-573d-4d05-830f-17d98a95ce74"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 4, "D1", 0 },
                    { new Guid("b3680260-0f82-4dcc-936b-f151fa2c240b"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 9, "I3", 0 },
                    { new Guid("b4c28195-d55b-46ee-9db7-0ff18bdd3adc"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 2, "B3", 0 },
                    { new Guid("b87277a7-48af-4fa8-a611-77ca34cea8a6"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 9, "I4", 0 },
                    { new Guid("b946b661-e517-44b0-8d5c-4fca7bfd6033"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 8, "H2", 0 },
                    { new Guid("b99d4538-ce19-46f9-b8bd-edfa71d56d86"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 4, "D4", 0 },
                    { new Guid("bb5758f0-61d0-4286-a49d-f0ce07415dc6"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 6, "F1", 0 },
                    { new Guid("bc713ed8-5cc8-41eb-bfeb-c7edb73be86a"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 6, "F1", 0 },
                    { new Guid("bcab7030-0886-47ee-825a-cdbca6aefea2"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 4, "D1", 0 },
                    { new Guid("bcc95a93-1443-4dfb-ba0e-450e6716f7f6"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 2, "B1", 0 },
                    { new Guid("bd2c5a3b-9474-41e1-a04c-d7161d706b6d"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 2, "B2", 0 },
                    { new Guid("c16b8479-3313-4f4c-a622-a3fc21a7b2d0"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 1, "A2", 0 },
                    { new Guid("c3d1c83e-1315-4d7b-a68a-af7bb4697180"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 5, "E1", 0 },
                    { new Guid("c44bb267-bbfd-4ffc-86f1-5fab1a70dee8"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 10, "J3", 0 },
                    { new Guid("c570df51-4542-4cdf-ac1f-689de2efb8f6"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 9, "I4", 0 },
                    { new Guid("c725d096-c21b-4dc7-aab2-28c9df0366dd"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 8, "H3", 0 },
                    { new Guid("c771f17a-968e-4e82-a517-a0d5382cba02"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 8, "H1", 0 },
                    { new Guid("c906f389-1356-4efe-bd9d-f564d39455be"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 10, "J4", 0 },
                    { new Guid("cbfe2f67-f49b-43fa-a524-d4bde24a06ca"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 8, "H4", 0 },
                    { new Guid("cc826121-d102-4c6a-aaaf-afc199fadef1"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 4, "D3", 0 },
                    { new Guid("cd3d2ca7-ad5a-4c32-b665-44086b7e71ff"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 10, "J2", 0 },
                    { new Guid("cd82bf4b-f583-4a4a-86cb-43f6685c460f"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 4, "D2", 0 },
                    { new Guid("cf7039aa-1d2f-4fc6-8a2e-1929df23ef84"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 10, "J2", 0 },
                    { new Guid("cf972822-e03f-45bc-9188-163edab515fe"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 1, "A1", 0 },
                    { new Guid("d418680a-53ed-4158-8e06-82d4caea6714"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 1, "A3", 0 },
                    { new Guid("d4cc0e00-043d-496a-8edd-3d5f9c420b4c"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 4, "D3", 0 },
                    { new Guid("d53ddae4-33c7-4cd5-b7f1-769959f00eee"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 3, "C2", 0 },
                    { new Guid("d54bc185-1b15-448b-b66e-826d458c3fb6"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 8, "H3", 0 },
                    { new Guid("d62c50f0-7298-4a18-8896-02708ce97f42"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 3, "C4", 0 },
                    { new Guid("d674f1ff-ebe6-47b7-a7e0-5e53106e9459"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 11, "K3", 0 },
                    { new Guid("d68d32d6-b08b-4f6a-8f74-972e5574fe57"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 6, "F2", 0 },
                    { new Guid("d8ff66ef-7b1e-46c7-a91e-5698319e5936"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 5, "E2", 0 },
                    { new Guid("dab1d296-65c2-4955-80bc-4d6ac2f820c0"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 5, "E4", 0 },
                    { new Guid("dc0fbee4-e6ee-4132-af07-7fce03f4decc"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 8, "H2", 0 },
                    { new Guid("deab5f73-30a7-4b02-8ce7-987d4c6127c7"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 9, "I3", 0 },
                    { new Guid("df3269b4-85c4-4da0-b878-2c5aaa5518aa"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 7, "G3", 0 },
                    { new Guid("dff815e9-0002-4643-9b41-6f4eeaff3735"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 8, "H4", 0 },
                    { new Guid("e01f2a48-53e4-41f0-902d-f11d2affa735"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 5, "E3", 0 },
                    { new Guid("e07070a4-0b05-4a20-b7cb-29f39256da6a"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 1, "A1", 0 },
                    { new Guid("e0f73fcd-9a90-4700-bc4b-0c65151aaa30"), new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"), 7, "G3", 0 },
                    { new Guid("e31cdfca-d7c5-4ec7-a62a-114292be5557"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 4, "D3", 0 },
                    { new Guid("e400f73a-2327-44ae-991f-ff5ef66852d2"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 1, "A2", 0 },
                    { new Guid("e9bff46d-c91b-4087-89e9-013632ce6c47"), new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"), 4, "D4", 0 },
                    { new Guid("eb4eaa45-f3ae-415a-b1aa-96559b20cbd5"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 2, "B3", 0 },
                    { new Guid("ef52afda-44cc-4a50-807b-fc9f063107e3"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 8, "H1", 0 },
                    { new Guid("f535347e-5896-4f80-8973-7fb275f5e0b1"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 9, "I1", 0 },
                    { new Guid("f6601748-290f-4710-b27e-7a8e17054561"), new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"), 6, "F3", 0 },
                    { new Guid("f6becd03-2329-487e-8d4a-80df6ac593cc"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 6, "F3", 0 },
                    { new Guid("f80f8c68-3f47-4d08-92fd-95fb8811e993"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 2, "B3", 0 },
                    { new Guid("f8fe31b4-f722-46da-99d6-7b9cefb52001"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 5, "E2", 0 },
                    { new Guid("fc92f6ed-c65e-4bd1-bbad-c95e414dcb48"), new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"), 1, "A2", 0 },
                    { new Guid("fdb2c813-d564-4ca9-b270-642249e1aeb9"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 11, "K2", 0 },
                    { new Guid("fe5112a8-f4e4-4f8a-a2ab-fa263c9f68ee"), new Guid("348b5e6e-af25-4844-8907-689752f6dddf"), 3, "C1", 0 },
                    { new Guid("ffa3ee43-86f4-4c34-adfc-2fec132da069"), new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"), 7, "G2", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0013897a-99cb-41af-b02e-a338e4d5ac37"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("00ab8b56-7fff-4a73-a867-64a9c75c8829"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("01b95170-4242-4170-88fc-8921719fa800"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("04f48998-a514-4e2d-822b-f7aab9e889b2"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("05c42bd1-a1c7-4868-9f4a-46527c660d60"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("06002804-672d-450e-9891-2cb88dd8a947"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0737e688-24a2-4093-af21-4e09bd382921"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("077677e5-0e15-43a3-920e-81480d868abf"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("08d33076-885a-45b4-90f7-84d6c910e420"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0bd8b0c6-8fd1-48cf-ae96-5634bcf5e2bb"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0e8126a5-a59c-44bb-bf8e-7f2b745c5386"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0ee0d059-5f55-41ac-994c-5bbb5b04670b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0ff908e0-27d2-448f-8571-9068641f45df"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1038a8f5-5457-41f4-94bd-f8ab719e7b2f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("12653b3c-72cc-4ccd-a638-ce827b2d3c2d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("13703625-5fe9-4052-a2b2-5a46559c190b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1460d031-5ca9-47c2-926d-8563b5b292f9"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1538f25b-4657-4a73-9032-16bd89f7df81"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("168c7b35-08a3-4a35-acf0-b3ab848fc0d1"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("16d1d80b-f4b3-4f44-a8a7-b68bcd668f6c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1b38d27e-17ae-4e79-91e5-655900adcd3f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1ca70e8f-2777-4259-a75d-f117db4596ff"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1d520cd3-0f35-456d-a766-37ba2bd0e041"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1f3d5d76-44d2-4698-b639-b1ba3d8eaf1f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1f710794-ea46-4ce7-9b8f-d957cb32c039"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("20f1f7e1-b3c8-4d90-b834-96bdf01f3cc2"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2237003c-3669-4fa5-8bdc-0b68dd92716d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("22b2f509-9ed8-418c-91c5-e193961193b3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("23a39fb2-fbb7-492f-b264-65c49905524e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("290f457d-9987-421f-ae8e-526500c76fe3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2ae2c740-6063-4433-b805-9ab2a8c03ec3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2bd15095-da5a-4522-9bfe-b476f1286ee2"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2bd20ff8-82e9-40c8-98bc-c8c90b742df6"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2bea26eb-6904-4ed8-9b11-34ba8f6ee215"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("2dda8452-2a8c-4fea-8620-f8095facf336"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("314e894e-222a-4d56-a948-4852b14cd42a"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3162818e-a1b2-4aec-b985-e23bfb181348"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("31fb066e-b81f-4da7-8d10-2244b3ff55fe"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("359865fe-bf0c-45dd-aeb5-5ece9b71d512"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("370c8109-26be-495d-9263-a7173ac110ef"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("39e70c59-3b92-4769-afc9-0a673367077c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3b0ef97e-1b03-47be-b2ee-2fac0cd0dafe"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3ecba312-0de6-46ed-ab54-dff90c71f265"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3f3af808-7a19-4665-9ad6-cb6fcd42b179"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("40e749de-e686-4b4b-992b-908d68b47ad3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("41bb6e2b-3ab5-4efb-b5a5-012c3556d71f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("41e2e649-9490-4d7e-ac77-1ec2f5e678d3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("4271cb7b-e679-456e-81dc-6e1b2ff96a1f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("442a9bd9-4a20-4f8e-8243-94f5bfbe40a3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("4546fac3-576e-41ec-b917-0ec6c429fafd"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("48d98c8c-5c65-41d9-8f9c-7ef56c6821da"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("494eba4b-a068-4335-a74a-ce133c2cc34f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("4a79bdf7-9ae0-427f-a084-1ceaff209d82"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("4d0187f4-2610-4a61-80ee-f7712c1d822c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("4d24a870-27af-4392-a1da-ec9ffe643d64"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("4dea23f2-8514-4d65-8d79-fe0812c0c8ce"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("51f0db8c-0df6-4a43-a3b0-46c37969a2d7"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("56f0ff49-5d2a-433c-803c-7719958a3714"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5a5131c1-7d75-4ed0-a1f1-6356a17d0980"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5ae2c117-d913-4b58-adad-0f7b9de4cbd0"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5c2dd318-f402-40c4-b03e-70385313dd1d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5d260c75-4bb0-4c70-b5df-fff440d8753d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5e7a8686-78ee-4cd8-8d7b-dd5456d76af3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6397f707-2733-4187-8cfe-2e29d63612b7"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("69f2c0e9-58f2-48ea-a6df-f2c1e8a77d0c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6d4d514a-32f4-4819-8290-95d176369dd6"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6e5d8d96-fdb5-4964-9706-04c54c839775"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6e8d8caf-f461-4972-ac6e-d9ccb9f0ca4b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6fd597d8-6a3f-4176-baab-2949b43d6735"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("73cc6607-4719-4264-814b-ec8605f293bd"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("74c896b6-b5b8-416d-a46a-b0098eff2d0b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7832fac3-50dd-4a39-bd5a-5b26f349feed"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("79aef723-8e72-4765-a0c5-b67f67e6dc99"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7a74c9e5-0161-426f-8a81-1ce4394af835"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7d90e6a7-b808-4fd1-b113-721cd4717203"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7e526f5a-f586-4185-a0e4-6681a5971d75"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7f3393ac-cc65-4331-b7c5-e66dbca63831"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7f6ef402-a3df-4e14-bf6f-a1f31ce00fc0"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("80f83b2e-26d1-45d6-a918-fb33d91fb67f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8119ab5c-77cd-4c99-9ce0-dc805624ca8d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("82038148-b05f-417a-b5ff-26d1fa77da1f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8215828c-ce0c-410c-a04a-15319da0326e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("832e0248-62ff-40b0-9d40-a9d1af171476"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("84199f32-51af-4ec9-9697-82ab937054f6"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("841b01a3-d573-4d76-9add-0f2543cb2eaf"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8586e137-e23a-4c8c-9ae5-539789314d6d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("88be9b32-2916-455f-97f1-5425abd9a15c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8b59a0cc-e0a3-4360-bc22-a7f8efdde662"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8c8c332e-a4f3-4882-99ec-814ce278c1b7"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8c9879b3-89f3-4354-aca4-adfc9f32bde4"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8cb20c8c-4353-4308-89a0-4dfcd11ba8b9"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8ed44aa8-68b8-4834-8c0d-672b1b3cedde"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("92b28654-f063-4568-867e-9e708c47007c"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("9a0ef29a-065e-4bd3-a0c3-62e57bbbb285"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("9a5b69d1-4229-4e47-b80b-11edb2602195"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a04dc015-5177-41f0-9fac-ef8426fc9cf7"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a0c8f740-04f3-48ab-ae40-6ddec811258e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a2b41cd9-635e-4f14-be84-386bf7e47bd0"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a31c5e1b-aa75-4d3f-ada2-20b757d28bf0"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a4dc0c6a-0fb5-4eb1-9c6f-70df13df0367"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a5d9f1b6-9f89-4280-86ec-b02850a37090"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a73b5e0b-645d-49cb-898a-ee1927100c85"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a9c479bc-4ea4-4032-b116-a2e92582c332"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("aa971a86-b164-4359-af14-0482af406c49"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("abc03b4c-cca4-48af-928c-47c8f9cbfdcf"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ac600135-0e03-4822-84ac-1ee7ee3e08bb"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("aea2c5e6-8c9e-4110-9f23-74f4d8e5ff65"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b0d312d8-196e-4c4d-9cb3-fd6cc9fea4bc"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b130046f-9d99-4bf7-90bb-1f0bacba9a3e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bc168ec9-df31-4cc8-bdac-d44c27985151"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bd40e345-9488-446b-a66e-6f26999275da"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bffa205d-88cf-4a4f-ac67-45918be47372"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c14839ea-9cf6-4dd2-96cc-e1f964fc70f0"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c3cb42a8-77b3-42d4-b9fa-54314970466b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c586f211-2c7a-4b13-b2d2-598cb1674309"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c6d2d2f3-c813-42a1-a195-359649da7979"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("caaa1d62-d641-4893-a6bb-203b78cec1ef"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("cb64329a-90bb-423a-9325-e2882407f34a"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("cdb7ff7b-7e68-4dcb-9781-7eb0998190a7"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ce2e2750-02e9-43a4-985b-c4531f4a7281"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("cf508092-615b-49a5-923f-e489ffd5c8a5"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("cfab1391-23b0-4e6b-9ee1-79a4cf83561d"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d0d28517-0ad2-40e3-ad9b-9a2a260aa099"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d0f10a83-a563-4776-a0cb-e51055b4fc1e"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d14ef16d-03be-439c-b9e3-c06c9442a98b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d2d58c65-7f03-4af1-a655-1484e2f698e7"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d363fa0c-aec4-4152-ba49-af0b0c4c53bc"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d3fd0f84-5613-4bd9-8ede-9fa496b430cf"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d6105b80-ac5e-45f1-86f2-64d36317ff18"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d6c042f4-8455-4c13-8fca-fe6c7c649775"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d8409ace-7ffa-477f-adf2-403e9835891f"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d993a653-9413-4718-b805-8418b53a59c9"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dacb40e4-9d14-4877-8fac-0e0a9a2b507b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("daf68367-a390-4df1-a6f2-a4ac342a5f36"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e122f703-262d-4b52-b920-81c5156ab261"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e1b32b84-7544-4bb1-9ad1-2694e63adba5"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e5129caa-be29-4c64-b827-debcd4d54392"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e571e6bc-c9c5-4c74-91f6-39068600bd41"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e7f5574f-371e-4c68-a6ab-4d6a446034a6"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ec4784a5-9a30-4b23-9883-f29d8c2ee548"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("eee3771d-e00e-461a-8846-6381dfd24130"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f1af71cd-181e-4a37-9294-f8e0eaffc850"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f206d04b-70dc-4f69-ac3b-f7c161c38ab3"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f5d92f1d-815e-40cd-8bc2-b8cc7978c8ad"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f69c141c-ebc8-4ebc-881f-62ea05df0a9b"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f7c16c40-1d3d-41cf-aaab-17745735f5c9"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f9e7209d-c3c1-4fea-b203-27ce600b1625"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("fb438fc6-c6a0-48b5-8cc7-654206a64629"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("fe8a4bac-8f1d-43f4-87f3-ab63a1a01186"));

            migrationBuilder.DeleteData(
                table: "BusSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ff45e5cb-f319-4294-a4b4-5dc15278429e"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("1d02a383-455b-4573-958e-c6ec7f10be7a"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("2123defe-4758-4414-8605-8c87fee3cfb9"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("25b54f58-0612-44ab-8079-d916a1ec4944"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("35a26008-9a00-45d1-ad8d-c7a29a2f42d3"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("368356a2-0584-4cd2-92ab-3c100b1f8c36"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("579339ac-01de-473c-92ab-667047a3c3f3"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("70cc0370-fa97-44cf-8b49-1da034a3e44a"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("77f75f1a-2daa-4642-9a38-3c31553c529e"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("87e449f3-877b-40ab-b82e-d578c29908c5"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("8e687827-d97c-4a22-8bea-6524061db1f5"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("ae691172-42aa-49e2-bf1f-2f88f99f53ca"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("b075bec6-db7f-4138-bc31-bde4a22e54bd"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("d17ef4d1-0463-4f51-9fb6-a22da703e531"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("ef23f603-e7ab-42be-afc2-f5d446778195"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("f1a3163c-59d3-4f0f-8edf-b9b4daf869c4"));

            migrationBuilder.DeleteData(
                table: "RouteStops",
                keyColumn: "Id",
                keyValue: new Guid("feb7779d-3e65-41ed-a0cd-3aa8b6eca05c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("008868c7-bab5-4212-9dd1-2476ceb7feeb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("018c7b19-8f39-47ad-bbb2-b2dc9869c924"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("030695d0-9774-4351-8951-614779cc552e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05db311a-76bf-46c7-b84e-754afd543593"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06571603-983e-404f-8121-cbeb4bdffb40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06986ef9-8e5d-4e8f-9dcf-e9cff310ffe2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0702ae09-59d3-45b1-979b-b650c82acbe6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07e869f4-145b-4eac-b840-cce4e724e48a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08599db2-a7da-40d3-83f3-d47bbe853a71"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("098dbc37-8001-4aec-9d3c-8e6fde08e1bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09a55095-4bc2-4b03-a3f6-90b27ebc7ea7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a161b60-0f78-4968-b9c3-a075de4957c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b7a62cb-4b85-45ce-ad41-a1e1ba800aba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b843d24-eddc-46d9-9eec-dec81b56c618"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bd3474b-48e0-418c-8079-c537440138dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c281bd8-6641-410f-88ff-d7e4f50fbd3b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d34fbc5-8199-4ce3-994a-693ab7992b96"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("102c0510-2357-475a-8580-b4fc886416e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11ad2990-648c-4345-9241-4ee53296b293"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12891b4f-54c9-40cf-9e1c-07d0aa1174b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("131a809d-dc97-4254-a963-06226c89cd5f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1377b294-1a8d-4f42-bee7-8c3ad257041e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1470011e-4311-49cd-a61e-a4e61171b8c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15d8746c-e224-4040-a6bf-fcedaa873708"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16d0e123-1134-4c2b-a4e4-bbde7368009d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("181251e0-4ff2-4b31-a10f-6419b6673743"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18a9c720-87ed-4066-b2c3-a5d04a0dbf67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18fa93ca-e8e9-4b73-ad54-686bdd83722c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1d2339fe-150c-46d9-9614-e0900e2b2c73"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e48d6bc-7f0f-4b93-86f4-1df27d2a380f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1eff0233-ca8c-4997-85fc-86c31eebe28d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("201f66b6-1e47-445f-af2b-21ff1b23f255"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2071c976-6a59-4f34-9298-5cf6f42c5e0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2142d572-52c9-40da-8791-3b963639cd50"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26b96aa8-5207-4460-9af5-78b99c1d3d71"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26e49a1f-5f27-43f6-bcc9-ec47c6f57d08"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26f0056a-c35b-478b-bf05-77b47ac162f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27a13208-0065-490a-ab17-a3145a23dcda"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28510b82-8c9a-4a4e-a98f-bb133b0046a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a36c625-1947-43a6-99b9-1c91a14fa7a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ab9520c-f77f-40f4-b919-266471458098"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d48ff52-e74e-4875-b810-25c1380f4027"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f2bd528-83c4-43ca-acf7-c9a039a57825"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2fc0c95f-a8f7-49ff-8abd-f4556b81c26e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("304c6511-2ff6-45bd-acce-d0267b7d58fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30de677f-5e7e-436d-8c35-a24e6e0f0070"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("312103cf-0e35-4fbc-b147-d4c74b50752f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3168a6a3-4696-4f3a-a75c-0594b910b30b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32d1c58b-338a-46c7-ab34-3a3729565d45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33cfbb9d-e415-41e1-82c5-ad12a6d809ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("34f7cc82-b9b4-4788-bc10-16cc163dd540"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38ac85e0-f86b-4ff7-83da-303d7d9111dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("399db65f-36c9-41a4-a05c-642411f01944"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39ce283a-f218-4005-bf7f-0876cdd9d8d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b3a8530-a4aa-48ca-82ec-631888b9d13f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b46809a-472b-423f-bdfc-cf2e3f45e06c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b64bf1c-02d8-4c1a-a1b1-39c983610359"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b7ee995-3fb0-408a-95a1-b97ba99b3d22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c50298a-1c7a-4d76-8398-22a5496cd8c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c87a823-d4a0-449d-a731-fadddc0ec188"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d4cd82b-407c-42eb-b282-61c7097df311"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d5102c6-4d7c-437e-8ceb-6dc54b9d3582"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f66b79b-f01f-4d19-adb4-191d89f475e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("413283e3-d381-46fa-8afa-2ae7e483ef47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4221d8ea-b712-4b47-b0ca-4d22457f3899"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("426cfe3e-9382-4d3f-a3e5-a8a72d63b95c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4315e8f4-9012-4178-a9a9-92dffc328cd9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("432ac49c-1e08-4a83-b9c4-618081a4b641"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("437fc1c6-68e2-433a-9b73-285c323a76a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("450796e7-3114-41a0-89d0-cf5dce9cee6a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("454aa1c3-60f9-4002-9ff7-2957acb8f41c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("497c11c6-5381-4360-8b1f-1c9b6e260831"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4aab2902-be6e-4fc9-9727-97f355d27cf7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ad386e3-bf99-472e-a67d-20e726465e10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4bfdde8c-f385-466b-b564-7730b23b92f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c82b704-9156-4bb0-97e5-5e05684a3ba7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f98a86d-77fe-4fc7-9eb8-9c8973a343ce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5090cebb-148c-4ebd-88c2-cd81ef6c146e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("517474ec-71a3-4539-ad2b-ef50266d28cf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5381fde8-b89b-4072-a804-f4f0b328f875"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("549617c3-91d3-424d-8abd-6dd2b4de815d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("551c0d3c-0900-401d-ba2d-4278d0831a95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5630fe1e-e137-4603-bf38-3ddaebb3cd62"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("57000026-2303-4498-b702-b596afe16cc3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("57630f7d-fd12-45b0-82fd-a274f8e4581d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58e8f383-0cca-4877-8184-948c495548c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59559832-eac5-4dcf-b4e1-63488b6bc8ed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a5eaa9c-8a4d-442f-a432-8afaa5c7b0c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b2826c2-cb67-4437-ada2-984673575687"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d22862d-3975-49b6-be1c-036a0193c53b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ddaf06a-178e-4112-85b0-eb11b7cd9897"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5fa95d42-12d0-47f2-a811-dff4bf510510"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5fd2be2f-aa86-43a7-b91f-d97a985f29c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6193c8bd-e1ca-4bd1-a0de-d463382e8217"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63c3538b-5262-4c74-bb04-3a64dc2d6f0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("646e8dec-1db2-4c66-a125-ca90408dff8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6654ba82-87d7-477f-b92b-9d05b90adff4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("666b2d9b-9213-417d-9421-9a8295ebf85a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6a99f71a-ef56-4f9c-8cdf-d35a9ececad1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e8e7b5b-2977-43f5-a4a5-974d1f2d424f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f1daa02-be34-4cc4-90bf-80ec721bdf68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71034bd2-eb80-4086-bc06-1c6d84d2a5d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72249e46-908b-4bc8-9265-41ae81a80e61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("743680ce-5a77-4f67-b109-16fbf2b16f7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75749893-7f5f-4f41-9c12-0de1da9d5648"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7672f571-4177-4046-83ea-6250d53f78bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77e14805-35f5-4a75-8fbd-7a9c60972f24"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("783cd025-578c-4e69-b5c0-b0a8fb9f03e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7919d3de-2e60-4ef4-9b72-3933b8eae927"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("79fae71a-023f-4f0d-871f-5bb536655305"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a1623ed-d8fa-4288-83d5-961e05ab770e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a4163e6-7c22-4ea0-8b14-3d10c02e11ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7abf95b1-1a15-459a-9392-5c9c426d62d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b04871c-4777-4b82-be2c-7133cee42c67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b4435d8-bb0f-4b30-af2e-b80f0456bc1c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7cccc28c-fc3c-4766-9a59-575506581142"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d6685e5-b0c1-4dbb-be3f-de356d9dcd81"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("808ae88a-56f1-42db-af20-1262185d626a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("842196eb-c2d2-437e-8dd5-f3a3ca33a131"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8469e3a3-177c-497a-a2cb-9902841e0567"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84b9017b-878a-4648-aa48-90179fc66ac4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86adb1b7-8dd3-4931-8991-1ea3a100e1c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("896c6a55-46c4-4ab1-be66-0d4fb6ed55e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89741bb9-fab8-449f-a87f-94454ac5c8a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89edc4ee-99df-496b-bb70-b5075c7c78c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b66d70b-6ed7-44dd-aabb-6aec6e91b830"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b772457-c6e5-4ee5-9634-9a5f24057bd4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c6f620a-c5d3-44c0-a8ab-40d8b27f1799"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d3c8cfb-0d71-407e-9a35-83b75a9efd04"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d663a2c-9de8-40a1-8ee0-93ac08149e88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8db030af-eca1-460a-a2d8-ed0cd19cc64a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8dc485be-32e2-4727-9a15-d0ef729fae6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ee09718-3274-4515-ab3c-5bc18a0845dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("906e40de-4b54-4d5a-8a3d-61195b3628c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("911a403e-78e3-4d6a-bd67-66d8cb4aee97"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("927ce8e4-ec56-4010-9889-c9945e4419a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9694c8de-3755-4297-8032-af7f67a41769"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("972390f6-5658-49bb-91f5-58c10a193380"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("996b89c2-3a3f-4e09-89c3-af90c6f0562f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c2388ff-4a31-46cd-acc4-6da533da636c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9cfad200-3c91-49c5-92e3-ddb62b42e8fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d1f7d28-ce68-4030-8fb4-0db71f279a0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ea598cf-4065-46e2-bfa6-936bb1e66ceb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9fa4488b-6ebd-43cc-8c8f-2730fda865fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0512f05-cb62-4dad-80c1-1b03eb39037f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a29d8cb0-8ead-46ad-a921-2d7e7bd16b01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2bdd749-b9f5-4159-881f-06b9918c7967"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5356b0c-bdd1-46e7-830e-d7336868ab14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6d19931-f6b1-43ed-b2ee-c704d097259b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9160cf2-6ae4-477d-ac96-fef2feee6fd8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9483cc5-4629-4f09-8628-f85819b4b578"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aac0fe0d-e543-448e-8391-7825b6cbd310"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aaee1ae4-e1c4-4366-9177-72476fc24040"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab9ced04-8923-4fa8-a1d8-19099e05d5d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abade14d-f1d8-49a6-8d7e-7abf1ec7e9f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac0ba0eb-a1ff-42c5-ac91-bcd6b13f6401"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac4a453f-66a9-4299-80f9-d2ae61924930"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("acc3d834-f14e-41fa-8a2d-cda99f7cd193"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad9ccb12-8d07-4e7e-b6a0-c660149b6d4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("adcef931-39da-4254-8980-959a7a5f92b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2636ad9-009d-4a27-bf20-023394887c3c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2cd32f7-c04a-4749-baf6-ad7763178a52"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2d3aebe-573d-4d05-830f-17d98a95ce74"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3680260-0f82-4dcc-936b-f151fa2c240b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4c28195-d55b-46ee-9db7-0ff18bdd3adc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b87277a7-48af-4fa8-a611-77ca34cea8a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b946b661-e517-44b0-8d5c-4fca7bfd6033"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b99d4538-ce19-46f9-b8bd-edfa71d56d86"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb5758f0-61d0-4286-a49d-f0ce07415dc6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc713ed8-5cc8-41eb-bfeb-c7edb73be86a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bcab7030-0886-47ee-825a-cdbca6aefea2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bcc95a93-1443-4dfb-ba0e-450e6716f7f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd2c5a3b-9474-41e1-a04c-d7161d706b6d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c16b8479-3313-4f4c-a622-a3fc21a7b2d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3d1c83e-1315-4d7b-a68a-af7bb4697180"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c44bb267-bbfd-4ffc-86f1-5fab1a70dee8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c570df51-4542-4cdf-ac1f-689de2efb8f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c725d096-c21b-4dc7-aab2-28c9df0366dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c771f17a-968e-4e82-a517-a0d5382cba02"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c906f389-1356-4efe-bd9d-f564d39455be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cbfe2f67-f49b-43fa-a524-d4bde24a06ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc826121-d102-4c6a-aaaf-afc199fadef1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd3d2ca7-ad5a-4c32-b665-44086b7e71ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd82bf4b-f583-4a4a-86cb-43f6685c460f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf7039aa-1d2f-4fc6-8a2e-1929df23ef84"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf972822-e03f-45bc-9188-163edab515fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d418680a-53ed-4158-8e06-82d4caea6714"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4cc0e00-043d-496a-8edd-3d5f9c420b4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d53ddae4-33c7-4cd5-b7f1-769959f00eee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d54bc185-1b15-448b-b66e-826d458c3fb6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d62c50f0-7298-4a18-8896-02708ce97f42"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d674f1ff-ebe6-47b7-a7e0-5e53106e9459"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d68d32d6-b08b-4f6a-8f74-972e5574fe57"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8ff66ef-7b1e-46c7-a91e-5698319e5936"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dab1d296-65c2-4955-80bc-4d6ac2f820c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc0fbee4-e6ee-4132-af07-7fce03f4decc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("deab5f73-30a7-4b02-8ce7-987d4c6127c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df3269b4-85c4-4da0-b878-2c5aaa5518aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dff815e9-0002-4643-9b41-6f4eeaff3735"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e01f2a48-53e4-41f0-902d-f11d2affa735"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e07070a4-0b05-4a20-b7cb-29f39256da6a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0f73fcd-9a90-4700-bc4b-0c65151aaa30"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e31cdfca-d7c5-4ec7-a62a-114292be5557"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e400f73a-2327-44ae-991f-ff5ef66852d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9bff46d-c91b-4087-89e9-013632ce6c47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb4eaa45-f3ae-415a-b1aa-96559b20cbd5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef52afda-44cc-4a50-807b-fc9f063107e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f535347e-5896-4f80-8973-7fb275f5e0b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6601748-290f-4710-b27e-7a8e17054561"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6becd03-2329-487e-8d4a-80df6ac593cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f80f8c68-3f47-4d08-92fd-95fb8811e993"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8fe31b4-f722-46da-99d6-7b9cefb52001"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc92f6ed-c65e-4bd1-bbad-c95e414dcb48"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fdb2c813-d564-4ca9-b270-642249e1aeb9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe5112a8-f4e4-4f8a-a2ab-fa263c9f68ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ffa3ee43-86f4-4c34-adfc-2fec132da069"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("216e4d51-c5cf-4d19-9630-7683aabff68e"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("2421566c-6d29-44fe-ba72-f6dac8ff087a"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("348b5e6e-af25-4844-8907-689752f6dddf"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("e9e49769-6a27-447f-8117-98aff3c1693a"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("f0f24bc8-e137-43fb-9c39-68da648e0ff0"));

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: new Guid("fe7c432a-ada7-49cc-9485-589101b0f977"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("6ba4366c-acfa-4d6d-bd12-135f1498333a"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("792e29b8-01f5-4b9b-8a58-4728896b1411"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("81c48208-6579-4cfc-91f9-347274f7486e"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: new Guid("efc262ed-2755-4f73-ad71-25f7a3f19991"));
        }
    }
}
