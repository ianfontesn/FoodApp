using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.Menu.Migrations
{
    /// <inheritdoc />
    public partial class AddReferenceCodeFieldToBaseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReferenceCode",
                table: "Products",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ReferenceCode",
                table: "Categories",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReferenceCode",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ReferenceCode",
                table: "Categories");
        }
    }
}
