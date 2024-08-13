using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rezor_MoviePage.Migrations
{
    /// <inheritdoc />
    public partial class HallSheduleAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HallCinema",
                columns: table => new
                {
                    NumberHall = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountRows = table.Column<int>(type: "int", nullable: false),
                    CountSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallCinema", x => x.NumberHall);
                });

            migrationBuilder.CreateTable(
                name: "Shedule",
                columns: table => new
                {
                    SheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartFilm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndFilm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    HallCinemaNumberHall = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shedule", x => x.SheduleId);
                    table.ForeignKey(
                        name: "FK_Shedule_HallCinema_HallCinemaNumberHall",
                        column: x => x.HallCinemaNumberHall,
                        principalTable: "HallCinema",
                        principalColumn: "NumberHall",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shedule_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shedule_HallCinemaNumberHall",
                table: "Shedule",
                column: "HallCinemaNumberHall");

            migrationBuilder.CreateIndex(
                name: "IX_Shedule_MovieId",
                table: "Shedule",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shedule");

            migrationBuilder.DropTable(
                name: "HallCinema");
        }
    }
}
