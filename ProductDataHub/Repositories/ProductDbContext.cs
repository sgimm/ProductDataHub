using Microsoft.EntityFrameworkCore;
using ProductDataHub.Entities;

namespace ProductDataHub.Repositories
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Measurements> Measurements { get; set; }
    }
}