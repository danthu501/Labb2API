using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2API.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "City", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Salary", "StreetAdress", "Zipcode" },
                values: new object[] { 2, "Varberg", 1, "danne@g-bk.com", "Testa", "m", "kul", "0730597135", 24500m, "storgatan 23", "43256" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);
        }
    }
}
