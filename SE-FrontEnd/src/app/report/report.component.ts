import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, RoutesRecognized } from '@angular/router';
import { Subscription } from 'rxjs';
import { TransactionListItem } from 'src/dtos/transaction/spendings';
import { Transaction } from 'src/dtos/transaction/transaction';
import { TransactionReport } from 'src/dtos/transaction/transactionReport';
import { TransactionType } from 'src/dtos/transaction/transactionType';
import { TransactionService } from 'src/services/transaction.service';

@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.css']
})

export class ReportComponent implements OnInit {

  private routeSub: string;
  public transactionReport: TransactionReport;
  public spendingList: TransactionReport;
  public incomeList: TransactionReport;
  constructor(private TransactionService: TransactionService, private route: ActivatedRoute) {
    this.transactionReport = {} as TransactionReport;
    this.spendingList = {} as TransactionReport;
    this.incomeList = {} as TransactionReport;
  }

  ngOnInit(): void {
    this.route.params.subscribe(x => {
      this.routeSub = x["id"];
      this.TransactionService.getAllTransactionsForMember(this.routeSub).subscribe(x => {
        this.transactionReport = x;
        this.spendingList.transactions = [];
        this.incomeList.transactions = [];
        this.transform(x);
      });
    });
  }

  transform(model: TransactionReport){
    let size = model.transactions.length;
    for (let i = 0; i < size; i++) {
      let temp = new Transaction;
      temp.details = model.transactions[i].details;
      temp.price = model.transactions[i].price;
      if (model.transactions[i].type === TransactionType.Expense)
        this.spendingList.transactions.push(temp);
      else
        this.incomeList.transactions.push(temp);
    }
    console.log(this.spendingList);
    console.log(this.incomeList);
  }
}