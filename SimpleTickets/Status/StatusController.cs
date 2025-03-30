using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleTickets.Models;
using SimpleTickets.Services;

namespace SimpleTickets.Controllers;

[ApiController]
[Route("status")]
public class StatusController : ControllerBase
{
    private readonly ILogger<StatusController> _logger;

    private readonly StatusService _statusService;

    public StatusController(ILogger<StatusController> logger, StatusService statusService)
    {
        _logger = logger;
        _statusService = statusService;
    }

    [HttpGet(Name = "sutatus")]
    public async Task<IEnumerable<Status>> Get()
    {
        return await _statusService.ListStatus();
    }
}
