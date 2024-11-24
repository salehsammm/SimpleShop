using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleShop.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shopingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shopingCartItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ProdcutId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    shopingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopingCartItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_shopingCartItems_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shopingCartItems_shopingCarts_shopingCartId",
                        column: x => x.shopingCartId,
                        principalTable: "shopingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shopingCartItems_productId",
                table: "shopingCartItems",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_shopingCartItems_shopingCartId",
                table: "shopingCartItems",
                column: "shopingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shopingCartItems");

            migrationBuilder.DropTable(
                name: "shopingCarts");
        }
    }
}
