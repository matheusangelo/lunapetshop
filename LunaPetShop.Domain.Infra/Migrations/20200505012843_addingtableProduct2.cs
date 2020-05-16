using Microsoft.EntityFrameworkCore.Migrations;

namespace LunaPetShop.Domain.Infra.Migrations
{
    public partial class addingtableProduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "PRODUCT");

            migrationBuilder.RenameColumn(
                name: "Reviews",
                table: "PRODUCT",
                newName: "REVIEWS");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PRODUCT",
                newName: "PRICE");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PRODUCT",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "PRODUCT",
                newName: "AMOUNT");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PRODUCT",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "AnimalType",
                table: "PRODUCT",
                newName: "ANIMAL_TYPE");

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                table: "PRODUCT",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ANIMAL_TYPE",
                table: "PRODUCT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUCT",
                table: "PRODUCT",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUCT",
                table: "PRODUCT");

            migrationBuilder.RenameTable(
                name: "PRODUCT",
                newName: "products");

            migrationBuilder.RenameColumn(
                name: "REVIEWS",
                table: "products",
                newName: "Reviews");

            migrationBuilder.RenameColumn(
                name: "PRICE",
                table: "products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AMOUNT",
                table: "products",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ANIMAL_TYPE",
                table: "products",
                newName: "AnimalType");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "AnimalType",
                table: "products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");
        }
    }
}
