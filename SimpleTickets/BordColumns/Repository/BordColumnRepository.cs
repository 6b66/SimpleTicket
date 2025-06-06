using Microsoft.EntityFrameworkCore;
using SimpleTickets.Models;
using SimpleTickets.Data;

namespace SimpleTickets.Repositories;

public class BordColumnRepository : IBordColumnRepository
{
    private readonly ApplicationDbContext _db;

    public BordColumnRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<List<BordColumn>> ListBordColumnsAsync()
    {
        return await _db.BordColumns.ToListAsync();
    }
}