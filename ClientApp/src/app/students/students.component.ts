import { Component, Inject, OnInit, ViewChild } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { MatPaginator } from "@angular/material/paginator";
import { MatSort, MatSortModule } from "@angular/material/sort";
import { MatTableDataSource, MatTableModule } from "@angular/material/table";
import { Course } from "../course/course.component";

@Component({
  selector: "app-students",
  templateUrl: "./students.component.html",
})
export class StudentsComponent implements OnInit {
  public students: Student[];
  public courses: Course[];
  dataSource: MatTableDataSource<Student>;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  public newStudent: Student = {
    name: "",
    english: "",
    math: "",
    science: "",
    socialStudies: "",
  };

  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) {}

  async ngOnInit() {
    this.students = await this.http
      .get<Student[]>(this.baseUrl + "student")
      .toPromise();
    this.dataSource = new MatTableDataSource(this.students);
    this.dataSource.sort = this.sort;

  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLocaleLowerCase();
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
