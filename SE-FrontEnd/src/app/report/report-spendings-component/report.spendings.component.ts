import { Component, Input, OnInit } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { MatSortModule } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { TransactionReport } from 'src/dtos/transaction/transactionReport';
import { Transaction } from 'src/dtos/transaction/transaction';
import { Spendings } from 'src/dtos/transaction/spendings';



const ELEMENT_DATA: Spendings[] = [
    { spendingsName: "A luat la superbet", spendingsValue: 500 },
    { spendingsName: "Smrfm de nu m-a rupt la ruleta", spendingsValue: 555 },
    { spendingsName: "7 lei motorina culcat", spendingsValue: 500 }
]

@Component({
    selector: 'spendings-component',
    templateUrl: './report.spendings.component.html',
    styleUrls: ['./report.spendings.component.css']
})
export class ReportSpendingsComponent implements OnInit {
    @Input() model: Spendings[];
    displayedColumns: string[] = ['spendingsValue', 'spendingsName'];
    ngOnInit(): void {
    }
   

}
