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
    localStorage.removeItem('Class');
    localStorage.removeItem('role');
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

  isLocalAdmin() {
    let role = localStorage.getItem("role") || '';

    if (role === "Admin" || role === "LocalAdmin")
    {
      return true
    }

    return false;
  }

  isTutor() {
    let role = localStorage.getItem("role") || '';

    if (role === "Admin" || role === "Tutor")
    {
      return true
    }

    return false;
  }
}
