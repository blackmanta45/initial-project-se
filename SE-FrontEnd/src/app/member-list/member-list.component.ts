import { Component, OnInit, Input } from '@angular/core';
import { MemberDto } from 'src/dtos/member/memberDto';
import { MemberService } from '../../services/member.service';

// const DATA: Member[] = [
//   {id: 1, name: 'Carl Johnson', age: 30, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
//   {id: 2, name: 'Frank Tenpenny', age: 40, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
//   {id: 3, name: 'Melvin Harris', age: 25, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
//   {id: 4, name: 'Sean "Sweet" Johnson', age: 35, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
//   {id: 5, name: 'Big Smoke', age: 38, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
//   {id: 6, name: 'Eddie Pulaski', age: 32, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
//   {id: 7, name: 'G', age: 14.0067, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
//   {id: 8, name: 'H', age: 15.9994, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
//   {id: 9, name: 'I', age: 18.9984, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
//   {id: 10, name: 'J', age: 20.1797, cnp:1491241242, createdAt: Date.now(), modifiedAt: Date.now(), selected: false},
// ];

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

  // members = DATA;
  members: MemberDto[];
  @Input() selectedMember!: MemberDto;

  constructor(private memberService: MemberService) { }

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    this.memberService.getMembers().subscribe((response: MemberDto[]) => {
      this.members = response;
    })
  }

  handleClick(member: MemberDto) {
    this.selectedMember = member;
    // this.members.forEach((member) => member.selected = false);
    // member.selected = !member.selected;
    document.getElementById("member-" + member.id)!.hidden = !document.getElementById("member-" + member.id)!.hidden;
    document.getElementById("row-" + member.id)!.hidden = !document.getElementById("row-" + member.id)!.hidden;
  }
}
