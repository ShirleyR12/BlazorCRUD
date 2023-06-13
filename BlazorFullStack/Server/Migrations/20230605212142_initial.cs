using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorFullStack.Server.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuperHero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FisrtName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    HeroName = table.Column<string>(type: "TEXT", nullable: false),
                    ComicId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHero", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuperHero_Comic_ComicId",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comic",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Marvel" },
                    { 2, "DC" }
                });

            migrationBuilder.InsertData(
                table: "SuperHero",
                columns: new[] { "Id", "ComicId", "FisrtName", "HeroName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "Peter", "Homem aranha", "Park" },
                    { 2, 2, "Bruce", "Batman", "Will" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuperHero_ComicId",
                table: "SuperHero",
                column: "ComicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHero");

            migrationBuilder.DropTable(
                name: "Comic");
        }
    }
}
