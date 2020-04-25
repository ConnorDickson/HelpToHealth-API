using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpToHealthApi.Migrations
{
    public partial class AddVolunteerAgeAndCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "CareVolunteers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "CareVolunteers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "CareVolunteers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "CareVolunteers");
        }
    }
}
