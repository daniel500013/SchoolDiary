import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ParentAddService {
  constructor(private http: HttpClient) {}

  getStudentList() {
    return this.http.get("https://localhost:7249/api/Account");
  }

  getParentList() {
    return this.http.get("https://localhost:7249/api/Parent");
  }

  addParent(Student: any, FirstName: any, LastName: any, Email: any, Phone: any) {
    let ParentJson = {
      userUUID: Student,
      firstName: FirstName,
      lastName: LastName,
      email: Email,
      phone: Phone
    }

    this.http.post("https://localhost:7249/api/Parent", ParentJson).subscribe();
  }
}
