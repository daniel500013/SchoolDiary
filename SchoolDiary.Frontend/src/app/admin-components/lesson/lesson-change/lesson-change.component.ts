import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/service/home/home.service';

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
    private http: HttpClient,
    private router: Router,
    private homeService: HomeService
  ) {}

  ngOnInit() {
    this.http.get('https://localhost:7249/api/Class').subscribe((res) => {
      console.log(res);
      this.classes = res;
    });

    this.http.get('https://localhost:7249/api/Teacher').subscribe((res) => {
      console.log(res);
      this.teachers = res;
    });

    this.form = this.formBuilder.group({
      lesson: '',
      day: 0,
      hour: 0,
      teacher: 0,
      class: 0
    });
  }

  //check ngmodel
  getSubjectID() {
    this.http
      .get('https://localhost:7249/api/Lesson/' + this.class)
      .subscribe((res: any) => {
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
        } catch (error) {
          this.error = true;
        }
      });
  }

  changeLesson() {
    let lessonJson = {
      name: this.form.value.lesson,
      day: this.form.value.day,
      hour: this.form.value.hour
    }

    this.http.put('https://localhost:7249/api/Lesson/' + this.lessonID, lessonJson).subscribe()


    this.http.get('https://localhost:7249/api/Subject').subscribe((res: any) => {
      let subjectID = res
        .filter((x: any) => x.fK_TeacherID == this.teacher)
        .filter((x: any) => x.fK_Class == this.class)
        .filter((x: any) => x.fK_LessonID == this.lessonID)[0];

        console.log(subjectID);
        
        this.updateChanges(subjectID);
      });
      
    console.log(this.form.getRawValue());
    
  }

  updateChanges(subjectID: any) {
   console.log(subjectID);
   
    let subjectJson = {
      teacher: this.form.value.teacher,
      class: this.form.value.class,
      lesson: subjectID.fK_LessonID
    }

    this.http.put('https://localhost:7249/api/Subject/' + subjectID.subjectID, subjectJson).subscribe();

    this.router.navigate(["/admin"]);
  }

  //lesson scheme
  getPlan() {
    this.homeService.getLessons(this.class).subscribe(
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

  //other functions
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
