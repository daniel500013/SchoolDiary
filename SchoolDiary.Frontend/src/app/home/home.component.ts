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

  ngOnInit() {
    this.http.get("https://localhost:7249/api/Lesson/2").subscribe(
      (res) => {
        console.log(res);
        this.lessons = res;
      }
    );
  }

}
