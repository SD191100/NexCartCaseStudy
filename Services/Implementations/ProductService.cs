using NexCart.Models;
using NexCart.Repositories.Interfaces;
using NexCart.Services.Interfaces;

namespace NexCart.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProductById(int productId)
        {
            return _productRepository.GetProductById(productId);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }

        public void DeleteProduct(int productId)
        {
            _productRepository.Delete(productId);
        }
    }
}
