using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleTickets.Models;
using SimpleTickets.Services;

namespace SimpleTickets.Controllers;

[ApiController]
[Route("bords")]
public class BordController : ControllerBase
{
    private readonly ILogger<BordController> _logger;

    private readonly BordService _bordService;

    public BordController(ILogger<BordController> logger, BordService bordService)
    {
        _logger = logger;
        _bordService = bordService;
    }

    [HttpGet(Name = "bords")]
    public async Task<IEnumerable<Bord>> Get()
    {
        return await _bordService.ListBord();
    }
}
