import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('uuid');
  }

  isAdmin() {
    let role = localStorage.getItem("role") || '';

    if (role === "Admin")
    {
      return true
    }

    return false;
  }

  isTeacher() {
    let role = localStorage.getItem("role") || '';

    if (role === "Admin" || role === "Teacher")
    {
      return true
    }

    return false;
  }
}
