using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.Entities;

public class Basket : BaseEntity
{
    [Required] public int UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    [Required] public User User { get; set; }
    public ICollection<ProductInBasket>? Products { get; set; }
}