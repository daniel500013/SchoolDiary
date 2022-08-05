import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class GradeAddService {
  constructor(private http: HttpClient) {}

  async addGrades(grade: string, gradeWeight: Number, userUUID: any) {
    let gradeJson = {
      gradeValue: grade,
      weight: gradeWeight,
      description: '',
      userUUID: userUUID
    }

    await this.http.post("https://localhost:7249/api/Grade", gradeJson).toPromise();
  }

  addLessonGrade(lessonID: Number, gradeID: Number) {
    let lessonGradeJson = {
      fK_LessonID: lessonID,
      fK_GradeID: gradeID
    }

    return this.http.post("https://localhost:7249/api/GradeManager", lessonGradeJson).subscribe();
  }

  getGradeID() {
    return this.http.get("https://localhost:7249/api/Grade");
  }

  getSubjectID() {
    return this.http.get("https://localhost:7249/api/Subject");
  }

  getLessonID() {
    return this.http.get("https://localhost:7249/api/Lesson");
  }

  getStudentList(Class: Number) {
    return this.http.get("https://localhost:7249/api/ClassManager/" + Class);
  }
}
