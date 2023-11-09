
using BookService.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure;

public class BookDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("microservices");
        BookConfiguration.Configure(modelBuilder.Entity<Book>());
        base.OnModelCreating(modelBuilder);
    }
}
