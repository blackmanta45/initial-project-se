import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, RoutesRecognized } from '@angular/router';
import { Subscription } from 'rxjs';
import { Spendings } from 'src/dtos/transaction/spendings';
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
  public spendings: Spendings[] = {} as Spendings[];
  constructor(private TransactionService: TransactionService, private route: ActivatedRoute) {
    this.transactionReport = {} as TransactionReport;
  }

  ngOnInit(): void {
    this.route.params.subscribe(x => {
      this.routeSub = x["id"];
      this.TransactionService.getAllTransactionsForMember(this.routeSub).subscribe(x => {
        this.transactionReport = x;
        this.spendings = this.transform(x);
        console.log(this.spendings)
      });
    });
  }
  transform(model: TransactionReport): Spendings[] {
    let list: Spendings[] =[];
    console.log(model);
    let size = model.transactions.length;
    for (let i = 0; i < size; i++) {
      if(model.transactions[i].type === TransactionType.Expense)
    {
      let temp = new Spendings;
      temp.spendingsName = model.transactions[i].details;
      temp.spendingsValue = model.transactions[i].price;
      list.push(temp);
    }
    else
    {
      
    }
    }
    return list;
  }
}