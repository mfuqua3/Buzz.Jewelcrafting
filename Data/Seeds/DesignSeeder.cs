using Buzz.Jewelcrafting.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buzz.Jewelcrafting.Data.Seeds;

public class DesignSeeder : IEntityTypeConfiguration<Design>
{
    public void Configure(EntityTypeBuilder<Design> builder)
    {
        builder.HasData(GetSeed());
    }

    private IEnumerable<Design> GetSeed()
    {
        var designs = DesignSeed.Designs;
        foreach (var design in designs)
        {
            if (design.GemCut != null)
            {
                design.GemCutId = design.GemCut.Id;
                design.GemCut = null;
                yield return design;
            }

            if (design.Jewelry != null)
            {
                design.JewelryId = design.Jewelry.Id;
                design.Jewelry = null;
                yield return design;
            }
        }
    }
}