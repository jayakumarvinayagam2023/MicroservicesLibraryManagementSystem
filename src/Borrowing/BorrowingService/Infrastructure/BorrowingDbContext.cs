using LibraryManagementDomain.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure;

public class BorrowingDbContext : DbContext
{
    public DbSet<Borrowing> Borrowings { get; set; }
    public BorrowingDbContext(DbContextOptions<BorrowingDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("microservices");
        BorrowingConfiguration.Configure(modelBuilder.Entity<Borrowing>());
        base.OnModelCreating(modelBuilder);
    }
}