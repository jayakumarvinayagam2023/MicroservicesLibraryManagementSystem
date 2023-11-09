
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibraryManagement.Domain;


[Table("Authors")]
public class Author : EntityBase
{
    public Guid AuthorId { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Country { get; set; }
}