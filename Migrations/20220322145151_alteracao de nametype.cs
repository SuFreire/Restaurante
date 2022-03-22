using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Migrations
{
    public partial class alteracaodenametype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(50)",
                table: "Registo",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "varchar(30)",
                table: "Registo",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "int(9)",
                table: "Registo",
                newName: "Telefone");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Registo",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Registo",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Registo_Email",
                table: "Registo",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Registo_Email",
                table: "Registo");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Registo",
                newName: "int(9)");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Registo",
                newName: "varchar(50)");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Registo",
                newName: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(50)",
                table: "Registo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(30)",
                table: "Registo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");
        }
    }
}
