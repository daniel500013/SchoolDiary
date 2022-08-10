import { Component, OnInit } from '@angular/core';
import { RoleDeleteService } from 'src/app/service/role/role-delete.service';

@Component({
  selector: 'app-role-delete',
  templateUrl: './role-delete.component.html',
  styleUrls: ['./role-delete.component.css']
})
export class RoleDeleteComponent implements OnInit {

  students: any = [];
  roles: any = [];

  //ngmodel
  student: any;
  role: any;

  constructor(private roleService: RoleDeleteService) { }

  ngOnInit() {
    this.roleService.getStudentList().subscribe((res) => {
      this.students = res;
    });
  }

  getRoles() {
    this.roleService.getRoles(this.student).subscribe((res) => {
      this.roles = res;
    });
  }

  deleteRole() {
    this.roleService.deleteRole(this.role).subscribe();
    this.roles = [];
  }
}
