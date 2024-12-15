using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NexCart.Migrations
{
    /// <inheritdoc />
    public partial class newImageDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecondImage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ThirdImage",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SecondImage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ThirdImage",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
