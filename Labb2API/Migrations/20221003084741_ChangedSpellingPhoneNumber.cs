using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2API.Migrations
{
    public partial class ChangedSpellingPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumeber",
                table: "Employees",
                newName: "PhoneNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Employees",
                newName: "PhoneNumeber");
        }
    }
}
