import { Transaction } from "./transaction";

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