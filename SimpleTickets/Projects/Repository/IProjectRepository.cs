using SimpleTickets.Models;

namespace SimpleTickets.Repositories;

public interface IProjectRepository
{
    /// <summary>
    /// Projectの一覧取得
    /// </summary>
    /// <returns>Projectのリスト</returns>
    public Task<List<Project>> ListProjectsAsync();
}