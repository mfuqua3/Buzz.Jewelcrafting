using Buzz.Jewelcrafting.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buzz.Jewelcrafting.Data.Seeds;

public class JewelrySeeder : IEntityTypeConfiguration<Jewelry>
{
    public void Configure(EntityTypeBuilder<Jewelry> builder)
    {
        builder.HasData(DesignSeed.Designs.Where(x=>x.Jewelry != null).Select(x=>x.Jewelry).ToArray());
    }
}