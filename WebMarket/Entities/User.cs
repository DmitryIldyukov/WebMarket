using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.Entities;

public class User : BaseEntity
{
    [Required] public string FirstName { get; set; }
    [Required] public string Surname { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string Password { get; set; }
    public string? PhoneNumber { get; set; }
    public DateOnly? BirthDay  { get; set; }
    [Required] public int BasketId { get; set; }
    [ForeignKey(nameof(BasketId))]
    public Basket Basket { get; set; }
    public int RoleId { get; set; }
    [ForeignKey(nameof(RoleId))]
    public Role Role { get; set; }
    public ICollection<Feedback>? Feedbacks { get; set; }
}