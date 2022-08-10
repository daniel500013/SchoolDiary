import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { GradeAddService } from 'src/app/service/grade/grade-add.service';
import { HomeService } from 'src/app/service/home/home.service';

@Component({
  selector: 'app-grade-add',
  templateUrl: './grade-add.component.html',
  styleUrls: ['./grade-add.component.css'],
})
export class GradeAddComponent implements OnInit {
  //help lesson
  helpLesson: any = [];
  plan: Number = 1;

  lessons: any = [
    'Polish',
    'Geography',
    'Chemistry',
    'Math',
    'PE',
    'History',
    'English',
    'Physics',
  ];

  students: any = [];

  //ngmodel
  lesson: any = 'Polish';
  day: Number = 1;
  hour: Number = 1;
  gradeWeight: Number = 1;
  class: Number = 1;

  constructor(private homeService: HomeService, private gradeService: GradeAddService) {}

  ngOnInit() {}

  getStudentList() {
    this.gradeService.getStudentList(this.class).subscribe((res) => {
      this.students = res;
    });
  }

  addGrades() {
    for (let index = 0; index < this.students.length; index++) {
      let grade = (<HTMLInputElement>(document.getElementById(this.students[index].userUUID))).value;

      this.gradeService.addGrades(
        grade,
        this.gradeWeight,
        this.students[index].userUUID,
        this.lesson,
        this.day,
        this.hour,
        this.class
      );
    }

    this.students = [];
  }

  //lesson plan
  async getPlan() {
    this.homeService.getLessons(this.class).subscribe((res) => {
      this.helpLesson = res;
    });
  }

  changePlan(value: any) {
    if (this.plan + value > 5) {
      this.plan = 4;
    }

    if (this.plan + value < 1) {
      this.plan = 2;
    }

    this.plan = this.plan + value;
  }

  mapDays(day: any): any {
    switch (day) {
      case 1:
        return 'Monday';
      case 2:
        return 'Thursday';
      case 3:
        return 'Wednesday';
      case 4:
        return 'Thursday';
      case 5:
        return 'Friday';
    }
  }
}
