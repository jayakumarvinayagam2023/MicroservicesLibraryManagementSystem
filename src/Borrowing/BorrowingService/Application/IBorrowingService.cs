
using LibraryManagementDomain.Domain;

namespace LibraryManagement.Application;

public interface IBorrowingService
{
    Task<IReadOnlyList<Borrowing>> GetBorrowingAsync();
    Task<Borrowing> GetBorrowingAsync(Guid id);
    Task<Borrowing> CreateBorrowingAsync(Borrowing Borrowing);
    Task<Borrowing> UpdateBorrowingAsync(Guid id, Borrowing Borrowing);
    Task<bool> RemoveBorrowingAsync(Guid id);
    Task<IEnumerable<Borrowing>> GetBorrowBooks();
}