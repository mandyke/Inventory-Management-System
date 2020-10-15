using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory_Management_System.Data.Migrations
{
    public partial class modifiedEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Confirmpwd",
                table: "Employees",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pwd",
                table: "Employees",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmpwd",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Pwd",
                table: "Employees");
        }
    }
}
