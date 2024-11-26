using NexCart.Models;

namespace NexCart.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
        IEnumerable<Product> GetAllProducts();
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
