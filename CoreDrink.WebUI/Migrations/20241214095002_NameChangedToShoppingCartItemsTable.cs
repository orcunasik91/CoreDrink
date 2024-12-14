using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDrink.WebUI.Migrations
{
    public partial class NameChangedToShoppingCartItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shoppingCartItems_Drinks_DrinkId",
                table: "shoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shoppingCartItems",
                table: "shoppingCartItems");

            migrationBuilder.RenameTable(
                name: "shoppingCartItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_shoppingCartItems_DrinkId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_DrinkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Drinks_DrinkId",
                table: "ShoppingCartItems",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "DrinkId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Drinks_DrinkId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "shoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_DrinkId",
                table: "shoppingCartItems",
                newName: "IX_shoppingCartItems_DrinkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shoppingCartItems",
                table: "shoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_shoppingCartItems_Drinks_DrinkId",
                table: "shoppingCartItems",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "DrinkId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
