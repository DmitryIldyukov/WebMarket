using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.Entities;

public class Feedback : BaseEntity
{
    [Required] 
    public int UserId { get; set; }
    [ForeignKey(nameof(UserId))] 
    public User User { get; set; }
    [Required] 
    public int ProductId { get; set; }
    [ForeignKey(nameof(ProductId))] 
    public Product Product { get; set; }
    [Required] [Range(1,5)]
    public int Rating { get; set; }
    [Required] 
    public string Description { get; set; }
}