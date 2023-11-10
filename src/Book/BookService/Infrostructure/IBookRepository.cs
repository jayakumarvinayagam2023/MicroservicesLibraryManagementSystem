using BookService.Domain;

namespace LibraryManagement.Infrastructure;
public interface IBookRepository :  IAsyncRepository<Book>
{
    Task<Book> GetUsersByBookId(Guid BookId);
    Task<IEnumerable<Book>> GetUsersByFirstName(string title);
    Task<Book> GetUsersByISBN(string isbn);
    Task<IEnumerable<Book>> GetUsersByStatus(BookStatus status);
}