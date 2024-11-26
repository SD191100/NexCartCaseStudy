using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NexCart.Models;
using NexCart.Services.Interfaces;
namespace NexCart.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public IActionResult PlaceOrder([FromBody] Order order)
    {
        _orderService.PlaceOrder(order);
        return Ok(new { Message = "Order placed successfully" });
    }

    [HttpGet("{id}")]
    public IActionResult GetOrder(int id)
    {
        var order = _orderService.GetOrderById(id);
        if (order == null) return NotFound(new { Message = "Order not found" });

        return Ok(order);
    }
}
