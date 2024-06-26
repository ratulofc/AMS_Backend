using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Infrastructure.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fees_fk4",
                table: "Fees");

            migrationBuilder.DropForeignKey(
                name: "Notices_fk5",
                table: "Notices");

            migrationBuilder.DropForeignKey(
                name: "Results_fk1",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "Results_fk2",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "Results_fk3",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "UQ__Subjects__3214EC062E9D17EA",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "UQ__Results__3214EC068B71D55B",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "UQ__Notices__3214EC0685C23017",
                table: "Notices");

            migrationBuilder.DropIndex(
                name: "UQ__Fees__3214EC06FB5FEE88",
                table: "Fees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaidDate",
                table: "Fees",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Fees",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_Students_StudentId",
                table: "Fees",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notices_Teachers_TeacherId",
                table: "Notices",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Exams_ExamId",
                table: "Results",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_StudentId",
                table: "Results",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Subjects_SubjectId",
                table: "Results",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fees_Students_StudentId",
                table: "Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Notices_Teachers_TeacherId",
                table: "Notices");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Exams_ExamId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_StudentId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Subjects_SubjectId",
                table: "Results");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaidDate",
                table: "Fees",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Fees",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.CreateIndex(
                name: "UQ__Subjects__3214EC062E9D17EA",
                table: "Subjects",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Results__3214EC068B71D55B",
                table: "Results",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Notices__3214EC0685C23017",
                table: "Notices",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Fees__3214EC06FB5FEE88",
                table: "Fees",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "Fees_fk4",
                table: "Fees",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Notices_fk5",
                table: "Notices",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Results_fk1",
                table: "Results",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Results_fk2",
                table: "Results",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Results_fk3",
                table: "Results",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }
    }
}
