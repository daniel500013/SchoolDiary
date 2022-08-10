import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ClassChangeService } from 'src/app/service/class/class-change.service';

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

  constructor(private router: Router,
    private classService: ClassChangeService) { }

  ngOnInit() {
    this.classService.getAllStudents().subscribe((res) => {
      this.students = res;
    });
  }

  assignToClass() {
    this.classService.assignToClass(this.student, this.ClassNew, this.Class);

    this.router.navigate(['/admin']);
  }
}
