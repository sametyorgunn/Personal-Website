using Microsoft.EntityFrameworkCore.Migrations;

namespace SametYorgun.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "hakkimdas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "hakkimdas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
