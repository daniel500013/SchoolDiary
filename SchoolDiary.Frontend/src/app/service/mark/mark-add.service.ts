import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class MarkAddService {
  constructor(private http: HttpClient) {}

  async addMark(mark: Boolean, userUUID: any) {
    let markJson = {
      present: mark,
      userUUID: userUUID
    }

    await this.http.post("https://localhost:7249/api/Mark", markJson).toPromise();
  }

  addLessonMark(lessonID: Number, markID: Number) {
    let lessonMarkJson = {
      fK_LessonID: lessonID,
      fK_MarkID: markID
    }

    this.http.post("https://localhost:7249/api/MarkManager", lessonMarkJson).subscribe();
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

  getMarkID() {
    return this.http.get("https://localhost:7249/api/Mark");
  }
}
