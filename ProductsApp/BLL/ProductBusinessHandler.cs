using ProductsApp.Interface;
using ProductsApp.Models;
using System.Collections.Generic;

namespace ProductsApp.BLL
{
    public class ProductBusinessHandler : IProductBusinessHandler
    {
        private IProductRepository productRepository;

        public ProductBusinessHandler(IProductRepository theRepository)
        {
            productRepository = theRepository;
        }

        public void AddProduct(Product newProduct)
        {
            if (newProduct != null)
            {
                productRepository.AddProduct(newProduct.Id, newProduct.Name, newProduct.Category, newProduct.Price);
            }
        }

        public Product GetProduct(int id)
        {
            return productRepository.GetProduct(id);
        }


        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }


        public void UpdateProduct(int id, string name, string category, decimal? price)
        {
            productRepository.UpdateProduct(id, name, category, price);
        }

        public void DeleteProduct(int id)
        {
            productRepository.DeleteProduct(id);
        }
    }
}