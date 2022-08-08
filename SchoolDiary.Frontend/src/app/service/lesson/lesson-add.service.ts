import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class LessonService {
  constructor(private http: HttpClient) {}

  addLesson(lessonName: any, day: any, hour: any) {
    let lesson = {
      name: lessonName,
      day: Number(day),
      hour: Number(hour)
    }

    return this.http.post('https://localhost:7249/api/Lesson', lesson);
  }

  addSubject(lessonID: Number, Class: any, teacher: any) {
    let subject = {
      lesson: Number(lessonID) + 1,
      class: Number(Class),
      teacher: Number(teacher),
    }
    
    return this.http.post('https://localhost:7249/api/Subject', subject);
  }

  getTeachers() {
    return this.http.get('https://localhost:7249/api/Teacher');
  }

  getLessonID() {
    return this.http.get('https://localhost:7249/api/Lesson');
  }
}
