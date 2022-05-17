import { IProducts } from "./producs";

export interface IPagination {
    pageIndex: number;
    pageSize: number;
    count: number;
    data: IProducts[];
}