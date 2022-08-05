import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-class-add',
  templateUrl: './class-add.component.html',
  styleUrls: ['./class-add.component.css']
})
export class ClassAddComponent implements OnInit {

  students: any = [];
  student: any;
  
  Class: any;

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
      classID: this.Class
    }
    
    this.http.post("https://localhost:7249/api/ClassManager", classManagerJson).subscribe();

    this.router.navigate(['/admin']);
  }
}
