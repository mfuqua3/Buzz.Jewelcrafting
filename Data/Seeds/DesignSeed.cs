using Buzz.Jewelcrafting.Data.Entities;
using Buzz.Jewelcrafting.Models.Interfaces;

namespace Buzz.Jewelcrafting.Data.Seeds;

public static class DesignSeed
{
    private const string EarthsiegeIcon = "inv_jewelcrafting_shadowspirit_02";
    private const string SkyflareIcon = "inv_jewelcrafting_icediamond_02";
    private const string RedIcon = "inv_jewelcrafting_gem_28";
    private const string BlueIcon = "inv_jewelcrafting_gem_27";
    private const string YellowIcon = "inv_jewelcrafting_gem_26";
    private const string OrangeIcon = "inv_jewelcrafting_gem_30";
    private const string PurpleIcon = "inv_jewelcrafting_gem_29";
    private const string GreenIcon = "inv_jewelcrafting_gem_25";
    private static int _ids = 1;
    private static int _jewelryIds = 1;
    private static int _cutIds = 1;

    public static List<Design> Designs = new()
    {
        Ring("Titanium Earthguard Ring", 42649, 42643, "inv_jewelry_ring_59"),
        Ring("Titanium Spellshock Ring", 42650, 42644, "inv_jewelry_ring_63"),
        Ring("Titanium Frostguard Ring", 43597, 43582, "inv_jewelry_ring_57"),
        Ring("Titanium Impact Band", 42648, 42642, "inv_jewelry_ring_55"),
        Neck("Titanium Impact Choker", 42651, 42645, "inv_jewelry_necklace_14"),
        Neck("Titanium Spellshock Necklace", 42653, 42647, "inv_jewelry_necklace_35"),
        Neck("Titanium Earthguard Chain", 42652, 42646, "inv_jewelry_necklace_33"),
        Earthsiege("Relentless Earthsiege Diamond", 41710, 41398),
        Skyflare("Chaotic Skyflare Diamond", 41704, 41258),
        Earthsiege("Insightful Earthsiege Diamond", 41708, 41401),
        Skyflare("Ember Skyflare Diamond", 41706, 41333),
        Earthsiege("Invigorating Earthsiege Diamond", 41709, 41385),
        Skyflare("Revitalizing Skyflare Diamond", 41707, 41376),
        Red("Bold Scarlet Ruby", 41576, 39996, "Strength"),
        Blue("Solid Sky Sapphire", 42138, 40008, "Stamina"),
        Red("Delicate Scarlet Ruby", 41577, 39997, "Agility"),
        Green("Enduring Forest Emerald", 41697, 40089, "Defense Rating", "Stamina"),
        Orange("Reckless Monarch Topaz", 41690, 40051, "Spell Power", "Haste"),
        Yellow("Rigid Autumn's Glow", 41580, 40014, "Hit Rating"),
        Orange("Veiled Monarch Topaz", 41688, 40049, "Spell Power", "Hit Rating"),
        Yellow("Quick Autumn's Glow", 41579, 40017, "Haste Rating"),
        Green("Seer's Forest Emerald", 41699, 40092, "Intellect", "Spirit"),
        Orange("Glinting Monarch Topaz", 41582, 40044, "Agility", "Hit Rating"),
        Orange("Luminous Monarch Topaz", 41689, 40047, "Luminous", "Intellect"),
        Red("Subtle Scarlet Ruby", 41719, 40000, "Dodge Rating"),
        Purple("Regal Twilight Opal", 41703, 40031, "Dodge Rating", "Stamina"),
        Purple("Royal Twilight Opal", 41701, 40027, "Spell Power", "Mp5"),
        Green("Intricate Forest Emerald", 41694, 40104, "Haste Rating", "Spirit"),
        Green("Energized Forest Emerald", 41692, 40105, "Haste Rating", "Mp5"),
        Blue("Lustrous Sky Sapphire", 41581, 40010, "Mp5"),
        Green("Vivid Forest Emerald", 41698, 40088, "Hit Rating", "Stamina"),
        Red("Flashing Scarlet Ruby", 41578, 40001, "Parry Rating"),
        Green("Lambent Forest Emerald", 41696, 40100, "Hit Rating", "Mp5"),
        Purple("Shifting Twilight Opal", 41747, 40023, "Agility", "Stamina"),
        Green("Forceful Forest Emerald", 41693, 40091, "Haste Rating", "Stamina"),
        Orange("Potent Monarch Topaz", 41686, 40048, "Spell Power", "Critical Strike Rating"),
        Purple("Puissant Twilight Opal", 41702, 40033, "Armor Penetration Rating", "Stamina"),
        Orange("Stark Monarch Topaz", 41687, 40055, "Attack Power", "Haste Rating"),
    };

    private static Design Earthsiege(string name, int designId, int itemId)
        => Meta(name, designId, itemId, EarthsiegeIcon);

    private static Design Skyflare(string name, int designId, int itemId)
        => Meta(name, designId, itemId, SkyflareIcon);

    private static Design Meta(string name, int designId, int itemId, string iconName)
        => Cut(JewelColor.Meta, Parameters(designId, name, 5), iconName, itemId);

    private static Design Red(string name, int designId, int itemId, string stat, int cost = 3)
        => Cut(JewelColor.Red, Parameters(designId, name, cost), RedIcon, itemId, stat);

    private static Design Blue(string name, int designId, int itemId, string stat, int cost = 3)
        => Cut(JewelColor.Blue, Parameters(designId, name, cost), BlueIcon, itemId, stat);

    private static Design Yellow(string name, int designId, int itemId, string stat, int cost = 3)
        => Cut(JewelColor.Yellow, Parameters(designId, name, cost), YellowIcon, itemId, stat);

    private static Design Orange(string name, int designId, int itemId, string stat1, string stat2, int cost = 3)
        => Cut(JewelColor.Orange, Parameters(designId, name, cost), OrangeIcon, itemId, stat1, stat2);

    private static Design Purple(string name, int designId, int itemId, string stat1, string stat2, int cost = 3)
        => Cut(JewelColor.Purple, Parameters(designId, name, cost), PurpleIcon, itemId, stat1, stat2);

    private static Design Green(string name, int designId, int itemId, string stat1, string stat2, int cost = 3)
        => Cut(JewelColor.Green, Parameters(designId, name, cost), GreenIcon, itemId, stat1, stat2);

    private static Design Neck(string name, int designId, int itemId, string iconName,
        int cost = 6)
        => Jewelry(JewelryType.Neck, Parameters(designId, name, cost), iconName, itemId);

    private static Design Ring(string name, int designId, int itemId, string iconName, int cost = 6)
        => Jewelry(JewelryType.Ring, Parameters(designId, name, cost), iconName, itemId);

    private static DesignParams Parameters(int designId, string name, int cost)
        => new DesignParams()
        {
            ItemId = designId,
            Name = name,
            Cost = cost,
            IconName = "inv_scroll_05"
        };

    private static Design Cut(JewelColor color, DesignParams designParams, string iconName, int itemId,
        string stat1 = null, string stat2 = null)
    {
        var design = Design(designParams);
        design.GemCut = new GemCut
        {
            Id = _cutIds++,
            ItemId = itemId,
            IconName = iconName,
            Stat1 = stat1,
            Stat2 = stat2,
            Color = color.ToString()
        };
        return design;
    }

    private static Design Jewelry(JewelryType jewelryType, DesignParams designParams, string iconName, int itemId)
    {
        var design = Design(designParams);
        design.Jewelry = new Jewelry
        {
            Id = _jewelryIds++,
            ItemId = itemId,
            IconName = iconName,
            Name = design.Name,
            InventorySlot = jewelryType.ToString()
        };
        return design;
    }

    private static Design Design(DesignParams designParams)
    {
        return new Design
        {
            Id = _ids++,
            Name = $"Design: {designParams.Name}",
            IconName = designParams.IconName,
            ItemId = designParams.ItemId,
            Cost = designParams.Cost,
            Source = "Token"
        };
    }

    private class DesignParams : IItem
    {
        public string Name { get; set; }
        public int ItemId { get; set; }
        public string IconName { get; set; }
        public int Cost { get; set; }
    }

    private enum JewelColor
    {
        Meta,
        Red,
        Blue,
        Yellow,
        Orange,
        Purple,
        Green
    }

    private enum JewelryType
    {
        Ring,
        Neck
    }
}