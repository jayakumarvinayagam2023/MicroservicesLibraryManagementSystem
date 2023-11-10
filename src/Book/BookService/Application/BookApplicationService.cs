using BookService.Domain;
using LibraryManagement.Infrastructure;

namespace LibraryManagement.Application;

public class BookApplicationService : IBookService
{
    private readonly IBookRepository _BookRepository;

    public BookApplicationService(IBookRepository BookRepository)
    {
        _BookRepository = BookRepository;
    }

    public async Task<Book> CreateBookAsync(Book Book)
    {
        await _BookRepository.AddAsync(Book);
        return Book;
    }

    public async Task<IReadOnlyList<Book>>  GetBookAsync() => await _BookRepository.GetAllAsync();

    public async Task<Book> GetBookAsync(Guid id) => await _BookRepository.GetUsersByBookId(id);

    public async Task<Book> GetUsersByISBN(string isbn) => await _BookRepository.GetUsersByISBN(isbn);

    public async Task<IEnumerable<Book>> GetUsersByStatus(BookStatus status) => await _BookRepository.GetUsersByStatus(status);

    public async Task<bool> RemoveBookAsync(Guid id)
    {
        var Book = await _BookRepository.GetByIdAsync(id);
        await _BookRepository.DeleteAsync(Book);
        return true;
    }

    public async Task<Book> UpdateBookAsync(Guid id, Book Book)
    {
        var existingBook = await _BookRepository.GetByIdAsync(id);
        if(existingBook is not null)
            await _BookRepository.UpdateAsync(Book);            
        return Book;
    }
}
