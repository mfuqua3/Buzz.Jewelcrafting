using System.ComponentModel.DataAnnotations;
using Buzz.Jewelcrafting.Models.Interfaces;

namespace Buzz.Jewelcrafting.Data.Entities;

public class UserDesign : ITracked
{
    public int UserId { get; set; }
    public int DesignId { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Design Design { get; set; }
    public BuzzUser User { get; set; }
}