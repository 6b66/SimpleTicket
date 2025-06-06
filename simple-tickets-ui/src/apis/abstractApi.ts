import { ApiParams, ApiParamsUtil } from "./apiParams";

/**
 * API(HTTP)でリソースを取得する抽象クラス
 */
export abstract class AbstractApi<T> {
  /**
   * ホスト
   */
  protected baseUrl = "http://localhost:8080";

  /**
   * APIによるリソースの一覧取得
   * 
   * @param params パラメタ
   * @returns 
   */
  protected async list(apiPath: string, params?: ApiParams): Promise<T[]> {
    const queryString = ApiParamsUtil.getQueryString(params);
    const url = `${this.baseUrl}${apiPath}${queryString}`;
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
}