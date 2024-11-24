using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SimpleShop.Models;

namespace SimpleShop.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShopingCartItem> shopingCartItems { get; set; }
        public DbSet<ShopingCart> shopingCarts { get; set; }
    }
}
