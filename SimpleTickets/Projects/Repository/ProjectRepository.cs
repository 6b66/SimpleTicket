using Microsoft.EntityFrameworkCore;
using SimpleTickets.Models;
using SimpleTickets.Data;

namespace SimpleTickets.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly ApplicationDbContext _db;

    public ProjectRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<List<Project>> ListProjectsAsync()
    {
        return await _db.Projects.ToListAsync();
    }
}