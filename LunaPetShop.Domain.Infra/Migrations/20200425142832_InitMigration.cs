using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LunaPetShop.Domain.Infra.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NAME = table.Column<string>(type: "varchar(150)", nullable: false),
                    SURNAME = table.Column<string>(nullable: false),
                    EMAIL = table.Column<string>(nullable: false),
                    PASSWORD = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PET",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NAME = table.Column<string>(type: "varchar(150)", nullable: false),
                    WEIGTH = table.Column<double>(nullable: false),
                    AGE = table.Column<int>(nullable: false),
                    SEX = table.Column<string>(nullable: true),
                    BREED = table.Column<string>(nullable: true),
                    CASTRATED = table.Column<bool>(type: "bit", nullable: false),
                    SIZE = table.Column<double>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PET", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PET_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PET_UserId",
                table: "PET",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PET");

            migrationBuilder.DropTable(
                name: "USER");
        }
    }
}
