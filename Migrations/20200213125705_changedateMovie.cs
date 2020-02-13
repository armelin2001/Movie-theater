using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTheater.Migrations
{
    public partial class changedateMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RelaseDateOf",
                table: "Movies",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "RelaseDateOf",
                table: "Movies",
                type: "double",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
