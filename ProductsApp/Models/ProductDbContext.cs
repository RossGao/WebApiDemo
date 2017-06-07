using System.Data.Entity;

namespace ProductsApp.Models
{
    public partial class ProductDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("MARKETMANAGER");   // Schema is the user name
        }

        public ProductDbContext() : base("MarketDbContext")
        {
            Database.SetInitializer<ProductDbContext>(null);
        }

        public DbSet<Product> Products { get; set; }
        //public DbSet<Material> Materials { get; set; }
    }
}