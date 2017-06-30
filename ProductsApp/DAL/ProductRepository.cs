namespace ProductsApp.DAL
{
    using System.Collections.Generic;
    using System.Linq;
    using Interface;
    using ProductsApp.Models;

    /// <summary>
    /// Implement CRUD operation for product entity.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        /// <inheritdoc/>
        public void AddProduct(int id, string name, string category, decimal? price)
        {
            using (var dbContext = new ProductDbContext())
            {
                var newProduct = new Product()
                {
                    Id = id,
                    Name = name,
                    Category = category,
                    Price = price ?? 0M,
                };

                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();
            }
        }

        /// <inheritdoc/>
        public Product GetProduct(int id)
        {
            using (var dbContext = new ProductDbContext())
            {
                var targetProduct = dbContext.Products.FirstOrDefault(p => p.Id == id);
                return targetProduct;
            }
        }

        /// <inheritdoc/>
        public IEnumerable<Product> GetProducts()
        {
            using (var dbContext = new ProductDbContext())
            {
                return dbContext.Products.ToList();
            }
        }

        /// <inheritdoc/>
        public void UpdateProduct(int id, string name, string category, decimal? price)
        {
            using (var dbContext = new ProductDbContext())
            {
                var targetProduct = dbContext.Products.FirstOrDefault(p => p.Id == id);

                if (targetProduct != null)
                {
                    targetProduct.Name = string.IsNullOrWhiteSpace(name) ? targetProduct.Name : name;
                    targetProduct.Category = string.IsNullOrWhiteSpace(category) ? targetProduct.Category : category;
                    targetProduct.Price = price ?? targetProduct.Price;
                    dbContext.SaveChanges();
                }
            }
        }

        /// <inheritdoc/>
        public void DeleteProduct(int id)
        {
            using (var dbContext = new ProductDbContext())
            {
                var targetProduct = dbContext.Products.FirstOrDefault(p => p.Id == id);

                if (targetProduct != null)
                {
                    dbContext.Products.Remove(targetProduct);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}