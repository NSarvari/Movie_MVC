using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReviews.Data.Migrations
{
    public partial class MyInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirector_Directors_directorId",
                table: "MovieDirector");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirector_Movies_movieId",
                table: "MovieDirector");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieDirector",
                table: "MovieDirector");

            migrationBuilder.RenameTable(
                name: "MovieDirector",
                newName: "MovieDirectors");

            migrationBuilder.RenameIndex(
                name: "IX_MovieDirector_directorId",
                table: "MovieDirectors",
                newName: "IX_MovieDirectors_directorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieDirectors",
                table: "MovieDirectors",
                columns: new[] { "movieId", "directorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirectors_Directors_directorId",
                table: "MovieDirectors",
                column: "directorId",
                principalTable: "Directors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirectors_Movies_movieId",
                table: "MovieDirectors",
                column: "movieId",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirectors_Directors_directorId",
                table: "MovieDirectors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirectors_Movies_movieId",
                table: "MovieDirectors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieDirectors",
                table: "MovieDirectors");

            migrationBuilder.RenameTable(
                name: "MovieDirectors",
                newName: "MovieDirector");

            migrationBuilder.RenameIndex(
                name: "IX_MovieDirectors_directorId",
                table: "MovieDirector",
                newName: "IX_MovieDirector_directorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieDirector",
                table: "MovieDirector",
                columns: new[] { "movieId", "directorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirector_Directors_directorId",
                table: "MovieDirector",
                column: "directorId",
                principalTable: "Directors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirector_Movies_movieId",
                table: "MovieDirector",
                column: "movieId",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
