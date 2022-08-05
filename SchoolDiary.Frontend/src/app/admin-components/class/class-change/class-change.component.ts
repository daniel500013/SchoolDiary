import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-class-change',
  templateUrl: './class-change.component.html',
  styleUrls: ['./class-change.component.css']
})
export class ClassChangeComponent implements OnInit {

  students: any = [];
  student: any;
  
  Class: any;
  ClassNew: any;

  constructor(private http: HttpClient,
    private router: Router) { }

  ngOnInit() {
    this.http.get("https://localhost:7249/api/Account").subscribe(res => {
      this.students = res;
    });
  }

  assignToClass() {
    let classManagerJson = {
      userUUID: this.student,
      classID: this.ClassNew
    }
    
    this.http.put("https://localhost:7249/api/ClassManager/" + this.Class, classManagerJson).subscribe();

    this.router.navigate(['/admin']);
  }
}
