import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-grade-add',
  templateUrl: './grade-add.component.html',
  styleUrls: ['./grade-add.component.css']
})
export class GradeAddComponent implements OnInit {

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

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  getStudentList() {
    this.http.get("https://localhost:7249/api/ClassManager/" + this.class).subscribe((res) => {
      this.students = res;
      console.log(res);
    });
  }

  async addGrades() {
    for (let index = 0; index < this.students.length; index++) {
      let grade = (<HTMLInputElement>document.getElementById(this.students[index].userUUID)).value;

      let gradeJson = {
        gradeValue: grade,
        weight: this.gradeWeight,
        description: '',
        userUUID: this.students[index].userUUID
      }

      await this.http.post("https://localhost:7249/api/Grade", gradeJson).toPromise();
    }

    await this.getLessonID();
    
    //this.students = [];
    console.log("Complete");
  }

  async getLessonID() {
    this.http.get("https://localhost:7249/api/Lesson").subscribe((res: any) => {
      let lessonID = res.filter((x: any) => x.name == this.lesson)
      .filter((x: any) => x.day == this.day)
      .filter((x: any) => x.hour == this.hour)
      console.log(lessonID);
      
      this.getSubject(lessonID);
    });
  }

  getSubject(lessonID: any) {  
    this.http.get("https://localhost:7249/api/Subject").subscribe((res: any) => {
      
      let subjectList: any = [];

      for (let index = 0; index < lessonID.length; index++) {
        const element = lessonID[index];
        let subjectID = res.filter((x: any) => x.fK_LessonID == element.lessonID)
        .filter((x: any) => x.fK_Class == this.class)[0];

        subjectList.push(subjectID);
      }

      subjectList = subjectList.filter((item: any) => item);

      this.getGradeID(subjectList[0].fK_LessonID);
    });
  }

  getGradeID(lessonID: any) {
    this.http.get("https://localhost:7249/api/Grade").subscribe((res: any) => {
      for (let index = 0; index < this.students.length; index++) {
        let gradeID = res[(res.length - 1) - index].gradeID

        this.addLessonGrade(lessonID, gradeID);

        if (index == this.students.length - 1)
        {
          this.students = [];
        }
      }
    });
  }

  addLessonGrade(lessonID: Number, gradeID: Number) {
    let lessonGradeJson = {
      fK_LessonID: lessonID,
      fK_GradeID: gradeID
    }

    this.http.post("https://localhost:7249/api/GradeManager", lessonGradeJson).subscribe();
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
