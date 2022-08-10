import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class MarkChangeService {
  constructor(private http: HttpClient) {}

  updateMarks(mark: Boolean, markID: any) {
    let MarkJson = {
      present: mark
    }

    return this.http.put('https://localhost:7249/api/Mark/' + markID, MarkJson);
  }

  getStudentListToUpdate(lesson: any, day: any, hour: any, Class: any, date: any) {
    let MarkJson = {
      lesson: lesson,
      day: day,
      hour: hour,
      class: Class,
      date: date
    }

    return this.http.put('https://localhost:7249/api/Mark', MarkJson);
  }

  getClassMarks(Class: any) {
    return this.http.get('https://localhost:7249/api/Mark/' + Class);
  }
}
