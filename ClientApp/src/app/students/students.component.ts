import { Component, Inject, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "app-students",
  templateUrl: "./students.component.html"
})
export class StudentsComponent implements OnInit {
  public students: Student[];
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
