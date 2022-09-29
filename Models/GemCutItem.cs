using System.Text.Json.Serialization;
using Buzz.Jewelcrafting.Models.Interfaces;

namespace Buzz.Jewelcrafting.Models;

public class GemCutItem : IUnique<int>, IItem, IDesign
{
    [JsonIgnore]
    public int Id { get; set; }
    public int? Cost { get; set; }
    public string Name { get; set; }
    public int ItemId { get; set; }
    public string IconName { get; set; }
    public int DesignId { get; set; }
    [JsonIgnore]
    public string DesignIconName { get; set; }
    public string Color { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Stat1 { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Stat2 { get; set; }
}