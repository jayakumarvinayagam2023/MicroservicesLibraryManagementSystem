using LibraryManagementDomain;
namespace BookService.Domain;
public class Book : EntityBase
{
    public string? Title { get; set; }
    public string? ISBN { get; set; }
    public string? author { get; set; }
    public BookStatus status { get; set; }
}