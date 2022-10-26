using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopDemo.Core.Migrations
{
    public partial class ChangeToDecimalProductPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal",
                nullable: false,
                comment: "Product price",
                oldClrType: typeof(decimal),
                oldType: "money",
                oldComment: "Product price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "money",
                nullable: false,
                comment: "Product price",
                oldClrType: typeof(decimal),
                oldType: "decimal",
                oldComment: "Product price");
        }
    }
}
