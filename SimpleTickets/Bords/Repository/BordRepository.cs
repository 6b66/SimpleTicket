using Microsoft.EntityFrameworkCore;
using SimpleTickets.Models;
using SimpleTickets.Data;

namespace SimpleTickets.Repositories;

public class BordRepository : IBordRepository
{
    private readonly ApplicationDbContext _db;

    public BordRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<List<Bord>> ListBordsAsync()
    {
        return await _db.Bords.ToListAsync();
    }
}