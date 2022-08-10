import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/service/home/home.service';
import { LessonChangeService } from 'src/app/service/lesson/lesson-change.service';

@Component({
  selector: 'app-lesson-change',
  templateUrl: './lesson-change.component.html',
  styleUrls: ['./lesson-change.component.css'],
})
export class LessonChangeComponent implements OnInit {
  form!: FormGroup;
  
  //help lesson
  helpLesson: any = [];
  plan: Number = 1;

  //view
  classes: any = [];
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

  //ngModel
  lesson: any = "Polish";
  day: Number = 1;
  hour: Number = 1;
  teacher: Number = 1;
  class: Number = 1;

  //changelesson
  lessonID: any;

  //error 
  error = false;

  constructor(
    private formBuilder: FormBuilder,
    private homeService: HomeService,
    private lessonService: LessonChangeService
  ) {}

  ngOnInit() {
    this.lessonService.getClass().subscribe((res) => {
      this.classes = res;
    });

    this.lessonService.getTeachers().subscribe((res) => {
      this.teachers = res;
    });

    this.form = this.formBuilder.group({
      lesson: 'Physics',
      day: 5,
      hour: 1,
      teacher: 19,
      class: 10
    });
  }

  //check lesson exist
  getLessonID() {
    this.error = false;

    this.lessonService.getLessonID(this.class).subscribe((res: any) => {
      let tmp: any = [];

      res.forEach((element: any) => {
        element.forEach((lessonList: any) => {
          tmp.push(lessonList);
        });
      });

      try {
        this.lessonID = tmp
          .filter((x: any) => x.name == this.lesson)
          .filter((x: any) => x.day == this.day)
          .filter((x: any) => x.hour == this.hour)[0].lessonID;
      } 
      catch (error) {
        this.error = true;
      }
    });
  }

  changeLesson() {
    this.lessonService.putLesson(this.lessonID, this.form).subscribe();

    this.lessonService.getSubject().subscribe((res: any) => {
      let subjectID = res
        .filter((x: any) => x.fK_TeacherID == this.teacher)
        .filter((x: any) => x.fK_Class == this.class)
        .filter((x: any) => x.fK_LessonID == this.lessonID)[0];
        
        this.updateChanges(subjectID);
      });
  }

  updateChanges(subjectID: any) {
    this.lessonService.putSubject(subjectID, this.form).subscribe((res) => {
      this.getPlan();
      this.lessonID = null;
    });
  }

  //lesson plan
  getPlan() {
    this.homeService.getLessons().subscribe(
      (res) => {
        this.helpLesson = res;
      }
    );
  }

  changePlan(value: any) {
    if (this.plan + value > 5)
    {
      this.plan = 4;
    }
    
    if (this.plan + value < 1)
    {
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
