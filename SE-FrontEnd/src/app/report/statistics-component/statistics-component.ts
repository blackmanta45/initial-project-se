import { Component, Input, OnInit } from '@angular/core';
import { TransactionReport } from 'src/dtos/transaction/transactionReport';

@Component({
  selector: 'statistics-report',
  templateUrl: './statistics-component.html',
  styleUrls: ['./statistics-component.css']
})

export class StatisticsComponent implements OnInit {
  @Input() model: TransactionReport;
  constructor() { }

  ngOnInit(): void {
  }
}

