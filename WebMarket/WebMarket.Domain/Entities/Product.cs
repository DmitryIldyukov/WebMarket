using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebMarket.Entities.Dictionaries;

namespace WebMarket.Entities;

public class Product : BaseEntity
{
    [Required] public string ProductName { get; set; }
    [Required] public decimal Cost { get; set; }
    [Required] public int Count { get; set; }
    [Required] public string Description { get; set; }
    [Required] public int DictCategoryId { get; set; }
    [ForeignKey(nameof(DictCategoryId))]
    public DictCategory DictCategory { get; set; }
    public ICollection<ProductInBasket>? Baskets { get; set; }
    public ICollection<Feedback>? Feedbacks { get; set; }
}