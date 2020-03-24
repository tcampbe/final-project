import { Component, Inject, OnInit, ViewChild } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { MatPaginator } from "@angular/material/paginator";
import { MatSort, MatSortModule } from "@angular/material/sort";
import { MatTableDataSource, MatTableModule } from "@angular/material/table";

@Component({
  selector: "app-course",
  templateUrl: "./course.component.html",
  styleUrls: ["./course.component.css"]
})
export class CourseComponent implements OnInit {
  public courses: Course[];
  displayedColumns: string[] = ["type", "name", "category", "webSite"];
  dataSource: MatTableDataSource<Course>;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  //public newCourse: Course = { Type: '', Name: '', Category: '', WebSite: ''};
  //   Resource: , PreSchool: , Elementary: , MiddleSchool: , HighSchool: , HigherEducation: ,
  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) {}

  async ngOnInit() {
    this.courses = await this.http
      .get<Course[]>(this.baseUrl + "course")
      .toPromise();
    this.dataSource = new MatTableDataSource(this.courses);
    this.dataSource.sort = this.sort;
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLocaleLowerCase();
  }

  //async getByCategory(category) {
  //  this.courses = await this.http.getByCategory<categoryCourses>(this.baseUrl + category)
  //}

  //async save() {
  //  await this.http.post<Course[]>(this.baseUrl + 'course', this.newCourse).toPromise();
  //  this.newCourse = { Type: '', Name: '', Category: '', WebSite: '' };
  //  //   Resource: , PreSchool: , Elementary: , MiddleSchool: , HighSchool: , HigherEducation: ,
  //  this.courses = await this.http.get<Course[]>(this.baseUrl + 'course').toPromise();
  //}
}

export interface Course {
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
