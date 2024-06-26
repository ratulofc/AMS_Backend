using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Infrastructure.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UQ__Exams__3214EC06CFADBB48",
                table: "Exams");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Exams",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Exams",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.CreateIndex(
                name: "UQ__Exams__3214EC06CFADBB48",
                table: "Exams",
                column: "Id",
                unique: true);
        }
    }
}
