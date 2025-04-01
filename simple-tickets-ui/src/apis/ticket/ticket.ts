/**
 * Ticketリソースのオブジェクト定義
 */
export interface Ticket {
  id: string,
  projectId: string,
  columnId: string,
  title: string,
  description: Text,
  status: string,
  createDate: Date
}