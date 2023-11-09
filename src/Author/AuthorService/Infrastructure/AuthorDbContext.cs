
using LibraryManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure;

public class AuthorDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public AuthorDbContext(DbContextOptions<AuthorDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.HasDefaultSchema("microservices");
        AuthorConfiguration.Configure(modelBuilder.Entity<Author>());
        base.OnModelCreating(modelBuilder);
    }
}
