
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleTickets.Models;

public class Bord
{
    /// <summary>
    /// ボードId
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// プロジェクトId
    /// </summary>
    public Guid ProjectId { get; private set; }

    /// <summary>
    /// タイトル
    /// </summary>
    public string Title { get; private set; } = "";

    /// <summary>
    /// 詳細、リッチテキスト(になればいいな)
    /// </summary>
    public string Description { get; private set; } = "";

    /// <summary>
    /// カラム一覧
    /// </summary>
    public List<Guid> BordColumns { get; private set; } = new List<Guid>();

    /// <summary>
    /// 作成日時
    /// </summary>
    public DateTime CreatedDate { get; private set; }

    /// <summary>
    /// デフォルトコンストラクタ
    /// </summary>
    public Bord() {}

    public Bord(Guid id, Guid projectId, string title, string description, List<Guid> bordColumns, DateTime createdDate)
    {
        Id = id;
        ProjectId = projectId;
        Title = title;
        Description = description;
        BordColumns = bordColumns;
        CreatedDate = createdDate;
    }
}