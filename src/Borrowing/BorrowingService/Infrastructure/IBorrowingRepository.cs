
using LibraryManagementDomain.Domain;

namespace LibraryManagement.Infrastructure;
public interface IBorrowingRepository :  IAsyncRepository<Borrowing>
{
    Task<IEnumerable<Borrowing>> GetBorrowBooks();
}