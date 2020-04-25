using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpToHealthApi.Migrations
{
    public partial class AddCareGiverOrganisationRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganisationEntityID",
                table: "CareGivers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CareGivers_OrganisationEntityID",
                table: "CareGivers",
                column: "OrganisationEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_CareGivers_Organisations_OrganisationEntityID",
                table: "CareGivers",
                column: "OrganisationEntityID",
                principalTable: "Organisations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CareGivers_Organisations_OrganisationEntityID",
                table: "CareGivers");

            migrationBuilder.DropIndex(
                name: "IX_CareGivers_OrganisationEntityID",
                table: "CareGivers");

            migrationBuilder.DropColumn(
                name: "OrganisationEntityID",
                table: "CareGivers");
        }
    }
}
