using NexCart.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using NexCart.Data;

namespace NexCart.Services.Interfaces
{
    public interface IProductService
    {
        Product GetProductById(int productId);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}