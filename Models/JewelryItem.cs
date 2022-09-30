using System.Text.Json.Serialization;
using Buzz.Jewelcrafting.Models.Interfaces;

namespace Buzz.Jewelcrafting.Models;

public class JewelryItem : IUnique<int>, IItem, IDesign
{
    public int Id { get; set; }
    public int? Cost { get; set; }
    public string Name { get; set; }
    public int ItemId { get; set; }
    public string IconName { get; set; }
    public int DesignId { get; set; }
    public string InventorySlot { get; set; }
    [JsonIgnore]
    public string DesignIconName { get; set; }
}