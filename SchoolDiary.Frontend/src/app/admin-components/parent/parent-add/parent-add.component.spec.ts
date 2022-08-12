/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ParentAddComponent } from './parent-add.component';

describe('ParentAddComponent', () => {
  let component: ParentAddComponent;
  let fixture: ComponentFixture<ParentAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ParentAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ParentAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
