using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KsiunszkiAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Pseudonym = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BirthPlace = table.Column<string>(nullable: true),
                    DeathDate = table.Column<DateTime>(nullable: false),
                    DeathPlace = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(nullable: false),
                    GenreDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkId);
                });

            migrationBuilder.CreateTable(
                name: "AuthorGenre",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorGenre", x => new { x.AuthorId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_AuthorGenre_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorWork",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false),
                    WorkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorWork", x => new { x.AuthorId, x.WorkId });
                    table.ForeignKey(
                        name: "FK_AuthorWork_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorWork_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkGenre",
                columns: table => new
                {
                    WorkId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkGenre", x => new { x.WorkId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_WorkGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkGenre_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "BirthDate", "BirthPlace", "DeathDate", "DeathPlace", "Name", "Pseudonym", "Surname", "Twitter", "Website" },
                values: new object[] { 1, new DateTime(1564, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stratford-upon-Avon", new DateTime(1616, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stratford-upon-Avon", "William", null, "Shakespeare", null, null });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "WorkId", "Title" },
                values: new object[] { 1, "Sen nocy letniej" });

            migrationBuilder.InsertData(
                table: "AuthorWork",
                columns: new[] { "AuthorId", "WorkId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorGenre_GenreId",
                table: "AuthorGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorWork_WorkId",
                table: "AuthorWork",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkGenre_GenreId",
                table: "WorkGenre",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorGenre");

            migrationBuilder.DropTable(
                name: "AuthorWork");

            migrationBuilder.DropTable(
                name: "WorkGenre");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
