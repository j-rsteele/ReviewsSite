using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ActorId",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ActorId",
                value: 4);
        }
    }
}
