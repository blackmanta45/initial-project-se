import { Component, OnInit } from '@angular/core';
import {MatDialog} from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { ConfirmDialogComponent } from '../dialog-box/confirm-dialog';
import { UserSchema, User } from '../../../Dtos/user';
import { UserService } from '../../../services/user-service';

@Component({
  selector: 'configuration-list',
  templateUrl: './configuration-list.html',
  styleUrls: ['./configuration-list.css']
})

export class ConfigurationLComponent implements OnInit {
  displayedColumns: string[] = Object.keys(UserSchema);
  dataSchema = UserSchema;
  dataSource = new MatTableDataSource<User>();

  constructor(public dialog: MatDialog, private userService: UserService) {}

  ngOnInit() {
    this.userService.getUsers().subscribe((res: User[]) => {
      this.dataSource.data = res;
    })
  }

  editRow(row) {
    console.log(row);
    if (row.id === "") {
      this.userService.addUser(row).subscribe(res => {
        row.id = res.id;
        row.isEdit = false;
      });
    } else {
      this.userService.updateUser(row).subscribe(() => row.isEdit = false);
    }
  } 

  addRow() {
    const newRow: User = {id: "", name: "", age: 0, cnp: "",CreatedAt:"",modifiedAt:"",spendingLimit:0, isEdit: true, isSelected: false}
    this.dataSource.data = [newRow, ...this.dataSource.data];
  }

  removeRow(id) {
    this.userService.deleteUser(id).subscribe(() => {
      this.dataSource.data = this.dataSource.data.filter((u: User) => u.id !== id);
    });
  }

  removeSelectedRows() {
    const users= this.dataSource.data.filter((u: User) => u.isSelected);
    this.dialog.open(ConfirmDialogComponent).afterClosed().subscribe(confirm => {
      if (confirm) {
        this.userService.deleteUsers(users).subscribe(() => {
          this.dataSource.data = this.dataSource.data.filter((u: User) => !u.isSelected);
        });
      }
    });
  }
}