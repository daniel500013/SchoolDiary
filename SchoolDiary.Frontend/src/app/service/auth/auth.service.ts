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
    this.http.post('https://localhost:7249/api/Account/Login', form.getRawValue()).subscribe((res: any) => {
        let tokenData = this.jwtHelper.decodeToken(res);
        
        localStorage.setItem("token", res);
        localStorage.setItem("uuid", tokenData.uuid);
        localStorage.setItem("Class", tokenData.Class);

        let role = tokenData["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];

        console.log(role);

        if (role.includes("Teacher"))
        {
          localStorage.setItem("role", "Teacher");
        }

        if (role.includes("Tutor"))
        {
          localStorage.setItem("role", "Tutor");
        }

        if (role.includes("LocalAdmin"))
        {
          localStorage.setItem("role", "LocalAdmin");
        }

        if (role.includes("Admin"))
        {
          localStorage.setItem("role", "Admin");
        }
        

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

  tokenExpired() {
    let tokenExpired = localStorage.getItem("token") || '';
    return this.jwtHelper.isTokenExpired(tokenExpired);
  }
}