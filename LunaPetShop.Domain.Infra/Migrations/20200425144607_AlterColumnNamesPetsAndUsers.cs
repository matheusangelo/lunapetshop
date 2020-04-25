using Microsoft.EntityFrameworkCore.Migrations;

namespace LunaPetShop.Domain.Infra.Migrations
{
    public partial class AlterColumnNamesPetsAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PET_USER_UserId",
                table: "PET");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "USER",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PET",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "PET",
                newName: "USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_PET_UserId",
                table: "PET",
                newName: "IX_PET_USER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PET_USER_USER_ID",
                table: "PET",
                column: "USER_ID",
                principalTable: "USER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PET_USER_USER_ID",
                table: "PET");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "USER",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PET",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "USER_ID",
                table: "PET",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PET_USER_ID",
                table: "PET",
                newName: "IX_PET_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PET_USER_UserId",
                table: "PET",
                column: "UserId",
                principalTable: "USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
