using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NexCart.DTOs.Product;
using NexCart.Models;
using NexCart.Services.Interfaces;
namespace NexCart.Controllers;


[ApiController]
[Route("api/[controller]")]

public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = _productService.GetAllProducts();
        return Ok(products);
    }

    [HttpPost]
    [Authorize(Roles = "Seller")]
    public IActionResult AddProduct([FromBody] AddProductReq product)
    {
        _productService.AddProduct(product);
        return CreatedAtAction(nameof(GetProducts), product);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Seller")]
    public IActionResult UpdateProduct(int id, [FromBody] UpdateProductReq product)
    {
        if (id != product.Id) return BadRequest(new { Message = "Product ID mismatch" });

        _productService.UpdateProduct(product);
        return Ok(new { Message = "Product updated successfully" });
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Seller")]
    public IActionResult DeleteProduct(int id)
    {
        _productService.DeleteProduct(id);
        return Ok(new { Message = "Product deleted successfully" });
    }
}
