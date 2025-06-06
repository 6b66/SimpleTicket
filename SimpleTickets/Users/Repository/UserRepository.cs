using Microsoft.EntityFrameworkCore;
using SimpleTickets.Models;
using SimpleTickets.Data;

namespace SimpleTickets.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _db;

    public UserRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<List<User>> ListUsersAsync()
    {
        return await _db.Users.ToListAsync();
    }
}