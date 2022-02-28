import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Transaction } from 'src/dtos/transaction/transaction';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {

  private serviceUrl = 'https://localhost:44318/Transaction';

  constructor(private http: HttpClient) {}

  getTransactions(): Observable<Transaction[]> {
    return this.http.get<Transaction[]>(this.serviceUrl)
  }

  addTransaction(transaction: Transaction): Observable<Transaction> {
    // console.log(transaction);
    return this.http.put<Transaction>(`${this.serviceUrl}`, transaction);
  }

  updateTransaction(transaction: Transaction): Observable<Transaction> {
    return this.http.post<Transaction>(`${this.serviceUrl}`, transaction);
  }

  deleteTransaction(id: number): Observable<Transaction> {
    return this.http.delete<Transaction>(`${this.serviceUrl}/${id}`);
  }

  // deleteUsers(transactions: Transaction[]): Observable<Transaction[]> {
  //   return forkJoin(transactions.map(transaction => this.http.delete<Transaction>(`${this.serviceUrl}/${transaction.id}`)))
  // }
}
