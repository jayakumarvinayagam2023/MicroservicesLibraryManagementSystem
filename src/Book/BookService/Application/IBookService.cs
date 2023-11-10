

using BookService.Domain;

namespace LibraryManagement.Application;

public interface IBookService
{
    Task<IReadOnlyList<Book>> GetBookAsync();
    Task<Book> GetBookAsync(Guid id);
    Task<Book> CreateBookAsync(Book Book);
    Task<Book> UpdateBookAsync(Guid id, Book Book);
    Task<bool> RemoveBookAsync(Guid id);
    Task<Book> GetUsersByISBN(string isbn);
    Task<IEnumerable<Book>> GetUsersByStatus(BookStatus status);
}