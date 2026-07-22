using Microsoft.AspNetCore.Mvc;
using ProductCRUDAPI.Models;

namespace ProductCRUDAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 65000, Quantity = 10 },
            new Product { Id = 2, Name = "Keyboard", Price = 1200, Quantity = 50 },
            new Product { Id = 3, Name = "Mouse", Price = 800, Quantity = 40 }
        };

        // GET: api/product
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(products);
        }

        // GET: api/product/1
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound("Product not found.");

            return Ok(product);
        }

        // POST: api/product
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            products.Add(product);

            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // PUT: api/product/1
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound("Product not found.");

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Quantity = updatedProduct.Quantity;

            return NoContent();
        }

        // PATCH: api/product/1/price
        [HttpPatch("{id}/price")]
        public IActionResult UpdatePrice(int id, [FromBody] decimal price)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound("Product not found.");

            product.Price = price;

            return Ok(product);
        }

        // DELETE: api/product/1
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound("Product not found.");

            products.Remove(product);

            return NoContent();
        }
    }
}