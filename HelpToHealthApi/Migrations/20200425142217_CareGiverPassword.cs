using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpToHealthApi.Migrations
{
    public partial class CareGiverPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "CareGivers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "CareGivers");
        }
    }
}
