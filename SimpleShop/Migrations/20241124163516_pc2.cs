using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleShop.Migrations
{
    /// <inheritdoc />
    public partial class pc2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_Products_productId",
                table: "shopingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_shopingCarts_ShopingCartId",
                table: "shopingCartItems");

            migrationBuilder.DropColumn(
                name: "totalPrice",
                table: "shopingCarts");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "shopingCartItems",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "shopingCartItems",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_shopingCartItems_productId",
                table: "shopingCartItems",
                newName: "IX_shopingCartItems_ProductId");

            migrationBuilder.AlterColumn<int>(
                name: "ShopingCartId",
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
                name: "FK_shopingCartItems_Products_ProductId",
                table: "shopingCartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_shopingCartItems_shopingCarts_ShopingCartId",
                table: "shopingCartItems",
                column: "ShopingCartId",
                principalTable: "shopingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_Products_ProductId",
                table: "shopingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_shopingCarts_ShopingCartId",
                table: "shopingCartItems");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "shopingCartItems");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "shopingCartItems",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "shopingCartItems",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_shopingCartItems_ProductId",
                table: "shopingCartItems",
                newName: "IX_shopingCartItems_productId");

            migrationBuilder.AddColumn<int>(
                name: "totalPrice",
                table: "shopingCarts",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShopingCartId",
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
    }
}
