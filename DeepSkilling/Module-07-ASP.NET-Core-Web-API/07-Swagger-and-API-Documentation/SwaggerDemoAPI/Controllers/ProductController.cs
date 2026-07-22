using Microsoft.AspNetCore.Mvc;
using SwaggerDemoAPI.Models;

namespace SwaggerDemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> products =
        [
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 65000,
                Quantity = 5
            },

            new Product
            {
                Id = 2,
                Name = "Keyboard",
                Price = 1200,
                Quantity = 25
            }
        ];

        /// <summary>
        /// Returns all available products.
        /// </summary>
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(products);
        }

        /// <summary>
        /// Returns a product using its ID.
        /// </summary>
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}