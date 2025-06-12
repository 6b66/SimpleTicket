import { AbstractApi } from "../abstractApi";
import { Bord } from "./bord";

export class BordApi extends AbstractApi<Bord> {
  protected apiPath = "/bords";

  list(): Promise<Bord[]> {
    return super.list(this.apiPath);
  }

  protected handleError(response: Response): void {
    throw new Error("Failed to fetch bords: " + response.statusText);
  }
}
