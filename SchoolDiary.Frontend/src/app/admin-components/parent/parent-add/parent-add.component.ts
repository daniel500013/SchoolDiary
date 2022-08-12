import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ParentAddService } from 'src/app/service/parent/parent-add.service';

@Component({
  selector: 'app-parent-add',
  templateUrl: './parent-add.component.html',
  styleUrls: ['./parent-add.component.css']
})
export class ParentAddComponent implements OnInit {

  students: any = [];
  parents: any = [];

  //ngmodel
  FirstName: any;
  LastName: any;
  Email: any;
  Phone: any;
  Student: any;

  constructor(private parentService: ParentAddService, private router: Router) { }

  ngOnInit() {
    this.parentService.getStudentList().subscribe((res) => {
      this.students = res;
    });

    this.parentService.getParentList().subscribe((res) => {
      this.parents = res;
      console.log(res);
    });
  }

  assignParent() {
    this.parentService.addParent(this.Student, this.FirstName, this.LastName, this.Email, this.Phone);

    this.router.navigate(['/admin']);
  }

}
