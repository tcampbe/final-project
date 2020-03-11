import { Component, Inject, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "app-home-scholar",
  templateUrl: "./home-scholar.component.html",
  styleUrls: ["./home-scholar.component.css"]
})
export class HomeScholarComponent implements OnInit {
  public homeScholars: HomeScholar[];
  public newHomeScholar: HomeScholar = {
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
    this.homeScholars = await this.http
      .get<HomeScholar[]>(this.baseUrl + "homeScholar")
      .toPromise();
  }

  async save() {
    await this.http
      .post<HomeScholar[]>(this.baseUrl + "homeScholar", this.newHomeScholar)
      .toPromise();
    this.homeScholars = await this.http
      .get<HomeScholar[]>(this.baseUrl + "homeScholar")
      .toPromise();
  }
}

interface HomeScholar {
  name: string;
  english: string;
  math: string;
  science: string;
  socialStudies: string;
}
