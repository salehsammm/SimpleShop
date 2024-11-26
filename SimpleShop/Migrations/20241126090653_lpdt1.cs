using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleShop.Migrations
{
    /// <inheritdoc />
    public partial class lpdt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_Products_ProductId",
                table: "shopingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_shopingCartItems_shopingCarts_ShopingCartId",
                table: "shopingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_shopingCarts_User_UserId",
                table: "shopingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shopingCarts",
                table: "shopingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shopingCartItems",
                table: "shopingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "shopingCarts",
                newName: "ShopingCarts");

            migrationBuilder.RenameTable(
                name: "shopingCartItems",
                newName: "ShopingCartItems");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_shopingCarts_UserId",
                table: "ShopingCarts",
                newName: "IX_ShopingCarts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_shopingCartItems_ShopingCartId",
                table: "ShopingCartItems",
                newName: "IX_ShopingCartItems_ShopingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_shopingCartItems_ProductId",
                table: "ShopingCartItems",
                newName: "IX_ShopingCartItems_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopingCarts",
                table: "ShopingCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopingCartItems",
                table: "ShopingCartItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCartItems_Products_ProductId",
                table: "ShopingCartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCartItems_ShopingCarts_ShopingCartId",
                table: "ShopingCartItems",
                column: "ShopingCartId",
                principalTable: "ShopingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCarts_Users_UserId",
                table: "ShopingCarts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCartItems_Products_ProductId",
                table: "ShopingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCartItems_ShopingCarts_ShopingCartId",
                table: "ShopingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCarts_Users_UserId",
                table: "ShopingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopingCarts",
                table: "ShopingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopingCartItems",
                table: "ShopingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "ShopingCarts",
                newName: "shopingCarts");

            migrationBuilder.RenameTable(
                name: "ShopingCartItems",
                newName: "shopingCartItems");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_ShopingCarts_UserId",
                table: "shopingCarts",
                newName: "IX_shopingCarts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopingCartItems_ShopingCartId",
                table: "shopingCartItems",
                newName: "IX_shopingCartItems_ShopingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopingCartItems_ProductId",
                table: "shopingCartItems",
                newName: "IX_shopingCartItems_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shopingCarts",
                table: "shopingCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shopingCartItems",
                table: "shopingCartItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_shopingCartItems_Products_ProductId",
                table: "shopingCartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_shopingCartItems_shopingCarts_ShopingCartId",
                table: "shopingCartItems",
                column: "ShopingCartId",
                principalTable: "shopingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_shopingCarts_User_UserId",
                table: "shopingCarts",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
