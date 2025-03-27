using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public interface IUserRepository
{
    /// <summary>
    /// Userの一覧取得
    /// </summary>
    /// <returns>Userのリスト</returns>
    public Task<List<User>> ListUsersAsync();
}