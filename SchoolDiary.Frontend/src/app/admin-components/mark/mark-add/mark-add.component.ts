import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { HomeService } from 'src/app/service/home/home.service';
import { MarkAddService } from 'src/app/service/mark/mark-add.service';

@Component({
  selector: 'app-mark-add',
  templateUrl: './mark-add.component.html',
  styleUrls: ['./mark-add.component.css'],
})
export class MarkAddComponent implements OnInit {
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

  constructor(private http: HttpClient,
    private homeService: HomeService,
    private markService: MarkAddService) {}

  ngOnInit() {}

  getStudentList() {
    this.markService.getStudentList(this.class).subscribe((res) => {
      this.students = res;
    });
  }

  async addMarks() {
    for (let index = 0; index < this.students.length; index++) {
      let mark = (<HTMLInputElement>document.getElementById(this.students[index].userUUID)).checked;

      this.markService.addMark(mark, this.students[index].userUUID);
    }

    await this.getLessonID();
  }

  async getLessonID() {
    this.markService.getLessonID().subscribe((res: any) => {
      let lessonID = res.filter((x: any) => x.name == this.lesson)
      .filter((x: any) => x.day == this.day)
      .filter((x: any) => x.hour == this.hour)
      
      this.getSubject(lessonID);
    });
  }

  getSubject(lessonID: any) {  
    this.markService.getSubjectID().subscribe((res: any) => {
      let subjectList: any = [];

      for (let index = 0; index < lessonID.length; index++) {
        const element = lessonID[index];
        let subjectID = res.filter((x: any) => x.fK_LessonID == element.lessonID)
        .filter((x: any) => x.fK_Class == this.class)[0];

        subjectList.push(subjectID);
      }

      subjectList = subjectList.filter((item: any) => item);

      this.getMarkID(subjectList[0].fK_LessonID);
    });
  }

  getMarkID(lessonID: any) {
    this.markService.getMarkID().subscribe((res: any) => {
      for (let index = 0; index < this.students.length; index++) {
        let markID = res[(res.length - 1) - index].markID
        
        this.addLessonMark(lessonID, markID);

        if (index == this.students.length - 1)
        {
          this.students = [];
        }
      }
    });
  }

  addLessonMark(lessonID: Number, markID: Number) {
    this.markService.addLessonMark(lessonID, markID);
  }

  //lesson plan
  getPlan() {
     this.homeService.getLessons().subscribe((res) => {
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
