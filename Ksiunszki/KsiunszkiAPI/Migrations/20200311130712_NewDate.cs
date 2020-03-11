using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KsiunszkiAPI.Migrations
{
    public partial class NewDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeathDate",
                table: "Authors");

            migrationBuilder.AddColumn<int>(
                name: "BirthDay",
                table: "Authors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BirthMonth",
                table: "Authors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BirthYear",
                table: "Authors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeathDay",
                table: "Authors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeathMonth",
                table: "Authors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeathYear",
                table: "Authors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                columns: new[] { "BirthDay", "BirthMonth", "BirthYear", "DeathYear" },
                values: new object[] { 23, 4, 1564, 1616 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BirthMonth",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BirthYear",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeathDay",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeathMonth",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeathYear",
                table: "Authors");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeathDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                columns: new[] { "BirthDate", "DeathDate" },
                values: new object[] { new DateTime(1564, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1616, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
