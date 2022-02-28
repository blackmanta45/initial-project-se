import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { Observable, forkJoin } from 'rxjs'
import { User } from '../Dtos/user'
@Injectable({
  providedIn: 'root',
})
export class UserService {
  private serviceUrl = 'https://localhost:44318/Member'

  constructor(private http: HttpClient) {}

  getUsers(): Observable<User[]> {
    return this.http.get<User[]>(this.serviceUrl)
  }

  updateUser(user: User): Observable<User> {
    return this.http.post<User>(`${this.serviceUrl}`, user);
  }

  addUser(user: User): Observable<User> {
    console.log(user);
    return this.http.put<User>(`${this.serviceUrl}`, user);
  }

  deleteUser(id: number): Observable<User> {
    return this.http.delete<User>(`${this.serviceUrl}/${id}`);
  }

  deleteUsers(users: User[]): Observable<User[]> {
    return forkJoin(users.map(user => this.http.delete<User>(`${this.serviceUrl}/${user.id}`)))
  }
}
