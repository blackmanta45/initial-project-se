import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Transaction } from 'src/dtos/transaction/transaction';
import { Observable } from 'rxjs';
import { TransactionReport } from 'src/dtos/transaction/transactionReport';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {

  private serviceUrl = 'https://localhost:44318/Transaction';

  constructor(private http: HttpClient) {}

  getTransactions(): Observable<Transaction[]> {
    return this.http.get<Transaction[]>(this.serviceUrl)
  }

  getAllTransactionsForMember(id: string): Observable<TransactionReport> {
    return this.http.get<TransactionReport>(`${this.serviceUrl}/ForMember/${id}`);
  }

  addTransaction(transaction: Transaction): Observable<Transaction> {
    return this.http.put<Transaction>(`${this.serviceUrl}`, transaction);
  }

  updateTransaction(transaction: Transaction): Observable<Transaction> {
    return this.http.post<Transaction>(`${this.serviceUrl}`, transaction);
  }

  deleteTransaction(id: string): Observable<Transaction> {
    return this.http.delete<Transaction>(`${this.serviceUrl}/${id}`);
  }
}
