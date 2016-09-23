using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace TaacTapTerminal.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbContextOrder",
                columns: table => new
                {
                    DbContextOrderId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbContextOrder", x => x.DbContextOrderId);
                });
            migrationBuilder.CreateTable(
                name: "DbContextItem",
                columns: table => new
                {
                    DbContextItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DbContextOrderDbContextOrderId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbContextItem", x => x.DbContextItemId);
                    table.ForeignKey(
                        name: "FK_DbContextItem_DbContextOrder_DbContextOrderDbContextOrderId",
                        column: x => x.DbContextOrderDbContextOrderId,
                        principalTable: "DbContextOrder",
                        principalColumn: "DbContextOrderId",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("DbContextItem");
            migrationBuilder.DropTable("DbContextOrder");
        }
    }
}
