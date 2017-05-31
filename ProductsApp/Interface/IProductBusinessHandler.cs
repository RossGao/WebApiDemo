using ProductsApp.Models;
using System.Collections.Generic;

namespace ProductsApp.Interface
{
    public interface IProductBusinessHandler
    {
        void AddProduct(Product newProduct);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        void UpdateProduct(int id, string name, string category, decimal? price);
        void DeleteProduct(int id);
    }
}