
using LibraryManagementDomain.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure;

public static class BorrowingConfiguration
{
    public static void Configure(EntityTypeBuilder<Borrowing> endityBuilder)
    {
        endityBuilder.HasKey(x=>x.Id);           
    }
}