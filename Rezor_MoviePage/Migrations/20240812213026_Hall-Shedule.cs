using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rezor_MoviePage.Migrations
{
    /// <inheritdoc />
    public partial class HallShedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Movies");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Movies",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Movies");

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
