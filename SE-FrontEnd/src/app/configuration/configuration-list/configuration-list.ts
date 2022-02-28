import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { ConfirmDialogComponent } from '../dialog-box/confirm-dialog';
import { UserSchema, MemberDto } from '../../../dtos/member/memberDto';
import { MemberService } from '../../../services/member.service';
import { CommonService } from '../../../services/common.service';

@Component({
  selector: 'configuration-list',
  templateUrl: './configuration-list.html',
  styleUrls: ['./configuration-list.css']
})

export class ConfigurationLComponent implements OnInit {
  displayedColumns: string[] = Object.keys(UserSchema);
  columnsDisplayName: string[] = ["Select", "Name", "Age", "Spending Limit", "CNP", "Action"];
  dataSchema = UserSchema;
  dataSource = new MatTableDataSource<MemberDto>();

  constructor(public dialog: MatDialog, private MemberService: MemberService, private CommonService: CommonService) { }

  ngOnInit() {
    this.MemberService.getMembers().subscribe((res: MemberDto[]) => {
      this.dataSource.data = res;
    });
    this.CommonService.removeEvent.subscribe(_ => {
      this.removeSelectedRows();
    });
    this.CommonService.addEvent.subscribe(_ => {
      this.addRow();
    });
  }

  selectElement(element: MemberDto) {
    element.isSelected = !element.isSelected;
    let canDelete = this.dataSource.data.filter(member => member.isSelected).length !== 0;
    this.CommonService.canRemoveChanged(canDelete);
  }

  editRow(row) {
    if (row.id === "") {
      this.MemberService.addMember(row).subscribe(res => {
        row.id = res.id;
        row.isEdit = false;
      });
    } else {
      this.MemberService.updateMembers(row).subscribe(() => row.isEdit = false);
    }
  }

  addRow() {
    const newRow: MemberDto = { id: "", name: "", age: 0, cnp: "", createdAt: "", modifiedAt: "", spendingLimit: 0, isEdit: true, isSelected: false }
    this.dataSource.data = [newRow, ...this.dataSource.data];
  }

  removeRow(id) {
    this.MemberService.deleteMember(id).subscribe(() => {
      this.dataSource.data = this.dataSource.data.filter((u: MemberDto) => u.id !== id);
    });
  }

  removeSelectedRows() {
    const users = this.dataSource.data.filter((u: MemberDto) => u.isSelected);
    this.dialog.open(ConfirmDialogComponent).afterClosed().subscribe(confirm => {
      if (confirm) {
        this.MemberService.deleteMembers(users).subscribe(() => {
          this.dataSource.data = this.dataSource.data.filter((u: MemberDto) => !u.isSelected);
        });
      }
    });
  }
}