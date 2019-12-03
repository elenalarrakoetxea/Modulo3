using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinalModulo3.Data.Migrations
{
    public partial class migracion10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecommendedAge",
                table: "Film",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecommendedAge",
                table: "Film");
        }
    }
}
