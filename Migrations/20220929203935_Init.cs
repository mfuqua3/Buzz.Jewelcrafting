using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Buzz.Jewelcrafting.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GemCuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Stat1 = table.Column<string>(type: "text", nullable: true),
                    Stat2 = table.Column<string>(type: "text", nullable: true),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    IconName = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GemCuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jewelry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InventorySlot = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    IconName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jewelry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DiscordId = table.Column<decimal>(type: "numeric(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cost = table.Column<int>(type: "integer", nullable: true),
                    Source = table.Column<string>(type: "text", nullable: true),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    IconName = table.Column<string>(type: "text", nullable: true),
                    GemCutId = table.Column<int>(type: "integer", nullable: true),
                    JewelryId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designs_GemCuts_GemCutId",
                        column: x => x.GemCutId,
                        principalTable: "GemCuts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Designs_Jewelry_JewelryId",
                        column: x => x.JewelryId,
                        principalTable: "Jewelry",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDesigns",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    DesignId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDesigns", x => new { x.UserId, x.DesignId });
                    table.ForeignKey(
                        name: "FK_UserDesigns_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDesigns_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Designs_GemCutId",
                table: "Designs",
                column: "GemCutId");

            migrationBuilder.CreateIndex(
                name: "IX_Designs_JewelryId",
                table: "Designs",
                column: "JewelryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDesigns_DesignId",
                table: "UserDesigns",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDesigns_UserId1",
                table: "UserDesigns",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDesigns");

            migrationBuilder.DropTable(
                name: "Designs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GemCuts");

            migrationBuilder.DropTable(
                name: "Jewelry");
        }
    }
}
