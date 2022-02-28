import { Component, OnInit, Input } from '@angular/core';
import { MemberDto } from 'src/dtos/member/memberDto';
import { MemberService } from '../../../services/member.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {
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
    document.getElementById("member-" + member.id)!.hidden = !document.getElementById("member-" + member.id)!.hidden;
    document.getElementById("row-" + member.id)!.hidden = !document.getElementById("row-" + member.id)!.hidden;
  }
}
