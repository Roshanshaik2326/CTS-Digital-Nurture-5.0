using ProductManagementAPI.Models;

namespace ProductManagementAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> products =
        [
            new Product { Id = 1, Name = "Laptop", Price = 65000, Quantity = 10 },
            new Product { Id = 2, Name = "Keyboard", Price = 1200, Quantity = 25 }
        ];

        public List<Product> GetAll() => products;

        public Product? GetById(int id)
            => products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            products.Add(product);
        }

        public bool Update(int id, Product product)
        {
            var existing = GetById(id);

            if (existing == null)
                return false;

            existing.Name = product.Name;
            existing.Price = product.Price;
            existing.Quantity = product.Quantity;

            return true;
        }

        public bool Delete(int id)
        {
            var product = GetById(id);

            if (product == null)
                return false;

            products.Remove(product);

            return true;
        }
    }
}