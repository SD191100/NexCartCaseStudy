using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NexCart.Models;
using NexCart.Services.Interfaces;
namespace NexCart.Controllers;

[ApiController]
[Route("api/[controller]")]
    public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        var user = _userService.GetUserById(id);
        if (user == null) return NotFound(new { Message = "User not found" });

        return Ok(user);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, [FromBody] User user)
    {
        if (id != user.UserId) return BadRequest(new { Message = "User ID mismatch" });

        _userService.UpdateUser(user);
        return Ok(new { Message = "User updated successfully" });
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public IActionResult DeleteUser(int id)
    {
        _userService.DeleteUser(id);
        return Ok(new { Message = "User deleted successfully" });
    }
}
