using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleTickets.Models;
using SimpleTickets.Services;

namespace SimpleTickets.Controllers;

[ApiController]
[Route("projects")]
public class ProjectController : ControllerBase
{
    private readonly ILogger<ProjectController> _logger;

    private readonly ProjectService _projectService;

    public ProjectController(ILogger<ProjectController> logger, ProjectService projectService)
    {
        _logger = logger;
        _projectService = projectService;
    }

    [HttpGet(Name = "projects")]
    public async Task<IEnumerable<Project>> Get()
    {
        return await _projectService.ListProject();
    }
}
