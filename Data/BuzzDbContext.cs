using System.Reflection;
using Buzz.Jewelcrafting.Data.Entities;
using Buzz.Jewelcrafting.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Buzz.Jewelcrafting.Data;

public class BuzzDbContext : DbContext
{
    public BuzzDbContext(DbContextOptions<BuzzDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<BuzzUser> Users { get; set; }
    public DbSet<Design> Designs { get; set; }
    public DbSet<GemCut> GemCuts { get; set; }
    public DbSet<Jewelry> Jewelry { get; set; }
    public DbSet<UserDesign> UserDesigns { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.ApplySoftDeleteQueryFilters();
        base.OnModelCreating(modelBuilder);
    }
    
    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = new())
    {
        this.ProcessCustomInterfaces();
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
}