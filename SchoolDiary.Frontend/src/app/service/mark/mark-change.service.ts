import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class MarkChangeService {
  constructor(private http: HttpClient) {}

  async updateMarks(mark: Boolean, userUUID: any, markID: any) {
    let markJson = {
      present: mark,
      userUUID: userUUID
    }
    
    await this.http.put("https://localhost:7249/api/Mark/" + markID, markJson).toPromise();
  }

  getMarks(Class: Number) {
    return this.http.get('https://localhost:7249/api/Mark/' + Class);
  }

  async getSubjects() {
    return await this.http.get('https://localhost:7249/api/Subject');
  }

  async getLesson() {
    return await this.http.get('https://localhost:7249/api/Lesson');
  }

  async getLessonMarks() {
    return await this.http.get('https://localhost:7249/api/MarkManager');
  }

  async getAccount() {
    return await this.http.get("https://localhost:7249/api/Account");
  }
}
