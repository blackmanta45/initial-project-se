import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { MemberDto } from '../../../dtos/member/memberDto';
import { TransactionService } from '../../../services/transaction.service';
import { Transaction } from 'src/dtos/transaction/transaction';
import { TransactionType } from 'src/dtos/transaction/transactionType';

@Component({
  selector: 'app-member-form-operation',
  templateUrl: './member-form-operation.component.html',
  styleUrls: ['./member-form-operation.component.css']
})
export class MemberFormOperationComponent implements OnInit {

  @Input() selectedMember: MemberDto;

  IEForm = this.formBuilder.group({
    income: "",
    expense: "",
  });

  constructor(private formBuilder: FormBuilder,
              private transactionService: TransactionService) {

  }

  ngOnInit(): void {
  }

  handleAddIncome() {
    if (!isNaN(this.IEForm.value.income) && this.IEForm.value.income != null && this.IEForm.value.income != "") {
      alert(this.IEForm.value.income);
      this.addTransaction(
        {
          id: "",
          memberId: this.selectedMember.id, 
          type: TransactionType.Income,
          price: this.IEForm.value.income,
          details: ""
        }
      );
      this.IEForm.reset();
    }
    else {
      alert("Please enter a valid number format!");
      this.IEForm.reset();
    }
  }

  handleAddExpense() {
    if (!isNaN(this.IEForm.value.expense) && this.IEForm.value.expense != null && this.IEForm.value.expense != "") {
      alert(this.IEForm.value.expense);
      this.addTransaction(
        {
          id: "",
          memberId: this.selectedMember.id, 
          type: TransactionType.Expense,
          price: this.IEForm.value.expense,
          details: ""
        }
      );
      this.IEForm.reset();
    }
    else {
      alert("Please enter a valid number format!");
      this.IEForm.reset();
    }
  }

  handleReport(member: MemberDto) {
    this.selectedMember = member;
    
  }

  addTransaction(newTransaction: Transaction) {
    this.transactionService
      .addTransaction(newTransaction)
      .subscribe();
  }
}
