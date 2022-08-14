/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { LocaladminComponent } from './localadmin.component';

describe('LocaladminComponent', () => {
  let component: LocaladminComponent;
  let fixture: ComponentFixture<LocaladminComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocaladminComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocaladminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
