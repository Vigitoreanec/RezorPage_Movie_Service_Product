using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rezor_MoviePage.Migrations
{
    /// <inheritdoc />
    public partial class TransferCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Shedule",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Shedule");
        }
    }
}
