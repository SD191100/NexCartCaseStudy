using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NexCart.Models;
using NexCart.Services.Interfaces;
namespace NexCart.Controllers;


[ApiController]
[Route("api/[controller]")]
//[Authorize(Roles = "Seller")]
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
    public IActionResult AddProduct([FromBody] Product product)
    {
        _productService.AddProduct(product);
        return CreatedAtAction(nameof(GetProducts), new { id = product.ProductId }, product);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] Product product)
    {
        if (id != product.ProductId) return BadRequest(new { Message = "Product ID mismatch" });

        _productService.UpdateProduct(product);
        return Ok(new { Message = "Product updated successfully" });
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        _productService.DeleteProduct(id);
        return Ok(new { Message = "Product deleted successfully" });
    }
}
