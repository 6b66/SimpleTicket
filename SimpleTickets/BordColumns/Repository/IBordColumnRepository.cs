using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public interface IBordColumnRepository
{
    /// <summary>
    /// BordColumnの一覧取得
    /// </summary>
    /// <returns>BordColumnのリスト</returns>
    public Task<List<BordColumn>> ListBordColumnsAsync();
}