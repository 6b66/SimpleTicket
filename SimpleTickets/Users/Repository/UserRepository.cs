using Dapper;
using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public UserRepository(IDbConnectionFactory dbConnectionFactory) {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<List<User>> ListUsersAsync()
    {
        string sql = "SELECT * FROM users";
        var connection = _dbConnectionFactory.CreateConnection();
        var result = await connection.QueryAsync<User>(sql);
        return [.. result];
    }
}