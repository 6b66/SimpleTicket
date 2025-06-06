
namespace SimpleTickets.Models;

public class Project
{
    /// <summary>
    /// プロジェクトId
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// プロジェクト名
    /// </summary>
    public string Name { get; private set; } = "";

    /// <summary>
    /// 詳細、リッチテキスト(になればいいな)
    /// </summary>
    public string Description { get; private set; } = "";

    /// <summary>
    /// プロジェクト管理者ID一覧
    /// </summary>
    public List<Guid> Managers { get; private set; } = new List<Guid>();

    /// <summary>
    /// プロジェクト参加者ID一覧
    /// </summary>
    public List<Guid> Members { get; private set; } = new List<Guid>();

    /// <summary>
    /// 作成日時
    /// </summary>
    public DateTime? CreatedDate { get; private set; }

    /// <summary>
    /// デフォルトコンストラクタ
    /// </summary>
    public Project() {}

    public Project(Guid id, string name, List<Guid> managers, List<Guid> members, string description, DateTime createdDate)
    {
        Id = id;
        Name = name;
        Managers = managers;
        Members = members;
        Description = description;
        CreatedDate = createdDate;
    }
}