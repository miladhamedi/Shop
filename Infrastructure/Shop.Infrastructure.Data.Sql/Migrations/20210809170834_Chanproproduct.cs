using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Data.Sql.Migrations
{
    public partial class Chanproproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Colors_colorId",
                table: "ProductColors");

            migrationBuilder.RenameColumn(
                name: "colorId",
                table: "ProductColors",
                newName: "ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColors_colorId",
                table: "ProductColors",
                newName: "IX_ProductColors_ColorId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscuntedPrice",
                table: "Products",
                type: "decimal(18,2)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscuntPercent",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Colors_ColorId",
                table: "ProductColors",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Colors_ColorId",
                table: "ProductColors");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "ProductColors",
                newName: "colorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColors_ColorId",
                table: "ProductColors",
                newName: "IX_ProductColors_colorId");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Products",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "DiscuntedPrice",
                table: "Products",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<int>(
                name: "DiscuntPercent",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Colors_colorId",
                table: "ProductColors",
                column: "colorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
