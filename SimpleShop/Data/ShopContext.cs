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
        public DbSet<ShopingCartItem> ShopingCartItems { get; set; }
        public DbSet<ShopingCart> ShopingCarts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
