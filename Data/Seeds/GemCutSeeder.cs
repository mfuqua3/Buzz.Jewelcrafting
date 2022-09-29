using Buzz.Jewelcrafting.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buzz.Jewelcrafting.Data.Seeds;

public class GemCutSeeder : IEntityTypeConfiguration<GemCut>
{
    public void Configure(EntityTypeBuilder<GemCut> builder)
    {
        builder.HasData(DesignSeed.Designs.Where(x=>x.GemCut != null).Select(x=>x.GemCut).ToArray());
    }
}