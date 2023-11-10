using LibraryManagement.Infrastructure;
using LibraryManagementDomain.Domain;

namespace LibraryManagement.Application;

public class BorrowingApplicationService : IBorrowingService
{
    private readonly IBorrowingRepository _BorrowingRepository;

    public BorrowingApplicationService(IBorrowingRepository BorrowingRepository)
    {
        _BorrowingRepository = BorrowingRepository;
    }

    public async Task<Borrowing> CreateBorrowingAsync(Borrowing Borrowing)
    {
        await _BorrowingRepository.AddAsync(Borrowing);
        return Borrowing;
    }

    public async Task<IEnumerable<Borrowing>> GetBorrowBooks()
    {
         var borrowedBooks = await _BorrowingRepository.GetBorrowBooks();
        return borrowedBooks;
    }

    public async Task<IReadOnlyList<Borrowing>>  GetBorrowingAsync() => await _BorrowingRepository.GetAllAsync();

    public async Task<Borrowing> GetBorrowingAsync(Guid id) => await _BorrowingRepository.GetByIdAsync(id);

    public async Task<bool> RemoveBorrowingAsync(Guid id)
    {
        var borrowing = await _BorrowingRepository.GetByIdAsync(id);
        await _BorrowingRepository.DeleteAsync(borrowing);
        return true;
    }

    public async Task<Borrowing> UpdateBorrowingAsync(Guid id, Borrowing borrowing)
    {
         var existingBorrowing = await _BorrowingRepository.GetByIdAsync(id);
        if(existingBorrowing is not null)
            await _BorrowingRepository.UpdateAsync(borrowing);            
        return borrowing;
    }
}
