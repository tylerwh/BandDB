using Microsoft.EntityFrameworkCore.Migrations;

namespace BandDB.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    BandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.BandId);
                    table.ForeignKey(
                        name: "FK_Bands_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 45, nullable: false),
                    BandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                    table.ForeignKey(
                        name: "FK_Artists_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "BandId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, "Jazz" },
                    { 2, "Metal" },
                    { 3, "Rock" },
                    { 4, "Pop" },
                    { 5, "Country" },
                    { 6, "Rap" },
                    { 7, "Punk" }
                });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "GenreId", "Name" },
                values: new object[] { 1, 2, "The Frogs" });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "GenreId", "Name" },
                values: new object[] { 2, 3, "Ben Folds Five" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "BandId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "Spencer", "Hopps" },
                    { 2, 1, "Bull", "Frog" },
                    { 3, 2, "Ben", "Folds" },
                    { 4, 2, "Darren", "Jesse" },
                    { 5, 2, "Robert", "Sledge" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_BandId",
                table: "Artists",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_Bands_GenreId",
                table: "Bands",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Bands");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
