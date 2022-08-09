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
        this.marks = res;

        for (let index = 0; index < res.length; index++) {
          const element = res[index].date;
          this.dates.push(element);
        }

        // this.dates = this.dates.filter(
        //   (item: any, i: any, ar: any) => ar.indexOf(item) === i
        // );
      });
  }

  findMarkToChange() {
    let MarkJson = {
      lesson: this.lesson,
      day: this.day,
      hour: this.hour,
      class: this.class,
      date: this.date
    }

    this.http.put('https://localhost:7249/api/Mark', MarkJson).subscribe((res) => {
      this.students = res;
    });
  }

  updateMarks() {
    for (let index = 0; index < this.students.length; index++) {
      let mark = (<HTMLInputElement>document.getElementById(this.students[index].markID)).checked;
      let markID = (<HTMLInputElement>document.getElementById(this.students[index].markID)).value;

      let MarkJson = {
        present: mark
      }

      this.http.put('https://localhost:7249/api/Mark/' + markID, MarkJson).subscribe();
    }

    this.students = [];
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
