using System.ComponentModel.DataAnnotations;

namespace WebMarket.Entities.Dictionaries;

public class DictCategory : BaseEntity
{
    [Required] public string CategoryName { get; set; }
}