import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core'
import { forkJoin, Observable } from 'rxjs'

import { MemberDto as MemberDto } from '../dtos/member/memberDto'

@Injectable({
  providedIn: 'root',
})
export class MemberService {
  private serviceUrl = 'https://localhost:44318/Member'

  constructor(private http: HttpClient) { }

  getMembers(): Observable<MemberDto[]> {
    return this.http.get<MemberDto[]>(this.serviceUrl)
  }

  updateMembers(member: MemberDto): Observable<MemberDto> {
    return this.http.post<MemberDto>(`${this.serviceUrl}`, member);
  }

  addMember(member: MemberDto): Observable<MemberDto> {
    return this.http.put<MemberDto>(`${this.serviceUrl}`, member);
  }

  deleteMember(id: number): Observable<MemberDto> {
    return this.http.delete<MemberDto>(`${this.serviceUrl}/${id}`);
  }

  deleteMembers(members: MemberDto[]): Observable<MemberDto[]> {
    return forkJoin(members.map(member => this.http.delete<MemberDto>(`${this.serviceUrl}/${member.id}`)))
  }
}
