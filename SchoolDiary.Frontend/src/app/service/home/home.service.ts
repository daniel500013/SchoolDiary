import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class HomeService {
  constructor(private http: HttpClient) {}

  getLessons(userClass: Number = 3) {
    return this.http.get('https://localhost:7249/api/Lesson/' + userClass);
  }

  getGrades(uuid: String = '6EC7DB2A-250A-4FB1-B65A-00116E9C91D1') {
    return this.http.get('https://localhost:7249/api/GradeManager/' + uuid);
  }

  getMarks(uuid: String = '6EC7DB2A-250A-4FB1-B65A-00116E9C91D1') {
    return this.http.get('https://localhost:7249/api/MarkManager/' + uuid);
  }

  getApproves(uuid: String = '15EE4E40-5672-4AB8-9EBF-E0EE61335DC4') {
    return this.http.get('https://localhost:7249/api/ApproveManager/' + uuid);
  }
}
