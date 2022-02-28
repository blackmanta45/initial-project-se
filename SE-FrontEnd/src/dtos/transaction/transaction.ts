import { TransactionType } from "./transactionType";

export class Transaction {
    id: string;
    memberId: string;
    type: TransactionType;
    price: number;
    details: string;
};