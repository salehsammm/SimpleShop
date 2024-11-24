using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleShop.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_Products_productId",
                table: "shopingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_shopingCarts_shopingCartId",
                table: "shopingCartItems");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "shopingCartItems");

            migrationBuilder.RenameColumn(
                name: "shopingCartId",
                table: "shopingCartItems",
                newName: "ShopingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_shopingCartItems_shopingCartId",
                table: "shopingCartItems",
                newName: "IX_shopingCartItems_ShopingCartId");

            migrationBuilder.AlterColumn<int>(
                name: "ShopingCartId",
                table: "shopingCartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "shopingCartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_shopingCartItems_Products_productId",
                table: "shopingCartItems",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_shopingCartItems_shopingCarts_ShopingCartId",
                table: "shopingCartItems",
                column: "ShopingCartId",
                principalTable: "shopingCarts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_Products_productId",
                table: "shopingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_shopingCarts_ShopingCartId",
                table: "shopingCartItems");

            migrationBuilder.RenameColumn(
                name: "ShopingCartId",
                table: "shopingCartItems",
                newName: "shopingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_shopingCartItems_ShopingCartId",
                table: "shopingCartItems",
                newName: "IX_shopingCartItems_shopingCartId");

            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "shopingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "shopingCartId",
                table: "shopingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "shopingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_shopingCartItems_Products_productId",
                table: "shopingCartItems",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_shopingCartItems_shopingCarts_shopingCartId",
                table: "shopingCartItems",
                column: "shopingCartId",
                principalTable: "shopingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
