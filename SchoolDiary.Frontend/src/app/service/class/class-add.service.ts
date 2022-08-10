import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ClassAddService {
  constructor(private http: HttpClient) {}

  assignToClass(student: any, Class: any) {
    let classManagerJson = {
      userUUID: student,
      classID: Class
    }
    
    return this.http.post("https://localhost:7249/api/ClassManager", classManagerJson);
  }

  getAllStudents() {
    return this.http.get("https://localhost:7249/api/Account");
  }
}
