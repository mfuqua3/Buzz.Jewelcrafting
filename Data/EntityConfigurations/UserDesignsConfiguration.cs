using Buzz.Jewelcrafting.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buzz.Jewelcrafting.Data.EntityConfigurations;

public class UserDesignsConfiguration : IEntityTypeConfiguration<UserDesign>
{
    public void Configure(EntityTypeBuilder<UserDesign> builder)
    {
        builder.HasKey(x => new { x.UserId, x.DesignId });
    }
}