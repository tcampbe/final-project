import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent implements OnInit {
  public courses: Course[];
  //public newCourse: Course = { Type: '', Name: '', Category: '', WebSite: ''};
  //   Resource: , PreSchool: , Elementary: , MiddleSchool: , HighSchool: , HigherEducation: ,
    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

    async ngOnInit() {
      this.courses = await this.http.get<Course[]>(this.baseUrl + 'course').toPromise();
    }
    
    //async save() {
    //  await this.http.post<Course[]>(this.baseUrl + 'course', this.newCourse).toPromise();
    //  this.newCourse = { Type: '', Name: '', Category: '', WebSite: '' };
    //  //   Resource: , PreSchool: , Elementary: , MiddleSchool: , HighSchool: , HigherEducation: ,
    //  this.courses = await this.http.get<Course[]>(this.baseUrl + 'course').toPromise();
    //}
 }

interface Course {
  type: string;
  name: string;
  category: string;
  //resource: boolean;
  //preSchool: boolean;
  //elementary: boolean;
  //middleSchool: boolean;
  //highSchool: boolean;
  //higherEducation: boolean;
  webSite: string;
}
