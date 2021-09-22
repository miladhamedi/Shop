using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Data.Sql.Migrations
{
    public partial class remoeprouserpage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddPost",
                table: "UserPages");

            migrationBuilder.DropColumn(
                name: "DeletePost",
                table: "UserPages");

            migrationBuilder.DropColumn(
                name: "EditPost",
                table: "UserPages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AddPost",
                table: "UserPages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DeletePost",
                table: "UserPages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EditPost",
                table: "UserPages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
