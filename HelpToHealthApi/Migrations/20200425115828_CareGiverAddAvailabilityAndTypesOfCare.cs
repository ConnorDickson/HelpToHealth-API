using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpToHealthApi.Migrations
{
    public partial class CareGiverAddAvailabilityAndTypesOfCare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "CareGivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypesOfCare",
                table: "CareGivers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "CareGivers");

            migrationBuilder.DropColumn(
                name: "TypesOfCare",
                table: "CareGivers");
        }
    }
}
