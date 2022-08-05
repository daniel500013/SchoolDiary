import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ApproveDeleteService } from 'src/app/service/approve/approve-delete.service';
import { HomeService } from 'src/app/service/home/home.service';

@Component({
  selector: 'app-approve-delete',
  templateUrl: './approve-delete.component.html',
  styleUrls: ['./approve-delete.component.css'],
})
export class ApproveDeleteComponent implements OnInit {
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
  approveToDelete: any = [];

  //ngmodel
  lesson: any = 'Polish';
  day: Number = 1;
  hour: Number = 1;
  class: Number = 1;
  user: any;
  approveIDToDelete: any;

  constructor(private http: HttpClient, private homeService: HomeService, private approveService: ApproveDeleteService) {}

  ngOnInit() {}

  getStudentList() {
    
    this.approveService.getStudentList(this.class).subscribe((res) => {
        this.students = res;
    });
  }

  getApproves() {
    this.approveService.getApproves().subscribe((res: any) => {
      this.approveToDelete = res.filter((x: any) => x.fK_UserUUID == this.user);
    });
  }

  deleteApprove() {
    this.approveService.deleteApprove(this.approveIDToDelete);

    this.approveToDelete = [];
    this.students = [];
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
