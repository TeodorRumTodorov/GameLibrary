using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLibrary.Data.Migrations
{
    public partial class AddedUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Publishers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Creators",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Creators");
        }
    }
}
