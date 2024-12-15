using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NexCart.Migrations
{
    /// <inheritdoc />
    public partial class imageDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
