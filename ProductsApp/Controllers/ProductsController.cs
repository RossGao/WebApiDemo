using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        [Route("")]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        [Route("{id}")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [Route("cached")]
        public HttpResponseMessage GetCachedMessage()
        {
            var responseMessage = Request.CreateResponse(HttpStatusCode.OK, "This message is not from cache."); // Set response message content which is defaultyly be xml.
            responseMessage.Content = new StringContent("Hello, I will replace the response content.", Encoding.Unicode);   // Set response message content as plain text.
            responseMessage.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(2)    // The client will cache the response in 2 minutes.
            };

            return responseMessage;
        }
    }
}