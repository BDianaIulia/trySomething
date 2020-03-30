using Microsoft.EntityFrameworkCore.Migrations;

namespace WADProj.Migrations
{
    public partial class try8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Movie_MovieIdMovie",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_MovieIdMovie",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "IdMovie",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "MovieIdMovie",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comment");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Comment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MovieId",
                table: "Comment",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Movie_MovieId",
                table: "Comment",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Movie_MovieId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_MovieId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Comment");

            migrationBuilder.AddColumn<int>(
                name: "IdMovie",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieIdMovie",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MovieIdMovie",
                table: "Comment",
                column: "MovieIdMovie");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Movie_MovieIdMovie",
                table: "Comment",
                column: "MovieIdMovie",
                principalTable: "Movie",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
