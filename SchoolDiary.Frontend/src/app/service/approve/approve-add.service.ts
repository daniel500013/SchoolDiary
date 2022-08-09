import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ApproveAddService {
  constructor(private http: HttpClient) {}

  addApprove(typeOfApprove: any, approveDescription: any, studentUUID: any, lesson: any, day: any, hour: any, Class: any) {
    let approveJson = {
      positive: JSON.parse(typeOfApprove),
      description: approveDescription,
      userUUID: studentUUID,
      lesson: lesson,
      day: day,
      hour: hour,
      class: Class
    }
    
    this.http.post("https://localhost:7249/api/Approve", approveJson).subscribe();
  }

  getStudentList(Class: Number) {
    return this.http.get("https://localhost:7249/api/ClassManager/" + Class);
  }
}
