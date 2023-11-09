using LibraryManagement.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure;

public static class AuthorConfiguration
{
    public static void Configure(EntityTypeBuilder<Author> endityBuilder)
    {
        endityBuilder.HasKey(x=>x.Id);           
    }
}