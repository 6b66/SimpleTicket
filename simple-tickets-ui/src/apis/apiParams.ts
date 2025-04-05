/**
 * APIリクエストに設定するクエリを保持インターフェース
 */
export interface ApiParams {
    [key: string]: string | number | boolean | undefined;
}

/**
 * ApiParamsに対する処理を持つクラス
 */
export class ApiParamsUtil {
  /**
   * ApiPramsをクエリストリング(文字列)に変換
   * 先頭に?を付与する(URLに直接連結できるようにするため)
   * 0件または未指定の場合は空文字列
   * 
   * @param params ApiPapamsオブジェクト
   * @returns クエリストリング
   */
  static getQueryString(params: ApiParams) {
    if (!params) { return ''; }

    const recordedToParams = Object.entries(params).reduce((result, [ key, value ]) => { 
      if (value !== undefined) {
        result[key] = String(value);
      }
      return result;
    }, {} as Record<string, string>);

    const query = new URLSearchParams(recordedToParams);
    return `?${query.toString()}`;
  }
}
