namespace Buzz.Jewelcrafting.Models.Interfaces;

public interface IPaginated
{
    public int Page { get; set; }

    public int PageSize { get; set; }
}