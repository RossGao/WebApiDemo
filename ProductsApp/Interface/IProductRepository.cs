using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductsApp.Models;

namespace ProductsApp.Interface
{
    public interface IProductRepository
    {
        void AddProduct(int id, string name, string category, decimal? price);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        void UpdateProduct(int id, string name, string category, decimal? price);
        void DeleteProduct(int id);
    }
}