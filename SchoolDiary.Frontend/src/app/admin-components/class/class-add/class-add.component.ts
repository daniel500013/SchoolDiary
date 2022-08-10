import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ClassAddService } from 'src/app/service/class/class-add.service';

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
    private router: Router,
    private classService: ClassAddService) { }

  ngOnInit() {
    this.classService.getAllStudents().subscribe((res) => {
      this.students = res;
    });
  }

  assignToClass() {
    this.classService.assignToClass(this.student, this.Class).subscribe();

    this.router.navigate(['/admin']);
  }
}
