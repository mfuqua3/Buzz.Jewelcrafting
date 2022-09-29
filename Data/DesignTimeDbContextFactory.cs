using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Buzz.Jewelcrafting.Data;

[UsedImplicitly]
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BuzzDbContext>
{
    public BuzzDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<BuzzDbContext>();
        builder.UseNpgsql("Server=localhost;Database=buzz-jc;User Id=postgres;Password=password");
        return new BuzzDbContext(builder.Options);
    }
}