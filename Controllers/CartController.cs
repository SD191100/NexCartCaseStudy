using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NexCart.Models;
using NexCart.Services.Interfaces;
namespace NexCart.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class CartController : ControllerBase
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [HttpPost]
    public IActionResult AddToCart([FromBody] CartItem cartItem)
    {
        _cartService.AddToCart(cartItem);
        return Ok(new { Message = "Item added to cart" });
    }

    [HttpGet]
    public IActionResult GetCart(int id)
    {
        var cart = _cartService.GetCartByUserId(id);
        return Ok(cart);
    }
}
