import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/service/home/home.service';
import { LessonService } from 'src/app/service/lesson/lesson-add.service';

@Component({
  selector: 'app-lesson-add',
  templateUrl: './lesson-add.component.html',
  styleUrls: ['./lesson-add.component.css']
})
export class LessonAddComponent implements OnInit {

  //forms
  form!: FormGroup;
  lessonForm!: FormGroup;

  //view
  lessons: any = [];
  teachers: any = [];
  plan: Number = 1;

  //ngmodel
  class: Number = 1;

  constructor(private formBuilder: FormBuilder,
    private router: Router,
    private homeService: HomeService,
    private lessonService: LessonService) { }

  ngOnInit() {
    this.form = this.formBuilder.group({
      class: 0
    });

    this.lessonForm = this.formBuilder.group({
      lesson: '',
      day: '1',
      hour: '1',
      teacher: 1
    });

    this.lessonService.getTeachers().subscribe(
      (res) => {
        this.teachers = res;
      }
    );
  }

  //Add Lesson
  addLesson(lessonID: Number) {
    this.lessonService.addLesson(this.lessonForm).subscribe();
    
    this.lessonService.addSubject(lessonID, this.class, this.lessonForm).subscribe((res) => {
      this.getPlan();
    });
  }

  getLessonID(): Number {
    let lessonID = 0;
    
    this.lessonService.getLessonID().subscribe(
      (res: any) => {
        this.addLesson(res[res.length - 1].lessonID);
      }
    );

    return lessonID;
  }

  //lessons Plan
  async getPlan() {
    this.homeService.getLessons().subscribe(
      (res) => {
        //console.log(res);
        this.lessons = res;
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
        return "Monday";
      case 2:
        return "Thursday";
      case 3:
        return "Wednesday";
      case 4:
        return "Thursday";
      case 5:
        return "Friday";
    }
  }
}
