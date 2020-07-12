using Microsoft.EntityFrameworkCore.Migrations;

namespace MATruck.Database.Migrations
{
    public partial class AddedStateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Factorys",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Dispatchs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Brokers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Factorys");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Dispatchs");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Brokers");
        }
    }
}
