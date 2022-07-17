import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get("https://localhost:7249/api/Account").subscribe(
      (res) => {
        console.log(res);
      },
      (err) => {
        console.log(err);
        
      }
    );
  }

}
