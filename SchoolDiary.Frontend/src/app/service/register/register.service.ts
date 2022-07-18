import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

constructor(private http: HttpClient,
  private router: Router) { }

register(form: any) {
  this.http.post('https://localhost:7249/api/Account/Register', form.getRawValue())
    .subscribe(() => {
      this.router.navigate(['/login']);
    });
}

}
