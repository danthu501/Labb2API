using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2API.Migrations
{
    public partial class addedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[] { 2, "Economy" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "City", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Salary", "StreetAdress", "Zipcode" },
                values: new object[] { 3, "Varberg", 1, "danne@g-bk.com", "Daniel", "m", "Thulin", "0730597135", 24500m, "Kiselgatan 69", "43256" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "City", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Salary", "StreetAdress", "Zipcode" },
                values: new object[] { 4, "Varberg", 1, "as@gmail.com", "Anders", "m", "Svensson", "0730987654", 34500m, "Kastanjevägen 13", "43231" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);
        }
    }
}
