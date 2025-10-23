using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTicketReservation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBusTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BusType",
                table: "Buses",
                type: "integer",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusType",
                table: "Buses");
        }
    }
}
