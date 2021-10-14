using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActorsS_Actors_ActorId",
                table: "MovieActorsS");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActorsS_Movies_MovieId",
                table: "MovieActorsS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieActorsS",
                table: "MovieActorsS");

            migrationBuilder.RenameTable(
                name: "MovieActorsS",
                newName: "MovieActors");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActorsS_MovieId",
                table: "MovieActors",
                newName: "IX_MovieActors_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActorsS_ActorId",
                table: "MovieActors",
                newName: "IX_MovieActors_ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Actors_ActorId",
                table: "MovieActors",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Movies_MovieId",
                table: "MovieActors",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Actors_ActorId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Movies_MovieId",
                table: "MovieActors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors");

            migrationBuilder.RenameTable(
                name: "MovieActors",
                newName: "MovieActorsS");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActors_MovieId",
                table: "MovieActorsS",
                newName: "IX_MovieActorsS_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActors_ActorId",
                table: "MovieActorsS",
                newName: "IX_MovieActorsS_ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieActorsS",
                table: "MovieActorsS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActorsS_Actors_ActorId",
                table: "MovieActorsS",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActorsS_Movies_MovieId",
                table: "MovieActorsS",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
