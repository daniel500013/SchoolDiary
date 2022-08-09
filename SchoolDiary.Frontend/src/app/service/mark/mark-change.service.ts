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

    this.http.put('https://localhost:7249/api/Mark/' + markID, MarkJson).subscribe();
  }
}
