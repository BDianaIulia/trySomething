using Microsoft.EntityFrameworkCore.Migrations;

namespace WADProj.Migrations
{
    public partial class try5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieRating",
                columns: table => new
                {
                    IdMovieRating = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOf5ReviewStars = table.Column<int>(nullable: false),
                    NumberOf4ReviewStars = table.Column<int>(nullable: false),
                    NumberOf3ReviewStars = table.Column<int>(nullable: false),
                    NumberOf2ReviewStars = table.Column<int>(nullable: false),
                    NumberOf1ReviewStars = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieRating", x => x.IdMovieRating);
                    table.ForeignKey(
                        name: "FK_MovieRating_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieRating_MovieId",
                table: "MovieRating",
                column: "MovieId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieRating");
        }
    }
}
