using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTicketReservation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRouteStopTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StopCode",
                table: "RouteStops",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StopCode",
                table: "RouteStops");
        }
    }
}
