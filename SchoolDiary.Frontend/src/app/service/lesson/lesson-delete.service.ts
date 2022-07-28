import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LessonDeleteService {

  constructor(private http: HttpClient) { }
  
  removeLesson(lessonID: any) {
    return this.http.delete('https://localhost:7249/api/Lesson/' + lessonID);
  }

  getLessonID(Class: any) {
    return this.http.get('https://localhost:7249/api/Lesson/' + Class);
  }

  getSubjects() {
    return this.http.get('https://localhost:7249/api/Subject');
  }

  getTeachers() {
    return this.http.get('https://localhost:7249/api/Teacher');
  }
}
