namespace Buzz.Jewelcrafting.Models;

public class UserStatus
{
    public string UserId { get; set; }
    public string Username { get; set; }
    public List<int> PendingItems { get; set; }
    public List<int> OwnedItems { get; set; }
}