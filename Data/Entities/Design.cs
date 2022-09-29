using Buzz.Jewelcrafting.Models.Interfaces;

namespace Buzz.Jewelcrafting.Data.Entities;

public class Design : IUnique<int>, IItem
{
    public int Id { get; set; }
    public int? Cost { get; set; }
    public string Source { get; set; }
    public int ItemId { get; set; }
    public string IconName { get; set; }
    public int? GemCutId { get; set; }
    public int? JewelryId { get; set; }
    public GemCut GemCut { get; set; }
    public Jewelry Jewelry { get; set; }
    public string Name { get; set; }
    public List<UserDesign> UserDesigns { get; set; }
}