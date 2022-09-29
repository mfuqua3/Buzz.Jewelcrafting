namespace Buzz.Jewelcrafting.Models.Interfaces;

public interface IItem : INamed
{
    public int ItemId { get; set; }
    public string IconName { get; set; }
}