import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class MarkAddService {
  constructor(private http: HttpClient) {}

  addMark(mark: Boolean, userUUID: any, lesson: any, day: any, hour: any, Class: any) {
    let markJson = {
      present: mark,
      userUUID: userUUID,
      lesson: lesson,
      day: day,
      hour: hour,
      class: Class 
    }

    this.http.post("https://localhost:7249/api/Mark", markJson).subscribe();
  }

  getStudentList(Class: Number) {
    return this.http.get("https://localhost:7249/api/ClassManager/" + Class);
  }
}
