using Microsoft.EntityFrameworkCore.Migrations;

namespace WADProj.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    IdMovie = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ReviewScore = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.IdMovie);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    IdComment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ReviewScore = table.Column<int>(nullable: false),
                    CommentText = table.Column<string>(nullable: true),
                    IdMovie = table.Column<int>(nullable: false),
                    MovieIdMovie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.IdComment);
                    table.ForeignKey(
                        name: "FK_Comment_Movie_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "Movie",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MovieIdMovie",
                table: "Comment",
                column: "MovieIdMovie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
