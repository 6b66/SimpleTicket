import { AbstractApi } from "../abstractApi";
import { Ticket } from "./ticket";

export class TicketApi extends AbstractApi<Ticket> {
  // エンドポイント
  protected baseUrl: string = "http://localhost:8080/tickets";

  // エラーハンドラ
  protected handleError(response: Response): void {
    throw new Error("Method not implemented.");
  }
}
