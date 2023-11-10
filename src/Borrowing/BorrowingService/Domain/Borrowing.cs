namespace LibraryManagementDomain.Domain;

public class Borrowing : EntityBase
{
    public Guid BorrowingId { get; set; }
    public Guid BookId { get; set; }
    public DateTime? BorrowingDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public string? User { get; set; }
}