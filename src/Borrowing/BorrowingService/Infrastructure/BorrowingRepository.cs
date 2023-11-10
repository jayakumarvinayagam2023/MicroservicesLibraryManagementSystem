
using LibraryManagementDomain.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure;
public class BorrowingRepository : RepositoryBase<Borrowing>, IBorrowingRepository
{
    public BorrowingRepository(BorrowingDbContext dbContext) : base(dbContext)
    {
        
    }
    public async Task<IEnumerable<Borrowing>> GetBorrowBooks()
    {
        var borrowedBooks = await (_dbContext.Borrowings
        .Where(_=> _.BorrowingDate.HasValue)
        .ToListAsync<Borrowing>());          
        return borrowedBooks;
    }
}