using Dapper;
using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public class BordColumnRepository : IBordColumnRepository
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public BordColumnRepository(IDbConnectionFactory dbConnectionFactory) {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<List<BordColumn>> ListBordColumnsAsync()
    {
        string sql = "SELECT * FROM bord_column";
        var connection = _dbConnectionFactory.CreateConnection();
        var result = await connection.QueryAsync<BordColumn>(sql);
        return [.. result];
    }
}