using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NexCart.DTOs.Order;
using NexCart.Services.Interfaces;

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

    [HttpGet("{id}")]
    public IActionResult GetOrder(int id)
    {
        var order = _orderService.GetOrderById(id);
        if (order == null) return NotFound(new { Message = "Order not found" });

        return Ok(order);
    }

    [HttpGet("user/{userId}")]
    public IActionResult GetOrdersByUserId(int userId)
    {
        var orders = _orderService.GetOrdersByUserId(userId);
        return Ok(orders);
    }

    [HttpPost]
    public IActionResult PlaceOrder([FromBody] CreateOrderDto createOrderDto)
    {
        _orderService.PlaceOrder(createOrderDto);
        return Ok(new { Message = "Order placed successfully" });
    }
}
