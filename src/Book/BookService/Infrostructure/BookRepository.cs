using BookService.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure;
public class BookRepository : RepositoryBase<Book>, IBookRepository
{
    public BookRepository(BookDbContext dbContext) : base(dbContext)
    {
        
    }

    public async Task<Book> GetUsersByBookId(Guid BookId)
    {
        var Book = await _dbContext.Books
            .SingleOrDefaultAsync(_ => _.BookId == BookId);
        return Book;
    }

    public async Task<IEnumerable<Book>> GetUsersByFirstName(string title)
    {
        var books = await _dbContext.Books
            .Where(_ => _.Title == title)
            .ToListAsync();
        return books;
    }

    public async Task<Book> GetUsersByISBN(string isbn)
    {
         var book = await _dbContext.Books
            .SingleOrDefaultAsync(_ => _.ISBN == isbn);
        return book;
    }

    public async Task<IEnumerable<Book>> GetUsersByStatus(BookStatus status)
    {
        var books = await _dbContext.Books
            .Where(_ => _.Status == status)
            .ToListAsync();
        return books;
    }
}