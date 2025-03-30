using Dapper;
using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public class StatusRepository : IStatusRepository
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public StatusRepository(IDbConnectionFactory dbConnectionFactory) {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<List<Status>> ListStatusAsync()
    {
        string sql = "SELECT * FROM status";
        var connection = _dbConnectionFactory.CreateConnection();
        var result = await connection.QueryAsync<Status>(sql);
        return [.. result];
    }
}