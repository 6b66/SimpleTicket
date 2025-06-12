import { AbstractApi } from "../abstractApi";
import { BordColumn } from "./bordColumn";

export class BordColumnApi extends AbstractApi<BordColumn> {
  protected apiPath = "/bordColumns";

  list(): Promise<BordColumn[]> {
    return super.list(this.apiPath);
  }

  protected handleError(response: Response): void {
    throw new Error("Failed to fetch bord columns: " + response.statusText);
  }
}
