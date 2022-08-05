import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ApproveDeleteService {
  constructor(private http: HttpClient) {}

  deleteApprove(approveIDToDelete: any) {
    this.http.delete('https://localhost:7249/api/Approve/' + approveIDToDelete).subscribe();
  }

  getStudentList(Class: Number) {
    return this.http.get('https://localhost:7249/api/ClassManager/' + Class);
  }

  getApproves() {
    return this.http.get('https://localhost:7249/api/Approve');
  }
}
