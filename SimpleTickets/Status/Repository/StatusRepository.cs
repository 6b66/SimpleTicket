using Microsoft.EntityFrameworkCore;
using SimpleTickets.Models;
using SimpleTickets.Data;

namespace SimpleTickets.Repositories;

public class StatusRepository : IStatusRepository
{
    private readonly ApplicationDbContext _db;

    public StatusRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<List<Status>> ListStatusAsync()
    {
        return await _db.Statuses.ToListAsync();
    }
}