using BookService.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure;

public static class BookConfiguration
{
    public static void Configure(EntityTypeBuilder<Book> endityBuilder)
    {
        endityBuilder.HasKey(x=>x.Id);           
    }
}