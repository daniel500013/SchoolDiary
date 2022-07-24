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

  plan: Number = 5;
  present: Boolean = false;

  ngOnInit() {
    
    this.homeService.getLessons().subscribe(
      (res) => {
        //console.log(res);
        this.lessons = res;
      }
    );

    this.homeService.getGrades().subscribe(
      (res) => {
        //console.log(res);
        this.grades = res;
      }
    );

    this.homeService.getMarks().subscribe(
      (res) => {
        //console.log(res);
        this.marks = res;
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

  filterMarks(present: Boolean) {
    if (present) {
      this.present = true;
    }
    else {
      this.present = false;
    }
  }
}
