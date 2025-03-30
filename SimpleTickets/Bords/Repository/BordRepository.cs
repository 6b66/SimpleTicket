using Dapper;
using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public class BordRepository : IBordRepository
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public BordRepository(IDbConnectionFactory dbConnectionFactory) {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<List<Bord>> ListBordsAsync()
    {
        string sql = "SELECT * FROM bord";
        var connection = _dbConnectionFactory.CreateConnection();
        var result = await connection.QueryAsync<Bord>(sql);
        return [.. result];
    }
}