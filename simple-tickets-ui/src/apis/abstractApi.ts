import { ApiParams } from "./apiParams";

/**
 * API(HTTP)でリソースを取得する抽象クラス
 */
export abstract class AbstractApi<T> {
  /**
   * 取得先ドメイン
   */
  protected abstract baseUrl: string;

  /**
   * APIによるリソースの一覧取得
   * 
   * @param params パラメタ
   * @returns 
   */
  async list(params?: ApiParams): Promise<T[]> {
    const queryString = this.getQueryString(params);
    const url = queryString ? `${this.baseUrl}?${queryString}` : `${this.baseUrl}`
    const response = await fetch(url, {
      method: 'GET',
      mode: 'cors'
    });
    if (!response.ok) {
      this.handleError(response);
      return [];
    }
    return await response.json();
  }

  /**
   * APIのエラーハンドラ。API毎に異なる気がするので抽象化
   * 
   * @param response レスポンス
   */
  protected abstract handleError(response: Response): void;

  /**
   * ApiPramsをクエリストリング(文字列に変換)
   * 
   * @param params ApiPapamsオブジェクト
   * @returns クエリストリング
   */
  private getQueryString(params: ApiParams) {
    if (!params) return '';
    const query = new URLSearchParams(
      Object.entries(params).reduce((acc, [key, value]) => {
        if (value !== undefined) {
          acc[key] = String(value);
        }
        return acc;
      }, {} as Record<string, string>)
    );
    return query.toString();
  }
}