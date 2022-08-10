import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ClassChangeService {
  constructor(private http: HttpClient) {}

  assignToClass(student: any, newClassID: any, Class: any) {
    let classManagerJson = {
      userUUID: student,
      classID: newClassID
    }
    
    return this.http.put("https://localhost:7249/api/ClassManager/" + Class, classManagerJson).subscribe();
  }

  getAllStudents() {
    return this.http.get("https://localhost:7249/api/Account");
  }
}
