import { AbstractApi } from "../abstractApi";
import { Ticket } from "./ticket";

export class TicketApi extends AbstractApi<Ticket> {
  protected apiPath = "/tickets";

  list(): Promise<Ticket[]> {
    return super.list(this.apiPath);
  }

  // エラーハンドラ
  protected handleError(response: Response): void {
    throw new Error("Method not implemented.");
  }
}
