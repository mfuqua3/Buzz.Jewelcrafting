using Buzz.Jewelcrafting.Models.Interfaces;

namespace Buzz.Jewelcrafting.Data.Entities;

public class BuzzUser : IUnique<string>, INamed
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List<UserDesign> UserDesigns { get; set; }
}