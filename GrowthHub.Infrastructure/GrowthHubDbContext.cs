using GrowthHub.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrowthHub.Infrastructure;

public class GrowthHubDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public GrowthHubDbContext(DbContextOptions<GrowthHubDbContext> options)
        : base(options)
    {
    }
    
    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder
            .Entity<User>()
            .HasMany(x => x.Transactions)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .Entity<User>()
            .HasOne(x => x.MoneyDistribution)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.Cascade);
    }
}