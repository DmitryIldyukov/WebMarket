using System.ComponentModel.DataAnnotations;

namespace WebMarket.Entities;

public abstract class BaseEntity
{
    [Required] [Key] public int Id { get; set; }
    [Required] public DateTime CreatedAt { get; set; }
    [Required] public DateTime UpdatedAt { get; set; }
    [Required] public bool IsDeleted { get; set; }
}