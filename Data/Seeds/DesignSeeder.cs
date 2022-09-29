using Buzz.Jewelcrafting.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buzz.Jewelcrafting.Data.Seeds;

public class DesignSeeder : IEntityTypeConfiguration<Design>
{
    public void Configure(EntityTypeBuilder<Design> builder)
    {
        builder.HasData(DesignSeed.Designs.Select(Clone).ToArray());
    }


    private Design Clone(Design from)
    {
        return new Design
        {
            Id = from.Id,
            Cost = from.Cost,
            Source = from.Source,
            ItemId = from.ItemId,
            GemCutId = from.GemCut?.Id,
            JewelryId = from.Jewelry?.Id,
            Name = from.Name
        };
    }
}