using Buzz.Jewelcrafting.Models.Interfaces;

namespace Buzz.Jewelcrafting.Data.Entities;

public class Jewelry : IUnique<int>, IItem
{
    public int Id { get; set; }
    public string InventorySlot { get; set; }

    public string Name { get; set; }
    public int ItemId { get; set; }
    public string IconName { get; set; }
}