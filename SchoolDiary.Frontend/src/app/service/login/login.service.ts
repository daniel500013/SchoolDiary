import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

constructor(private http: HttpClient,
  private router: Router) { }

login(form: any) {
  this.http.post('https://localhost:7249/api/Account/Login', form.getRawValue())
    .subscribe((res: any) => {
      localStorage.setItem("token", res);
      this.router.navigate(['/']);
    });
}

}