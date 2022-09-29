namespace Buzz.Jewelcrafting.Models.Interfaces;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }
}