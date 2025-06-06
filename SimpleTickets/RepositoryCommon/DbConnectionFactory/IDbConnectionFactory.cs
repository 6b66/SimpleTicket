using System.Data;

namespace SimpleTickets.Repositories;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}