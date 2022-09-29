using System.ComponentModel.DataAnnotations.Schema;
using Buzz.Jewelcrafting.Models.Interfaces;

namespace Buzz.Jewelcrafting.Data.Entities;

public class GemCut : IUnique<int>, IItem
{
    public int Id { get; set; }
    public string Color { get; set; }
    public string Stat1 { get; set; }
    public string Stat2 { get; set; }
    public int ItemId { get; set; }
    public string IconName { get; set; }

    [NotMapped]
    public bool Hybrid => !string.IsNullOrEmpty(Stat2);

    public string Name { get; set; }
}