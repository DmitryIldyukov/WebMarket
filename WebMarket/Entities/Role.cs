using System.ComponentModel.DataAnnotations;
using WebMarket.Enums;

namespace WebMarket.Entities;

public class Role : BaseEntity
{
    [Required] public string RoleName { get; set; }
    [Required] public RoleType RoleType { get; set; } 
    public ICollection<User>? Users { get; set; }
}