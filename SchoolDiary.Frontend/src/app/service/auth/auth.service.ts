import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient,
    private router: Router,
    private jwtHelper: JwtHelperService) { }
  
  login(form: any) {
    this.http.post('https://localhost:7249/api/Account/Login', form.getRawValue())
      .subscribe((res: any) => {
        localStorage.setItem("token", res);
        localStorage.setItem("uuid", this.jwtHelper.decodeToken(res).uuid);

        this.router.navigate(['/']);
      });
  }

  register(form: any) {
    this.http.post('https://localhost:7249/api/Account/Register', form.getRawValue())
      .subscribe(() => {
        this.router.navigate(['/login']);
      });
  }

  isLoggedIn() {
    return !!localStorage.getItem("token");
  }
}
