
namespace SimpleTickets.Models;

public class Project
{
    /// <summary>
    /// プロジェクトId
    /// </summary>
    public Guid Id {get;}

    /// <summary>
    /// プロジェクト名
    /// </summary>
    public string Name {get;} = "";

    /// <summary>
    /// 詳細、リッチテキスト(になればいいな)
    /// </summary>
    public string Description {get;} = "";

    /// <summary>
    /// プロジェクト管理者ID一覧
    /// </summary>
    public List<Guid> Managers {get;} = new List<Guid>();

    /// <summary>
    /// プロジェクト参加者ID一覧
    /// </summary>
    public List<Guid> Members {get;} = new List<Guid>();

    /// <summary>
    /// 作成日時
    /// </summary>
    public DateTime? CreatedDate {get;}

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