import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class HomeService {
  constructor(private http: HttpClient) {}

  getClass() {
    return this.http.get('https://localhost:7249/api/ClassManager');
  }

  getLessons(userClass: Number = 1) {
    return this.http.get('https://localhost:7249/api/Subject/' + userClass);
  }

  getGrades() {
    return this.http.get('https://localhost:7249/api/Grade/' + localStorage.getItem('uuid'));
  }

  getMarks() {
    return this.http.get('https://localhost:7249/api/Mark/' + localStorage.getItem('uuid'));
  }

  getApproves() {
    return this.http.get('https://localhost:7249/api/Approve/' + localStorage.getItem('uuid'));
  }
}
