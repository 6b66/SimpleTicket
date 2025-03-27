using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleTickets.Models;
using SimpleTickets.Services;

namespace SimpleTickets.Controllers;

[ApiController]
[Route("tickets")]
public class TicketController : ControllerBase
{
    private readonly ILogger<TicketController> _logger;

    private readonly TicketService _ticketService;

    public TicketController(ILogger<TicketController> logger, TicketService userService)
    {
        _logger = logger;
        _ticketService = userService;
    }

    [HttpGet(Name = "tickets")]
    public async Task<IEnumerable<Ticket>> Get()
    {
        return await _ticketService.ListTickets();
    }
}
