using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buzz.Jewelcrafting.Migrations
{
    public partial class Design_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Designs",
                columns: new[] { "Id", "Cost", "GemCutId", "IconName", "ItemId", "JewelryId", "Name", "Source" },
                values: new object[,]
                {
                    { 1, 6, null, null, 42649, 1, "Design: Titanium Earthguard Ring", "Token" },
                    { 2, 6, null, null, 42650, 2, "Design: Titanium Spellshock Ring", "Token" },
                    { 3, 6, null, null, 43597, 3, "Design: Titanium Frostguard Ring", "Token" },
                    { 4, 6, null, null, 42648, 4, "Design: Titanium Impact Band", "Token" },
                    { 5, 6, null, null, 42651, 5, "Design: Titanium Impact Choker", "Token" },
                    { 6, 6, null, null, 42653, 6, "Design: Titanium Spellshock Necklace", "Token" },
                    { 7, 6, null, null, 42652, 7, "Design: Titanium Earthguard Chain", "Token" },
                    { 8, 5, 1, null, 41710, null, "Design: Relentless Earthsiege Diamond", "Token" },
                    { 9, 5, 2, null, 41704, null, "Design: Chaotic Skyflare Diamond", "Token" },
                    { 10, 5, 3, null, 41708, null, "Design: Insightful Earthsiege Diamond", "Token" },
                    { 11, 5, 4, null, 41706, null, "Design: Ember Skyflare Diamond", "Token" },
                    { 12, 5, 5, null, 41709, null, "Design: Invigorating Earthsiege Diamond", "Token" },
                    { 13, 5, 6, null, 41707, null, "Design: Revitalizing Skyflare Diamond", "Token" },
                    { 14, 3, 7, null, 41576, null, "Design: Bold Scarlet Ruby", "Token" },
                    { 15, 3, 8, null, 42138, null, "Design: Solid Sky Sapphire", "Token" },
                    { 16, 3, 9, null, 41577, null, "Design: Delicate Scarlet Ruby", "Token" },
                    { 17, 3, 10, null, 41697, null, "Design: Enduring Forest Emerald", "Token" },
                    { 18, 3, 11, null, 41690, null, "Design: Reckless Monarch Topaz", "Token" },
                    { 19, 3, 12, null, 41580, null, "Design: Rigid Autumn's Glow", "Token" },
                    { 20, 3, 13, null, 41688, null, "Design: Veiled Monarch Topaz", "Token" },
                    { 21, 3, 14, null, 41579, null, "Design: Quick Autumn's Glow", "Token" },
                    { 22, 3, 15, null, 41699, null, "Design: Seer's Forest Emerald", "Token" },
                    { 23, 3, 16, null, 41582, null, "Design: Glinting Monarch Topaz", "Token" },
                    { 24, 3, 17, null, 41689, null, "Design: Luminous Monarch Topaz", "Token" },
                    { 25, 3, 18, null, 41719, null, "Design: Subtle Scarlet Ruby", "Token" },
                    { 26, 3, 19, null, 41703, null, "Design: Regal Twilight Opal", "Token" },
                    { 27, 3, 20, null, 41701, null, "Design: Royal Twilight Opal", "Token" },
                    { 28, 3, 21, null, 41694, null, "Design: Intricate Forest Emerald", "Token" },
                    { 29, 3, 22, null, 41692, null, "Design: Energized Forest Emerald", "Token" },
                    { 30, 3, 23, null, 41581, null, "Design: Lustrous Sky Sapphire", "Token" },
                    { 31, 3, 24, null, 41698, null, "Design: Vivid Forest Emerald", "Token" },
                    { 32, 3, 25, null, 41578, null, "Design: Flashing Scarlet Ruby", "Token" },
                    { 33, 3, 26, null, 41696, null, "Design: Lambent Forest Emerald", "Token" },
                    { 34, 3, 27, null, 41747, null, "Design: Shifting Twilight Opal", "Token" },
                    { 35, 3, 28, null, 41693, null, "Design: Forceful Forest Emerald", "Token" },
                    { 36, 3, 29, null, 41686, null, "Design: Potent Monarch Topaz", "Token" },
                    { 37, 3, 30, null, 41702, null, "Design: Puissant Twilight Opal", "Token" },
                    { 38, 3, 31, null, 41687, null, "Design: Stark Monarch Topaz", "Token" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 38);
        }
    }
}
