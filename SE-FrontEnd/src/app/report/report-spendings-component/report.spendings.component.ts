import { Component, Input, OnInit } from '@angular/core';
import { TransactionType } from 'src/dtos/transaction/transactionType';
import { TransactionReport } from 'src/dtos/transaction/transactionReport';

@Component({
    selector: 'spendings-component',
    templateUrl: './report.spendings.component.html',
    styleUrls: ['./report.spendings.component.css']
})
export class ReportSpendingsComponent implements OnInit {
    @Input() model: TransactionReport;
    displayedColumns: string[] = ['spendingsValue', 'spendingsName'];
    ngOnInit(): void {
    }
}
