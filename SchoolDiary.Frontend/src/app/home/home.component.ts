import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private http: HttpClient) { }

  lessons: any;

  plan: Number = 5;

  ngOnInit() {
    this.http.get("https://localhost:7249/api/Lesson/2").subscribe(
      (res) => {
        console.log(res);
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
