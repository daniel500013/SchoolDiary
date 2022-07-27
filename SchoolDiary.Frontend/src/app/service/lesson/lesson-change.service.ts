import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LessonChangeService {

  constructor(private http: HttpClient) {}

  putLesson(lessonID: any, form: any) {
    let lessonJson = {
      name: form.value.lesson,
      day: form.value.day,
      hour: form.value.hour
    }

    return this.http.put('https://localhost:7249/api/Lesson/' + lessonID, lessonJson);
  }

  putSubject(subjectID: any, form: any) {
    let subjectJson = {
      teacher: form.value.teacher,
      class: form.value.class,
      lesson: subjectID.fK_LessonID
    }

    return this.http.put('https://localhost:7249/api/Subject/' + subjectID.subjectID, subjectJson);
  }

  getClass() {
    return this.http.get('https://localhost:7249/api/Class');
  }

  getTeachers() {
    return this.http.get('https://localhost:7249/api/Teacher');
  }

  getLessonID(Class: any) {
    return this.http.get('https://localhost:7249/api/Lesson/' + Class)
  }

  getSubject() {
    return this.http.get('https://localhost:7249/api/Subject');
  }

}
