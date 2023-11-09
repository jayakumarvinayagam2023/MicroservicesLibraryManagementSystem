using LibraryManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure;
public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
{
    public AuthorRepository(AuthorDbContext dbContext) : base(dbContext)
    {
        
    }

    public async Task<Author> GetUsersByAuthorId(Guid authorId)
    {
        var author = await _dbContext.Authors
            .SingleOrDefaultAsync(_ => _.AuthorId == authorId);
        return author;
    }

    public async Task<IEnumerable<Author>> GetUsersByFirstName(string name)
    {
        var authors = await _dbContext.Authors
            .Where(_ => _.Name == name)
            .ToListAsync();
        return authors;
    }
}