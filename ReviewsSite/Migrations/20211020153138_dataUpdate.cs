using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class dataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bela Lugosi");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Helen Chandler");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Boris Karloff");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Lon Chaney Jr.");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "John Carradine");

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ActorId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ActorId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "Rating", "ReleaseYear", "Title" },
                values: new object[] { "Horror", "NR", 1931, "Dracula" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Genre", "Rating", "ReleaseYear", "Title" },
                values: new object[] { "Horror", "NR", 1944, "House of Frankenstein" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Award", "Genre", "Rating", "Title" },
                values: new object[] { "Saturn", "Horror", "NR", "The Mummy's Ghost" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Comment",
                value: "Dracula is easily one of the most influential horror films ever released. Released by Universal Pictures in 1931, Dracula starred Bela Lugosi as the titular vampire and effectively established the way that vampire stories would be told for the next century.  Lugosi's costume and mannerisms, including his iconic accent, have long been Dracula staples (\"I vant to suck your blood!\"), and future vampire stories borrowed heavily from the mythology and imagery of Dracula. It's an undisputed classic.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "Comment",
                value: "The horror story makes absolutely no sense, but it is so nutty that it makes for a diverting watch.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Comment",
                value: "Another effort in laziness with scenes lifted directly from earlier Mummy films. Not fun.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "Name" },
                values: new object[] { "Great classic movie with all the trimmings.  The horror is b-grade at best, but very entertaining.", "Kevin" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "Name" },
                values: new object[] { "The movie has some good typical Unverisal '40's horror moments. Of course it's nothing too scary, at least not by today's standards but it's very classy and good looking all, with the use of shadows and some handy camera-work.", "Paul Chambers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Actor1");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Actor2");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Actor3");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Actor4");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Actor5");

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ActorId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ActorId",
                value: 2);

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { 7, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "Rating", "ReleaseYear", "Title" },
                values: new object[] { "Action", "R", 2010, "Movie1a1a2" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Genre", "Rating", "ReleaseYear", "Title" },
                values: new object[] { "Drama", "G", 2011, "Movie2a3a4" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Award", "Genre", "Rating", "Title" },
                values: new object[] { "none", "Comedy", "PG", "Movie3a5a2a1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Comment",
                value: "pretty good");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "Comment",
                value: "really bad");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Comment",
                value: "scary");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "Name" },
                values: new object[] { "delicious", "Bob" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "Name" },
                values: new object[] { "supergood", "David" });
        }
    }
}
