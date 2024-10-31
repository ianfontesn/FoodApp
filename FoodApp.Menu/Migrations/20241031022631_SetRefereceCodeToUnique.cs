using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.Menu.Migrations
{
    /// <inheritdoc />
    public partial class SetRefereceCodeToUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_ReferenceCode",
                table: "Products",
                column: "ReferenceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ReferenceCode",
                table: "Categories",
                column: "ReferenceCode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ReferenceCode",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ReferenceCode",
                table: "Categories");
        }
    }
}
