import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LessonDeleteService {

  constructor(private http: HttpClient) { }
  
  getTeachers() {
    return this.http.get('https://localhost:7249/api/Teacher');
  }
}
