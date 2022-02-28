import { Component, Input, OnInit } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { MatSortModule } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { TransactionReport } from 'src/dtos/transaction/transactionReport';

const ELEMENT_DATA: Incomes[] = [
  { incomesValue: "A luat la superbet", incomesName: 500 },
  { incomesValue: "Smrfm de nu m-a rupt la ruleta    41241241", incomesName: 555 },
  { incomesValue: "7 lei motorina culcat", incomesName: 500 }
]

@Component({
  selector: 'incomes-component',
  templateUrl: './report.incomes.component.html',
  styleUrls: ['./report.incomes.component.css']
})
export class ReportIncomesComponent implements OnInit {
  @Input() model: TransactionReport;
  displayedColumns: string[] = ['incomesValue', 'incomesName'];
  dataSource = ELEMENT_DATA;
  ngOnInit(): void {

  }

}
export interface Incomes {
  incomesValue: string;
  incomesName: number;
}