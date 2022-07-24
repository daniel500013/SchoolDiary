import { Component } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { AuthService } from './service/auth/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SchoolDiary.Frontend';

  constructor(private jwtHelper: JwtHelperService) {}

  tokenExpired() {
    let tokenExpired = localStorage.getItem("token") || '';
    return this.jwtHelper.isTokenExpired(tokenExpired);
  }
}
