
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleTickets.Models;

public class Bord
{
    /// <summary>
    /// ボードId
    /// </summary>
    public Guid Id {get;}

    /// <summary>
    /// プロジェクトId
    /// </summary>
    public Guid ProjectId {get;}

    /// <summary>
    /// タイトル
    /// </summary>
    public string Title {get;} = "";

    /// <summary>
    /// 詳細、リッチテキスト(になればいいな)
    /// </summary>
    public string Description {get;} = "";

    /// <summary>
    /// カラム一覧
    /// </summary>
    public List<Guid> BordColumns {get;} = new List<Guid>();

    /// <summary>
    /// 作成日時
    /// </summary>
    public DateTime CreatedDate {get;}

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