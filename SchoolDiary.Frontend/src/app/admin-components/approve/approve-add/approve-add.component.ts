import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { HomeService } from 'src/app/service/home/home.service';

@Component({
  selector: 'app-approve-add',
  templateUrl: './approve-add.component.html',
  styleUrls: ['./approve-add.component.css']
})
export class ApproveAddComponent implements OnInit {

    //help lesson
    helpLesson: any = [];
    plan: Number = 1;
  
    lessons: any = [
      'Polish',
      'Geography',
      'Chemistry',
      'Math',
      'PE',
      'History',
      'English',
      'Physics',
    ];
  
    students: any = [];
  
    //ngmodel
    lesson: any = 'Polish';
    day: Number = 1;
    hour: Number = 1;
    gradeWeight: Number = 1;
    class: Number = 1;
    studentToApprove: any;
    typeOfApprove: Boolean = true;
    approveDescription: any;
  
    constructor(private http: HttpClient,
      private homeService: HomeService) {}
  
    ngOnInit() {}
  
    getStudentList() {
      this.http.get("https://localhost:7249/api/ClassManager/" + this.class).subscribe((res) => {
        this.students = res;
        console.log(res);
      });
    }

    async addApproves() {
      let approveJson = {
        positive: this.typeOfApprove,
        description: this.approveDescription || '',
        userUUID: this.studentToApprove
      }

      console.log(this.typeOfApprove);
      console.log(this.approveDescription);
      console.log(this.studentToApprove);
      
      
      await this.http.post("https://localhost:7249/api/Approve", approveJson).subscribe();
  
      await this.getLessonID();
      
      console.log("Complete");
    }
  
    async getLessonID() {
      this.http.get("https://localhost:7249/api/Lesson").subscribe((res: any) => {
        let lessonID = res.filter((x: any) => x.name == this.lesson)
        .filter((x: any) => x.day == this.day)
        .filter((x: any) => x.hour == this.hour)
        console.log(lessonID);
        
        this.getSubject(lessonID);
      });
    }
  
    getSubject(lessonID: any) {  
      this.http.get("https://localhost:7249/api/Subject").subscribe((res: any) => {
        
        let subjectList: any = [];
  
        for (let index = 0; index < lessonID.length; index++) {
          const element = lessonID[index];
          let subjectID = res.filter((x: any) => x.fK_LessonID == element.lessonID)
          .filter((x: any) => x.fK_Class == this.class)[0];
  
          subjectList.push(subjectID);
        }
  
        subjectList = subjectList.filter((item: any) => item);
  
        this.getMarkID(subjectList[0].fK_LessonID);
      });
    }
  
    getMarkID(lessonID: any) {
      this.http.get("https://localhost:7249/api/Approve").subscribe((res: any) => {
        let ApproveID = res[(res.length - 1)].approveID
          
        this.addLessonMark(lessonID, ApproveID);
        
        this.students = [];
      });
    }
  
    addLessonMark(lessonID: Number, ApproveID: Number) {
      let lessonMarkJson = {
        fK_LessonID: lessonID,
        fK_ApproveID: ApproveID
      }
  
      this.http.post("https://localhost:7249/api/ApproveManager", lessonMarkJson).subscribe();
    }
  
    //lesson plan
    getPlan() {
      this.homeService.getLessons(this.class).subscribe((res) => {
        this.helpLesson = res;
      });
    }
  
    changePlan(value: any) {
      if (this.plan + value > 5) {
        this.plan = 4;
      }
  
      if (this.plan + value < 1) {
        this.plan = 2;
      }
  
      this.plan = this.plan + value;
    }
  
    mapDays(day: any): any {
      switch (day) {
        case 1:
          return 'Monday';
        case 2:
          return 'Thursday';
        case 3:
          return 'Wednesday';
        case 4:
          return 'Thursday';
        case 5:
          return 'Friday';
      }
    }
}
