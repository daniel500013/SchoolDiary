import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ApproveAddService {
  constructor(private http: HttpClient) {}

  async addApprove(typeOfApprove: any, approveDescription: any, studentToApprove: any) {
    let approveJson = {
      positive: JSON.parse(typeOfApprove),
      description: approveDescription || '',
      userUUID: studentToApprove
    }
    
    await this.http.post("https://localhost:7249/api/Approve", approveJson).subscribe();
  }

  addLessonApprove(lessonID: any, ApproveID: any) {
    let lessonMarkJson = {
      fK_LessonID: lessonID,
      fK_ApproveID: ApproveID
    }

    this.http.post("https://localhost:7249/api/ApproveManager", lessonMarkJson).subscribe();
  }

  getStudentList(Class: Number) {
    return this.http.get("https://localhost:7249/api/ClassManager/" + Class);
  }

  getLessonID() {
    return this.http.get("https://localhost:7249/api/Lesson");
  }

  getSubjectID() {
    return this.http.get("https://localhost:7249/api/Subject");
  }

  getApproveID() {
    return this.http.get("https://localhost:7249/api/Approve");
  }
}
