import { TransactionType } from "./transactionType";

export interface Transaction {
    id: string;
    memberId: string;
    type: TransactionType;
    price: number;
    details: string;
};