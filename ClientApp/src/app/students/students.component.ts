import { Component, Inject, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Course } from "../course/course.component";

@Component({
  selector: "app-students",
  templateUrl: "./students.component.html"
})
export class StudentsComponent implements OnInit {
  public students: Student[];
  public courses: Course[];
  public newStudent: Student = {
    name: "",
    english: "",
    math: "",
    science: "",
    socialStudies: ""
  };

  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) {}

  async ngOnInit() {
    this.students = await this.http
      .get<Student[]>(this.baseUrl + "student")
      .toPromise();

    // use this a model to query a category.
    this.courses = await this.http
      .get<Course[]>(this.baseUrl + 'course/category/?category=english').toPromise();
  }

  async save() {
    await this.http
      .post<Student[]>(this.baseUrl + "student", this.newStudent)
      .toPromise();
    this.students = await this.http
      .get<Student[]>(this.baseUrl + "student")
      .toPromise();
  }
}

interface Student {
  name: string;
  english: string;
  math: string;
  science: string;
  socialStudies: string;
}
