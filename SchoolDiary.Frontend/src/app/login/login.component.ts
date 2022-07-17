import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthInterceptor } from '../interceptor/auth.interceptor';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  form!: FormGroup;

  constructor(private formBuilder: FormBuilder,
    private http: HttpClient,
    private router: Router) { }

  ngOnInit() {
    this.form = this.formBuilder.group({
      email: '',
      password: ''
    });
  }

  submit() {
    this.http.post('https://localhost:7249/api/Account/Login', this.form.getRawValue())
    .subscribe((res: any) => {
      localStorage.setItem("token", res);
      this.router.navigate(['/']);
    });
  }
}
