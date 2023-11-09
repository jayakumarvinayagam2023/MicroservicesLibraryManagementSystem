using LibraryManagement.Domain;

namespace LibraryManagement.Infrastructure;
public interface IAuthorRepository :  IAsyncRepository<Author>
{
    Task<Author> GetUsersByAuthorId(Guid authorId);
    Task<IEnumerable<Author>> GetUsersByFirstName(string name);
}