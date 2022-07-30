import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class HomeService {
  constructor(private http: HttpClient) {}

  getLessons(userClass: Number = 1) {
    return this.http.get('https://localhost:7249/api/Subject/' + userClass);
  }

  getGrades(uuid: String = '65f9a764-1286-463d-bb3c-aaced9edbd61') {
    return this.http.get('https://localhost:7249/api/GradeManager/' + uuid);
  }

  getMarks(uuid: String = '65f9a764-1286-463d-bb3c-aaced9edbd61') {
    return this.http.get('https://localhost:7249/api/MarkManager/' + uuid);
  }

  getApproves(uuid: String = '65f9a764-1286-463d-bb3c-aaced9edbd61') {
    return this.http.get('https://localhost:7249/api/ApproveManager/' + uuid);
  }
}
