using LibraryManagementDomain;

namespace BookService.Domain;
public class Book : EntityBase
{
    public Guid BookId { get; set; }
    public string? Title { get; set; }
    public string? ISBN { get; set; }
    public Guid Author { get; set; }
    public BookStatus Status { get; set; }
}