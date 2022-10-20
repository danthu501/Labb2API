using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2API.Migrations
{
    public partial class departmentNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "DepartmentId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "DepartmentId",
                value: 1);
        }
    }
}
