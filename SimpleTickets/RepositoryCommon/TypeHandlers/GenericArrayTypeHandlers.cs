using System.Data;
using Dapper;

/// <summary>
/// 配列のカラムをListにマッピングする
/// </summary>
/// <typeparam name="T">配列の要素の型</typeparam>
public class GenericArrayHandler<T> : SqlMapper.TypeHandler<List<T>>
{
    public override void SetValue(IDbDataParameter parameter, List<T>? value)
    {
        parameter.Value = value;
    }

    public override List<T> Parse(object value)
    {
        T[] arrayValue = (T[]) value;
        return arrayValue.ToList();
    }
}