/**
 * APIリクエストに設定するクエリを保持インターフェース
 */
export interface ApiParams {
    [key: string]: string | number | boolean | undefined;
}