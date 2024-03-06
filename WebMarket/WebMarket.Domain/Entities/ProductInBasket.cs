using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.Entities;

public class ProductInBasket : BaseEntity
{
    [Required] public int ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    [Required] public Product Product { get; set; }
    [Required] public int BasketId { get; set; }
    [ForeignKey(nameof(BasketId))]
    [Required] public Basket Basket { get; set; }
}