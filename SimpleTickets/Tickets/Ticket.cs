
namespace SimpleTickets.Models;

public class Ticket
{
    /// <summary>
    /// チケットId
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// プロジェクトId
    /// </summary>
    public Guid ProjectId { get; private set; }

    /// <summary>
    /// カラムId
    /// </summary>
    public Guid ColumnId { get; private set; }

    /// <summary>
    /// タイトル
    /// </summary>
    public string Title { get; private set; } = "";

    /// <summary>
    /// 詳細、リッチテキスト(になればいいな)
    /// </summary>
    public string Description { get; private set; } = "";

    /// <summary>
    /// 状態
    /// </summary>
    public Guid Status { get; private set; }

    /// <summary>
    /// 作成日時
    /// </summary>
    public DateTime? CreatedDate { get; private set; }

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