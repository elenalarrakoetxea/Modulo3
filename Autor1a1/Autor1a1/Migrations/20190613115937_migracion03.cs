using Microsoft.EntityFrameworkCore.Migrations;

namespace Autor1a1.Migrations
{
    public partial class migracion03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_Biografia_BiografiaId",
                table: "Autor");

            migrationBuilder.DropIndex(
                name: "IX_Autor_BiografiaId",
                table: "Autor");

            migrationBuilder.DropColumn(
                name: "BiografiaId",
                table: "Autor");

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Biografia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Biografia_AutorId",
                table: "Biografia",
                column: "AutorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Biografia_Autor_AutorId",
                table: "Biografia",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biografia_Autor_AutorId",
                table: "Biografia");

            migrationBuilder.DropIndex(
                name: "IX_Biografia_AutorId",
                table: "Biografia");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Biografia");

            migrationBuilder.AddColumn<int>(
                name: "BiografiaId",
                table: "Autor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Autor_BiografiaId",
                table: "Autor",
                column: "BiografiaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_Biografia_BiografiaId",
                table: "Autor",
                column: "BiografiaId",
                principalTable: "Biografia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
