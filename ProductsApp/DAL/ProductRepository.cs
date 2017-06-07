using ProductsApp.Interface;
using ProductsApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductsApp.DAL
{
    /// <summary>
    /// Implement CRUD operation for product entity.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(int id, string name, string category, decimal? price)
        {
            using (var dbContext = new ProductDbContext())
            {
                var newProduct = new Product()
                {
                    Id = id,
                    Name = name,
                    Category = category,
                    Price = price ?? 0M
                };

                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();
            }
        }

        public Product GetProduct(int id)
        {
            using(var dbContext=new ProductDbContext())
            {
                var targetProduct = dbContext.Products.FirstOrDefault(p => p.Id == id);
                return targetProduct;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var dbContext = new ProductDbContext())
            {
                return dbContext.Products.ToList();
            }
        }

        public void UpdateProduct(int id, string name, string category, decimal? price)
        {
            using(var dbContext =new ProductDbContext())
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

        public void DeleteProduct(int id)
        {
            using(var dbContext =new ProductDbContext())
            {
                var targetProduct = dbContext.Products.FirstOrDefault(p => p.Id == id);

                if(targetProduct!=null)
                {
                    dbContext.Products.Remove(targetProduct);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}