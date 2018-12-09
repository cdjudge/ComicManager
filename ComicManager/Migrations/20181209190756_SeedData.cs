using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicManager.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "id",
                keyValue: 1,
                column: "date_aquired",
                value: "12/9/2018 7:07 PM");

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "id",
                keyValue: 2,
                column: "date_aquired",
                value: "12/9/2018 7:07 PM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "id",
                keyValue: 1,
                column: "date_aquired",
                value: "12/9/2018 7:01 PM");

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "id",
                keyValue: 2,
                column: "date_aquired",
                value: "12/9/2018 7:01 PM");
        }
    }
}
