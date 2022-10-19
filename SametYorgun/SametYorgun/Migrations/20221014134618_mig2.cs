using Microsoft.EntityFrameworkCore.Migrations;

namespace SametYorgun.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilResimYol",
                table: "kisiselBilgis",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilResimYol",
                table: "kisiselBilgis");
        }
    }
}
