
namespace SimpleTickets.Models;

public class User
{
    /// <summary>
    /// ユーザId
    /// </summary>
    public Guid Id { get; private set; }
    
    /// <summary>
    /// ユーザ名
    /// </summary>
    public string Name { get; private set; } = "";
    
    /// <summary>
    /// 作成日時
    /// </summary>
    public DateTime CreatedDate { get; private set; }

    /// <summary>
    /// デフォルトコンストラクタ
    /// </summary>
    public User() {}

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="id">ユーザID (DBで自動設定)</param>
    /// <param name="name">ユーザ名</param>
    /// <param name="createDate">作成日時 (DBで自動設定)</param>
    public User(Guid id, string name, DateTime createdDate)
    {
        Id = id;
        Name = name;
        CreatedDate = createdDate;
    }
}