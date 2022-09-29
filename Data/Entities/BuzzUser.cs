using Buzz.Jewelcrafting.Models.Interfaces;

namespace Buzz.Jewelcrafting.Data.Entities;

public class BuzzUser : IUnique<int>, INamed
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ulong DiscordId { get; set; }
    public List<UserDesign> UserDesigns { get; set; }
}