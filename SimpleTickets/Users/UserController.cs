using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleTickets.Models;
using SimpleTickets.Services;

namespace SimpleTickets.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    private readonly UserService _userService;

    public UserController(ILogger<UserController> logger, UserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet(Name = "users")]
    public async Task<IEnumerable<User>> Get()
    {
        return await _userService.ListUsers();
    }
}
