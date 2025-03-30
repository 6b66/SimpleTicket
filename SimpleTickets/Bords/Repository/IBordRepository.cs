using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public interface IBordRepository
{
    /// <summary>
    /// Bordの一覧取得
    /// </summary>
    /// <returns>Bordのリスト</returns>
    public Task<List<Bord>> ListBordsAsync();
}