import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class RoleDeleteService {
  constructor(private http: HttpClient) {}

  getStudentList() {
    return this.http.get("https://localhost:7249/api/Account");
  }

  getRoles(userUUID: any) {
    return this.http.get("https://localhost:7249/api/RoleManager/" + userUUID);
  }

  deleteRole(id: any) {
    return this.http.delete("https://localhost:7249/api/RoleManager/" + id);
  }
}
