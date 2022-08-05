import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { HomeService } from 'src/app/service/home/home.service';

@Component({
  selector: 'app-mark-change',
  templateUrl: './mark-change.component.html',
  styleUrls: ['./mark-change.component.css'],
})
export class MarkChangeComponent implements OnInit {
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

  dates: any = [];
  filterMarks: any = [];

  //ngmodel
  lesson: any = 'Polish';
  day: Number = 1;
  hour: Number = 1;
  gradeWeight: Number = 1;
  class: Number = 1;
  date: any;

  //marks
  marks: any;
  marksToUpdate: any = [];

  constructor(private http: HttpClient, private homeService: HomeService) {}

  ngOnInit() {
    this.http.get('https://localhost:7249/api/Mark/' + this.class)
      .subscribe((res: any) => {
        console.log(res);

        this.marks = res;

        for (let index = 0; index < res.length; index++) {
          const element = res[index].date;
          this.dates.push(element);
        }

        this.dates = this.dates.filter(
          (item: any, i: any, ar: any) => ar.indexOf(item) === i
        );
      });
  }

  async findMarkToChange() {
    let subjectID;

    await this.http
      .get('https://localhost:7249/api/Subject')
      .subscribe((res: any) => {
        let element = res.filter((x: any) => x.fK_Class == this.class);
        this.getLesson(element);
      });
  }

  async getLesson(subjectID: any) {
    let lessonID;
    let tmp: any = [];

    let lesson: any;

    await this.http
      .get('https://localhost:7249/api/Lesson')
      .subscribe((res: any) => {
        lessonID = res
          .filter((x: any) => x.name == this.lesson)
          .filter((x: any) => x.day == this.day)
          .filter((x: any) => x.hour == this.hour);

        for (let index = 0; index < lessonID.length; index++) {
          const element = lessonID[index].lessonID;

          tmp.push(subjectID.filter((x: any) => x.fK_LessonID == element));
        }

        for (let index = 0; index < tmp.length; index++) {
          if (tmp[index].length >= 1) {
            lesson = tmp[index];
          }
        }

        this.getLessonMarks(lesson[0].fK_LessonID);

        // console.log(lessonID);
      });
  }

  async getLessonMarks(lessonID: any) {
    await this.http.get('https://localhost:7249/api/MarkManager')
      .subscribe((res: any) => {       
        let lessonMark = res.filter((x: any) => x.fK_LessonID == lessonID)
        this.loadMarks(lessonMark);
    });
  }

  async loadMarks(lessonMark: any) {
    for (let index = 0; index < lessonMark.length; index++) {
      const element = lessonMark[index].fK_MarkID;
      let marks = this.marks.filter((x: any) => x.markID == element)[0];
      this.marksToUpdate.push(marks);
    }
    
    await this.http.get("https://localhost:7249/api/Account").subscribe((res: any) => {
      for (let index = 0; index < this.marksToUpdate.length; index++) {
        var student = res.filter((x: any) => x.userUUID == this.marksToUpdate[index].fK_UserUUID)[0];
        this.students.push(student);
      }
    });
    
    this.filterMarks = this.marks.filter((x: any) => x.date == this.date);
  }

  //update marks
  async updateMarks() {
    for (let index = 0; index < this.students.length; index++) {
      let mark = (<HTMLInputElement>document.getElementById(this.students[index].userUUID)).checked;

      let markJson = {
        present: mark,
        userUUID: this.students[index].userUUID
      }
      console.log(mark);
      
      await this.http.put("https://localhost:7249/api/Mark/" + this.marksToUpdate[index].markID, markJson).toPromise();
    }
    
    this.filterMarks = [];
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
