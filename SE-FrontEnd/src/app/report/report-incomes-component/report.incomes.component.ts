import { Component, Input, OnInit } from '@angular/core';
import { TransactionReport } from 'src/dtos/transaction/transactionReport';

@Component({
  selector: 'incomes-component',
  templateUrl: './report.incomes.component.html',
  styleUrls: ['./report.incomes.component.css']
})
export class ReportIncomesComponent implements OnInit {
  @Input() model: TransactionReport;
  displayedColumns: string[] = ['incomesValue', 'incomesName'];

  ngOnInit(): void {
  }
}