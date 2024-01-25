using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examenDAW.Migrations
{
    public partial class ex2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "Profesori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prenume",
                table: "Profesori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tip",
                table: "Profesori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nume",
                table: "Profesori");

            migrationBuilder.DropColumn(
                name: "Prenume",
                table: "Profesori");

            migrationBuilder.DropColumn(
                name: "Tip",
                table: "Profesori");
        }
    }
}
