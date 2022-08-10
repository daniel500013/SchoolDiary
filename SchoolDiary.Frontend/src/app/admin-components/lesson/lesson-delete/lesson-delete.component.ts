import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/service/home/home.service';
import { LessonDeleteService } from 'src/app/service/lesson/lesson-delete.service';

@Component({
  selector: 'app-lesson-delete',
  templateUrl: './lesson-delete.component.html',
  styleUrls: ['./lesson-delete.component.css'],
})
export class LessonDeleteComponent implements OnInit {
  form!: FormGroup;

  //help lesson
  helpLesson: any = [];
  plan: Number = 1;

  teachers: any = [];
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

  //ngmodel
  lesson: any = 'Polish';
  day: Number = 1;
  hour: Number = 1;
  teacher: Number = 1;
  class: Number = 1;

  //error
  error: Boolean = false;

  constructor(private homeService: HomeService, private lessonService: LessonDeleteService) {}

  ngOnInit() {
    this.lessonService.getTeachers().subscribe((res) => {
      this.teachers = res;
    });
  }

  getLessonID() {
    this.error = false;

    this.lessonService.getLessonID(this.class).subscribe((res: any) => {
      let lessonID: any;
      let tmp: any = [];

      res.forEach((element: any) => {
        element.forEach((lessonList: any) => {
          tmp.push(lessonList);
        });
      });

      try {
        lessonID = tmp
          .filter((x: any) => x.name == this.lesson)
          .filter((x: any) => x.day == this.day)
          .filter((x: any) => x.hour == this.hour)[0].lessonID;
      } catch (error) {
        this.error = true;
      }

      this.getSubjectID(lessonID);
    });
  }

  getSubjectID(lessonID: any) {
    let subjectID: any;
    let tmp: any = [];

    this.lessonService.getSubjects().subscribe((res: any) => {
      res.forEach((element: any) => {
        tmp.push(element);
      });

      subjectID = tmp
        .filter((x: any) => x.fK_TeacherID == this.teacher)
        .filter((x: any) => x.fK_Class == this.class)
        .filter((x: any) => x.fK_LessonID == lessonID)[0].subjectID;

      this.removeLesson(lessonID);
    });
  }

  removeLesson(lessonID: any) {
    this.lessonService.removeLesson(lessonID).subscribe((res) => {
      this.getPlan();
    });
  }

  //lesson plan
  getPlan() {
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
