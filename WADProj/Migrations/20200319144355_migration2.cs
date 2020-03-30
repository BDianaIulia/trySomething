using Microsoft.EntityFrameworkCore.Migrations;

namespace WADProj.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "User",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserMovieActivity",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMovieActivity", x => new { x.MovieId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserMovieActivity_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMovieActivity_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserMovieActivity_UserId",
                table: "UserMovieActivity",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMovieActivity");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "User");
        }
    }
}
