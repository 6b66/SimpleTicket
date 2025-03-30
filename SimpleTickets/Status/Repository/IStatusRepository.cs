using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public interface IStatusRepository
{
    /// <summary>
    /// Statusの一覧取得
    /// </summary>
    /// <returns>Statusのリスト</returns>
    public Task<List<Status>> ListStatusAsync();
}