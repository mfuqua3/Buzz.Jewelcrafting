namespace Buzz.Jewelcrafting.Models.Interfaces;

public interface IUnique<T> where T : IEquatable<T>
{
    public T Id { get; set; }
}