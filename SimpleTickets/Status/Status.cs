
using System.Reflection.Emit;

namespace SimpleTickets.Models;

public class Status
{
    /// <summary>
    /// ステータスId
    /// </summary>
    public Guid Id {get;}

    /// <summary>
    /// プロジェクトId
    /// </summary>
    public Guid ProjectId {get;}

    /// <summary>
    /// 表示ラベル
    /// </summary>
    public string Label {get;} = "";

    /// <summary>
    /// 作成日時
    /// </summary>
    public DateTime CreatedDate {get;}

    /// <summary>
    /// デフォルトコンストラクタ
    /// </summary>
    public Status() {}

    public Status(Guid id, Guid projectId, string label, DateTime createdDate)
    {
        Id = id;
        ProjectId = projectId;
        Label = label;
        CreatedDate = createdDate;
    }
}