using SimpleTickets.Models;

namespace SimpleTickets.Services;

public interface ITicketService
{
    /// <summary>
    /// Ticketを一覧取得する。
    /// </summary>
    /// <returns>Ticketのリスト</returns>
    Task<List<Ticket>> ListTickets();
}