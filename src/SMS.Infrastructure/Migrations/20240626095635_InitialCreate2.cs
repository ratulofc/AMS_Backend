using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Infrastructure.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ClassStudents_fk0",
                table: "ClassStudents");

            migrationBuilder.DropForeignKey(
                name: "ClassStudents_fk1",
                table: "ClassStudents");

            migrationBuilder.DropIndex(
                name: "UQ__ClassStu__3214EC06925FBE88",
                table: "ClassStudents");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudents_Classes_ClassId",
                table: "ClassStudents",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudents_Students_StudentId",
                table: "ClassStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudents_Classes_ClassId",
                table: "ClassStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudents_Students_StudentId",
                table: "ClassStudents");

            migrationBuilder.CreateIndex(
                name: "UQ__ClassStu__3214EC06925FBE88",
                table: "ClassStudents",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "ClassStudents_fk0",
                table: "ClassStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "ClassStudents_fk1",
                table: "ClassStudents",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");
        }
    }
}
