import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ParentDeleteService {
  constructor(private http: HttpClient) {}

  getParentList() {
    return this.http.get("https://localhost:7249/api/Parent");
  }

  removeParent(parentID: any) {
    this.http.delete("https://localhost:7249/api/Parent/" + parentID).subscribe();
  }
}
