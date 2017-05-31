using System.Data.Entity;

namespace ProductsApp.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("Products")
        { }

        public DbSet<Product> Products { get; set; }
    }
}