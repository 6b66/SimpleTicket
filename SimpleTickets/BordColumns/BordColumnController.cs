using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleTickets.Models;
using SimpleTickets.Services;

namespace SimpleTickets.Controllers;

[ApiController]
[Route("bordColumns")]
public class BordColumnController : ControllerBase
{
    private readonly ILogger<BordColumnController> _logger;

    private readonly BordColumnService _bordColumnService;

    public BordColumnController(ILogger<BordColumnController> logger, BordColumnService bordColumnService)
    {
        _logger = logger;
        _bordColumnService = bordColumnService;
    }

    [HttpGet(Name = "bordColumns")]
    public async Task<IEnumerable<BordColumn>> Get()
    {
        return await _bordColumnService.ListBordColumn();
    }
}
