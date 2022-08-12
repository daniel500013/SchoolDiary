import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { HomeService } from '../service/home/home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private homeService: HomeService) { }

  lessons: any = [];
  grades: any = [];
  marks: any = [];
  approves: any = [];
  parents: any = [];

  plan: Number = 1;
  present: Boolean = false;

  //error
  gradeError: Boolean = true;
  markError: Boolean = true;
  approveError: Boolean = true;

  ngOnInit() {
    this.homeService.getHomeLessons().subscribe((res) => {
        this.lessons = res;
    });

    this.homeService.getGrades().subscribe(
      (res) => {
        this.grades = res;
      }
    );

    this.homeService.getMarks().subscribe(
      (res) => {
        this.marks = res;
      }
    );

    this.homeService.getApproves().subscribe(
      (res) => {
        this.approves = res;
      }
    );

    this.homeService.getParents().subscribe((res) => {
      this.parents = res;
    });

    console.log(this.parents.length);
    
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

  filterMarks(present: Boolean) {
    if (present) {
      this.present = true;
    }
    else {
      this.present = false;
    }
  }
}
