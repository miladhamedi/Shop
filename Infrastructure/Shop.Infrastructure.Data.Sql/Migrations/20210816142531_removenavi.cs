using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Data.Sql.Migrations
{
    public partial class removenavi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Products_ProductId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Invoices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Products_ProductId",
                table: "Invoices",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Products_ProductId",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Products_ProductId",
                table: "Invoices",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
