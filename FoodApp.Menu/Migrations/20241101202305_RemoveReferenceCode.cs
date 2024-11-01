using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.Menu.Migrations
{
    /// <inheritdoc />
    public partial class RemoveReferenceCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ReferenceCode",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ReferenceCode",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceCode",
                table: "Products",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceCode",
                table: "Categories",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ReferenceCode",
                keyValue: null,
                column: "ReferenceCode",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceCode",
                table: "Products",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ReferenceCode",
                keyValue: null,
                column: "ReferenceCode",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceCode",
                table: "Categories",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
    }
}
