import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class GradeAddService {
  constructor(private http: HttpClient) {}

  addGrades(grade: string, gradeWeight: Number, userUUID: any, lesson: any, day: any, hour: any, Class: any) {
    let gradeJson = {
      gradeValue: grade,
      weight: gradeWeight,
      description: '',
      userUUID: userUUID,
      lesson: lesson,
      day: day,
      hour: hour,
      class: Class,
    };

    this.http.post('https://localhost:7249/api/Grade', gradeJson).subscribe();
  }

  getStudentList(Class: Number) {
    return this.http.get("https://localhost:7249/api/ClassManager/" + Class);
  }
}
