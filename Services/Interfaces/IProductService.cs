using NexCart.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using NexCart.Data;
using NexCart.DTOs.Product;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace NexCart.Services.Interfaces
{
    public interface IProductService
    {
        Product GetProductById(int productId);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(AddProductReq product);
        void UpdateProduct(UpdateProductReq product);
        void DeleteProduct(int productId);
    }
}