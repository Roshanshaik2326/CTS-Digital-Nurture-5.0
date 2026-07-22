using ProductManagementAPI.Models;

namespace ProductManagementAPI.Services
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product? GetById(int id);

        void Add(Product product);

        bool Update(int id, Product product);

        bool Delete(int id);
    }
}