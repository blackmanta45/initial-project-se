import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { TransactionService } from 'src/services/transaction.service';
import { Transaction } from 'src/dtos/transaction/transaction';
import { MatDialog } from '@angular/material/dialog';
import { CommonService } from 'src/services/common.service';
import { TransactionReport } from 'src/dtos/transaction/transactionReport';

@Component({
  selector: 'statistics-report',
  templateUrl: './statistics-component.html',
  styleUrls: ['./statistics-component.css']
})

export class StatisticsComponent implements OnInit {
    @Input() model: TransactionReport;
  constructor(private TransactionService: TransactionService, CommonService: CommonService) { }

  ngOnInit(): void {

  }

}

