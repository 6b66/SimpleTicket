using Dapper;
using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public TicketRepository(IDbConnectionFactory dbConnectionFactory) {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<List<Ticket>> ListTicketsAsync()
    {
        string sql = "SELECT * FROM ticket";
        var connection = _dbConnectionFactory.CreateConnection();
        var result = await connection.QueryAsync<Ticket>(sql);
        return [.. result];
    }
}