import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ParentDeleteService } from 'src/app/service/parent/parent-delete.service';

@Component({
  selector: 'app-parent-delete',
  templateUrl: './parent-delete.component.html',
  styleUrls: ['./parent-delete.component.css']
})
export class ParentDeleteComponent implements OnInit {

  parents: any = [];

  //ngmodel
  parent: any;

  constructor(private parentService: ParentDeleteService, private router: Router) { }

  ngOnInit() {
    this.parentService.getParentList().subscribe((res) => {
      this.parents = res;
    });
  }

  removeParent() {
    this.parentService.removeParent(this.parent);
    this.router.navigate(['/admin']);
  }
}
