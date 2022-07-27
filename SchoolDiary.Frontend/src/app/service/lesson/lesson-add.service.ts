import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class LessonService {
  constructor(private http: HttpClient) {}

  addLesson(lessonForm: any) {
    let lesson = {
      name: lessonForm.value.lesson,
      day: Number(lessonForm.value.day),
      hour: Number(lessonForm.value.hour)
    }

    this.http.post('https://localhost:7249/api/Lesson', lesson).subscribe();
  }

  addSubject(lessonID: Number, Class: any, lessonForm: any) {
    let subject = {
      lesson: Number(lessonID) + 1,
      class: Number(Class),
      teacher: Number(lessonForm.value.teacher),
    }
    
    this.http.post('https://localhost:7249/api/Subject', subject).subscribe();
  }

  getTeachers() {
    return this.http.get('https://localhost:7249/api/Teacher');
  }

  getLessonID() {
    return this.http.get('https://localhost:7249/api/Lesson');
  }
}
