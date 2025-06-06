
namespace SimpleTickets.Models;

public class BordColumn
{
    /// <summary>
    /// ボードのカラムId
    /// </summary>
    public Guid? Id { get; private set; }

    /// <summary>
    /// プロジェクトId
    /// </summary>
    public Guid ProjectId { get; private set; }

    /// <summary>
    /// タイトル
    /// </summary>
    public string Title { get; private set; } = "";

    /// <summary>
    /// チケット一覧
    /// </summary>
    public List<Guid> TicketIds { get; private set; } = new List<Guid>();

    /// <summary>
    /// 作成日時
    /// </summary>
    public DateTime? CreatedDate { get; private set; }

    /// <summary>
    /// デフォルトコンストラクタ
    /// </summary>
    public BordColumn() {}

    public BordColumn(Guid id, Guid projectId, string title, string description, List<Guid> ticketIds, DateTime createdDate)
    {
        Id = id;
        ProjectId = projectId;
        Title = title;
        TicketIds = ticketIds;
        CreatedDate = createdDate;
    }
}