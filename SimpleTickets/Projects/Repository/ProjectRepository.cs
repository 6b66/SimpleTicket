using Dapper;
using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public ProjectRepository(IDbConnectionFactory dbConnectionFactory) {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<List<Project>> ListProjectsAsync()
    {
        string sql = "SELECT * FROM project";
        var connection = _dbConnectionFactory.CreateConnection();
        var result = await connection.QueryAsync<Project>(sql);
        return [.. result];
    }
}