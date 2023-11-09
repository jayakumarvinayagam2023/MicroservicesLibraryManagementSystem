
using System;
namespace LibraryManagement.Domain;

public class EntityBase
{
    public Guid Id { get; set; }
    public string CreatedBy { get; set; } = "Jay";
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public string LastModifiedBy { get; set; } = "Jay";
    public DateTime? LastModifiedDate { get; set; } = DateTime.Now;
}