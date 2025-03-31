
namespace SimpleTickets.Models;

public class Ticket
{
    /// <summary>
    /// チケットId
    /// </summary>
    public Guid Id {get;}

    /// <summary>
    /// プロジェクトId
    /// </summary>
    public Guid ProjectId {get;}

    /// <summary>
    /// カラムId
    /// </summary>
    public Guid ColumnId {get;}

    /// <summary>
    /// タイトル
    /// </summary>
    public string Title {get;} = "";

    /// <summary>
    /// 詳細、リッチテキスト(になればいいな)
    /// </summary>
    public string Description {get;} = "";

    /// <summary>
    /// 状態
    /// </summary>
    public Guid Status {get;}

    /// <summary>
    /// 作成日時
    /// </summary>
    public DateTime? CreatedDate {get;}

    /// <summary>
    /// デフォルトコンストラクタ
    /// </summary>
    public Ticket() {}

    public Ticket(Guid id, Guid projectId, Guid columnId, string title, string description, Guid status, DateTime createdDate)
    {
        Id = id;
        ProjectId = projectId;
        ColumnId = columnId;
        Title = title;
        Description = description;
        Status = status;
        CreatedDate = createdDate;
    }
}