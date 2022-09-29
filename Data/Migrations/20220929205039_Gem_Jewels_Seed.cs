using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buzz.Jewelcrafting.Migrations
{
    public partial class Gem_Jewels_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GemCuts",
                columns: new[] { "Id", "Color", "IconName", "ItemId", "Name", "Stat1", "Stat2" },
                values: new object[,]
                {
                    { 1, "Meta", "inv_jewelcrafting_shadowspirit_02", 41398, "Relentless Earthsiege Diamond", null, null },
                    { 2, "Meta", "inv_jewelcrafting_icediamond_02", 41258, "Chaotic Skyflare Diamond", null, null },
                    { 3, "Meta", "inv_jewelcrafting_shadowspirit_02", 41401, "Insightful Earthsiege Diamond", null, null },
                    { 4, "Meta", "inv_jewelcrafting_icediamond_02", 41333, "Ember Skyflare Diamond", null, null },
                    { 5, "Meta", "inv_jewelcrafting_shadowspirit_02", 41385, "Invigorating Earthsiege Diamond", null, null },
                    { 6, "Meta", "inv_jewelcrafting_icediamond_02", 41376, "Revitalizing Skyflare Diamond", null, null },
                    { 7, "Red", "inv_jewelcrafting_gem_28", 39996, "Bold Scarlet Ruby", "Strength", null },
                    { 8, "Blue", "inv_jewelcrafting_gem_27", 40008, "Solid Sky Sapphire", "Stamina", null },
                    { 9, "Red", "inv_jewelcrafting_gem_28", 39997, "Delicate Scarlet Ruby", "Agility", null },
                    { 10, "Green", "inv_jewelcrafting_gem_25", 40089, "Enduring Forest Emerald", "Defense Rating", "Stamina" },
                    { 11, "Orange", "inv_jewelcrafting_gem_30", 40051, "Reckless Monarch Topaz", "Spell Power", "Haste" },
                    { 12, "Yellow", "inv_jewelcrafting_gem_26", 40014, "Rigid Autumn's Glow", "Hit Rating", null },
                    { 13, "Orange", "inv_jewelcrafting_gem_30", 40049, "Veiled Monarch Topaz", "Spell Power", "Hit Rating" },
                    { 14, "Yellow", "inv_jewelcrafting_gem_26", 40017, "Quick Autumn's Glow", "Haste Rating", null },
                    { 15, "Green", "inv_jewelcrafting_gem_25", 40092, "Seer's Forest Emerald", "Intellect", "Spirit" },
                    { 16, "Orange", "inv_jewelcrafting_gem_30", 40044, "Glinting Monarch Topaz", "Agility", "Hit Rating" },
                    { 17, "Orange", "inv_jewelcrafting_gem_30", 40047, "Luminous Monarch Topaz", "Luminous", "Intellect" },
                    { 18, "Red", "inv_jewelcrafting_gem_28", 40000, "Subtle Scarlet Ruby", "Dodge Rating", null },
                    { 19, "Purple", "inv_jewelcrafting_gem_29", 40031, "Regal Twilight Opal", "Dodge Rating", "Stamina" },
                    { 20, "Purple", "inv_jewelcrafting_gem_29", 40027, "Royal Twilight Opal", "Spell Power", "Mp5" },
                    { 21, "Green", "inv_jewelcrafting_gem_25", 40104, "Intricate Forest Emerald", "Haste Rating", "Spirit" },
                    { 22, "Green", "inv_jewelcrafting_gem_25", 40105, "Energized Forest Emerald", "Haste Rating", "Mp5" },
                    { 23, "Blue", "inv_jewelcrafting_gem_27", 40010, "Lustrous Sky Sapphire", "Mp5", null },
                    { 24, "Green", "inv_jewelcrafting_gem_25", 40088, "Vivid Forest Emerald", "Hit Rating", "Stamina" },
                    { 25, "Red", "inv_jewelcrafting_gem_28", 40001, "Flashing Scarlet Ruby", "Parry Rating", null },
                    { 26, "Green", "inv_jewelcrafting_gem_25", 40100, "Lambent Forest Emerald", "Hit Rating", "Mp5" },
                    { 27, "Purple", "inv_jewelcrafting_gem_29", 40023, "Shifting Twilight Opal", "Agility", "Stamina" },
                    { 28, "Green", "inv_jewelcrafting_gem_25", 40091, "Forceful Forest Emerald", "Haste Rating", "Stamina" },
                    { 29, "Orange", "inv_jewelcrafting_gem_30", 40048, "Potent Monarch Topaz", "Spell Power", "Critical Strike Rating" },
                    { 30, "Purple", "inv_jewelcrafting_gem_29", 40033, "Puissant Twilight Opal", "Armor Penetration Rating", "Stamina" },
                    { 31, "Orange", "inv_jewelcrafting_gem_30", 40055, "Stark Monarch Topaz", "Attack Power", "Haste Rating" }
                });

            migrationBuilder.InsertData(
                table: "Jewelry",
                columns: new[] { "Id", "IconName", "InventorySlot", "ItemId", "Name" },
                values: new object[,]
                {
                    { 1, "inv_jewelry_ring_59", "Ring", 42643, "Design: Titanium Earthguard Ring" },
                    { 2, "inv_jewelry_ring_63", "Ring", 42644, "Design: Titanium Spellshock Ring" },
                    { 3, "inv_jewelry_ring_57", "Ring", 43582, "Design: Titanium Frostguard Ring" },
                    { 4, "inv_jewelry_ring_55", "Ring", 42642, "Design: Titanium Impact Band" },
                    { 5, "inv_jewelry_necklace_14", "Neck", 42645, "Design: Titanium Impact Choker" },
                    { 6, "inv_jewelry_necklace_35", "Neck", 42647, "Design: Titanium Spellshock Necklace" },
                    { 7, "inv_jewelry_necklace_33", "Neck", 42646, "Design: Titanium Earthguard Chain" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GemCuts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Jewelry",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jewelry",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jewelry",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jewelry",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jewelry",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jewelry",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jewelry",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
