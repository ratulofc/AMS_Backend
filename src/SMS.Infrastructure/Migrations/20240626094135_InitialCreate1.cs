using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Infrastructure.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Classes_fk3",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "UQ__Classes__3214EC0623EDF78A",
                table: "Classes");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_TeacherId",
                table: "Classes",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_TeacherId",
                table: "Classes");

            migrationBuilder.CreateIndex(
                name: "UQ__Classes__3214EC0623EDF78A",
                table: "Classes",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "Classes_fk3",
                table: "Classes",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }
    }
}
