import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/service/home/home.service';
import { RoleAddService } from 'src/app/service/role/role-add.service';

@Component({
  selector: 'app-role-add',
  templateUrl: './role-add.component.html',
  styleUrls: ['./role-add.component.css'],
})
export class RoleAddComponent implements OnInit {
  students: any = [];

  //ngmodel
  student: any;
  role: any;

  constructor(private roleService: RoleAddService, private route: Router) {}

  ngOnInit() {
    this.roleService.getStudentList().subscribe((res) => {
      this.students = res;
    });
  }

  mapRole(roleID: any) {
    switch (roleID) {
      case 1:
        return "Student";
      case 2:
        return "Teacher";
      case 3:
        return "Tutor";
      case 4:
        return "LocalAdmin";
      case 5:
        return "Admin";
      default:
        return "Student";
    }
  }

  assignRole() {
    this.roleService.assignRole(this.student, this.role).subscribe();

    this.route.navigate(['/admin']);
  }
}
