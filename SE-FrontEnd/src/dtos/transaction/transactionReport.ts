import { Transaction } from "./transaction";
import { TransactionType } from "./transactionType";

export interface TransactionReport {
    transactions: Transaction[];
    lowestIncome: number;
    highestIncome: number;
    totalIncome: number;
    lowestExpense: number;
    highestExpense: number;
    totalExpense: number;
    remainingBudget: number;
};