
using LibraryManagement.Domain;

namespace LibraryManagement.Application;

public interface IAuthorService
{
    Task<IReadOnlyList<Author>> GetAuthorAsync();
    Task<Author> GetAuthorAsync(Guid id);
    Task<Author> CreateAuthorAsync(Author author);
    Task<Author> UpdateAuthorAsync(Guid id, Author author);
    Task<bool> RemoveAuthorAsync(Guid id);
}