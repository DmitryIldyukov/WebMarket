using Microsoft.EntityFrameworkCore;
using WebMarket.Entities;
using WebMarket.Entities.Dictionaries;

namespace WebMarket.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }  
    
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductInBasket> ProductInBaskets { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<DictCategory> DictCategories { get; set; }
}