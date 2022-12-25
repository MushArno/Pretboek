using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pretboek.Areas.Identity.Data;

namespace Pretboek.Data;

public class PretboekContext : IdentityDbContext<PretboekUser>
{
    public PretboekContext(DbContextOptions<PretboekContext> options)
        : base(options)
    {
    }
    public DbSet<Pretboek.Models.Post> Post { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
