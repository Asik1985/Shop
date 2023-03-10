using Microsoft.EntityFrameworkCore;

namespace Shop.Models
{
    public class ShopContext : DbContext
    {

public ShopContext(DbContextOptions<ShopContext> options) : base(options) 
        {
        
        }
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
        public DbSet<Brand> Brands { get; set;}


    }
}
