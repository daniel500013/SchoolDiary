import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ApproveAddService } from 'src/app/service/approve/approve-add.service';
import { HomeService } from 'src/app/service/home/home.service';

@Component({
  selector: 'app-approve-add',
  templateUrl: './approve-add.component.html',
  styleUrls: ['./approve-add.component.css']
})
export class ApproveAddComponent implements OnInit {

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
    studentToApprove: any;
    typeOfApprove: any;
    approveDescription: any;
  
    constructor(private homeService: HomeService,
      private approveService: ApproveAddService) {}
  
    ngOnInit() {}
  
    getStudentList() {
      this.approveService.getStudentList(this.class).subscribe((res) => {
        this.students = res;
        console.log(res);
      });
    }

    addApproves() {
      this.approveService.addApprove(this.typeOfApprove, this.approveDescription, this.studentToApprove, this.lesson, this.day, this.hour, this.class);

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
