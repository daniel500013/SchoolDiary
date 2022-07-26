import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-lesson-add',
  templateUrl: './lesson-add.component.html',
  styleUrls: ['./lesson-add.component.css']
})
export class LessonAddComponent implements OnInit {

  form!: FormGroup;
  lessonForm!: FormGroup;

  lessons: any = [];
  teachers: any = [];

  plan: Number = 1;

  class: Number = 1;

  constructor(private formBuilder: FormBuilder,
    private http: HttpClient,
    private router: Router) { }

  ngOnInit() {
    this.form = this.formBuilder.group({
      class: 0
    });

    this.lessonForm = this.formBuilder.group({
      lesson: '',
      day: '1',
      hour: '1',
      teacher: ''
    });

    this.http.get('https://localhost:7249/api/Teacher').subscribe(
      (res) => {
        // console.log(res);
        this.teachers = res;
      }
    );
  }

  //Add Lesson
  addLesson(lessonID: Number) {
    let lesson = {
      name: this.lessonForm.value.lesson,
      day: Number(this.lessonForm.value.day),
      hour: Number(this.lessonForm.value.hour)
    }

    this.http.post('https://localhost:7249/api/Lesson', lesson).subscribe();

    let subject = {
      lesson: Number(lessonID) + 1,
      class: Number(this.class),
      teacher: Number(this.lessonForm.value.teacher),
    }
    
    this.http.post('https://localhost:7249/api/Subject', subject).subscribe();
    
    this.router.navigate(['/admin']);
  }

  getLessonID(): Number {
    let lessonID = 0;
    
    this.http.get('https://localhost:7249/api/Lesson').subscribe(
      (res: any) => {
        this.addLesson(res[res.length - 1].lessonID);
      }
    );

    return lessonID;
  }

  //lessons Plan
  getPlan() {
    this.http.get('https://localhost:7249/api/Lesson/' + this.class).subscribe(
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
