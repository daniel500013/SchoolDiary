import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { JwtHelperService, JWT_OPTIONS } from '@auth0/angular-jwt';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClient, HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http"
import { ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { Routes, RouterModule } from '@angular/router';
import { AuthInterceptor } from './interceptor/auth.interceptor';
import { AuthGuard } from './auth.guard';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AdminComponent } from './admin/admin.component';
import { LessonAddComponent } from './admin-components/lesson/lesson-add/lesson-add.component';
import { LessonChangeComponent } from './admin-components/lesson/lesson-change/lesson-change.component';
import { LessonDeleteComponent } from './admin-components/lesson/lesson-delete/lesson-delete.component';
import { FormsModule } from '@angular/forms';
import { GradeAddComponent } from './admin-components/grade/grade-add/grade-add.component';
import { MarkAddComponent } from './admin-components/mark/mark-add/mark-add.component';
import { MarkChangeComponent } from './admin-components/mark/mark-change/mark-change.component';
import { ApproveAddComponent } from './admin-components/approve/approve-add/approve-add.component';
import { ApproveDeleteComponent } from './admin-components/approve/approve-delete/approve-delete.component';
import { ClassAddComponent } from './admin-components/class/class-add/class-add.component';
import { ClassChangeComponent } from './admin-components/class/class-change/class-change.component';

const routes: Routes = [
  { path: '', component: HomeComponent, canActivate: [AuthGuard]},
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'admin', component: AdminComponent, canActivate: [AuthGuard] },
  { path: 'lessonadd', component: LessonAddComponent, canActivate: [AuthGuard] },
  { path: 'lessonchange', component: LessonChangeComponent, canActivate: [AuthGuard] },
  { path: 'lessondelete', component: LessonDeleteComponent, canActivate: [AuthGuard] },
  { path: 'gradeadd', component: GradeAddComponent, canActivate: [AuthGuard] },
  { path: 'markadd', component: MarkAddComponent, canActivate: [AuthGuard] },
  { path: 'markchange', component: MarkChangeComponent, canActivate: [AuthGuard] },
  { path: 'approveadd', component: ApproveAddComponent, canActivate: [AuthGuard] },
  { path: 'approvedelete', component: ApproveDeleteComponent, canActivate: [AuthGuard] },
  { path: 'classadd', component: ClassAddComponent, canActivate: [AuthGuard] },
  { path: 'classchange', component: ClassChangeComponent, canActivate: [AuthGuard] },
];

@NgModule({
  declarations: [					
    AppComponent,
      HomeComponent,
      LoginComponent,
      RegisterComponent,
      NavMenuComponent,
      AdminComponent,
      LessonAddComponent,
      LessonChangeComponent,
      LessonDeleteComponent,
      GradeAddComponent,
      MarkAddComponent,
      MarkChangeComponent,
      ApproveAddComponent,
      ApproveDeleteComponent,
      ClassAddComponent,
      ClassChangeComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routes),
    FormsModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    },
    { 
      provide: JWT_OPTIONS, 
      useValue: JWT_OPTIONS 
    }, JwtHelperService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
