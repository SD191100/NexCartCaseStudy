using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NexCart.Models;
using NexCart.Services.Interfaces;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin,Seller")]
public class SellerController : ControllerBase
{
    private readonly ISellerService _sellerService;

    public SellerController(ISellerService sellerService)
    {
        _sellerService = sellerService;
    }

    [HttpGet("{id}")]
    public IActionResult GetSeller(int id)
    {
        var seller = _sellerService.GetSellerById(id);
        if (seller == null) return NotFound(new { Message = "Seller not found" });

        return Ok(seller);
    }

    [HttpGet("user/{userId}")]
    public IActionResult GetSellerByUserId(int userId)
    {
        var seller = _sellerService.GetSellerByUserId(userId);
        if (seller == null) return NotFound(new { Message = "Seller not found" });

        return Ok(seller);
    }

    [HttpPost]
    public IActionResult AddSeller([FromBody] Seller seller)
    {
        _sellerService.AddSeller(seller);
        return CreatedAtAction(nameof(GetSeller), new { id = seller.SellerId }, seller);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateSeller(int id, [FromBody] Seller seller)
    {
        if (id != seller.SellerId) return BadRequest(new { Message = "ID mismatch" });

        _sellerService.UpdateSeller(seller);
        return Ok(new { Message = "Seller updated successfully" });
    }
}
