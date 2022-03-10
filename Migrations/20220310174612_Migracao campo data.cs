using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Migrations
{
    public partial class Migracaocampodata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registo",
                columns: table => new
                {
                    RegistoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varchar50 = table.Column<string>(name: "varchar(50)", type: "nvarchar(max)", nullable: false),
                    varchar30 = table.Column<string>(name: "varchar(30)", type: "nvarchar(max)", nullable: false),
                    int9 = table.Column<int>(name: "int(9)", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registo", x => x.RegistoID);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    ReservaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varchar50 = table.Column<string>(name: "varchar(50)", type: "nvarchar(max)", nullable: false),
                    int9 = table.Column<int>(name: "int(9)", type: "int", nullable: false),
                    DataReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    int2 = table.Column<int>(name: "int(2)", type: "int", nullable: false),
                    RegistoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.ReservaID);
                    table.ForeignKey(
                        name: "FK_Reserva_Registo_RegistoID",
                        column: x => x.RegistoID,
                        principalTable: "Registo",
                        principalColumn: "RegistoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_RegistoID",
                table: "Reserva",
                column: "RegistoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Registo");
        }
    }
}
