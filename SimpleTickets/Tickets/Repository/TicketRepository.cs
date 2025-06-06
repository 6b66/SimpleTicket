using Microsoft.EntityFrameworkCore;
using SimpleTickets.Models;
using SimpleTickets.Data;

namespace SimpleTickets.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly ApplicationDbContext _db;

    public TicketRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<List<Ticket>> ListTicketsAsync()
    {
        return await _db.Tickets.ToListAsync();
    }
}