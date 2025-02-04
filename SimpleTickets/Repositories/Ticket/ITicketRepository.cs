using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public interface ITicketRepository
{
    /// <summary>
    /// Ticketの一覧取得
    /// </summary>
    /// <returns>Ticketのリスト</returns>
    public Task<List<Ticket>> ListTicketsAsync();
}