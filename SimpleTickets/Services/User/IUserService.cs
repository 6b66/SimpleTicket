using SimpleTickets.Models;

namespace SimpleTickets.Services;

public interface IUserService
{
    /// <summary>
    /// Userを一覧取得する。
    /// </summary>
    /// <returns>Userのリスト</returns>
    Task<List<User>> ListUsers();
}