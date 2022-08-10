import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class RoleAddService {
  constructor(private http: HttpClient) {}

  getStudentList() {
    return this.http.get("https://localhost:7249/api/Account");
  }

  assignRole(userUUID: any, roleID: any) {
    let roleJson = {
      userUUID: userUUID,
      roleID: roleID
    }

    return this.http.post("https://localhost:7249/api/RoleManager", roleJson);
  }
}
