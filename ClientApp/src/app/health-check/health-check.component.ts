import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


interface Result {
  checks: Check[];
  totalStatus: string;
  totalResponeTime: number;
}

interface Check {
  name: string;
  status: string;
  responeTime: number;
}

@Component({
  selector: 'app-health-check',
  templateUrl: './health-check.component.html',
  styleUrls: ['./health-check.component.css']
})
export class HealthCheckComponent implements OnInit {
  public result: Result;


  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) {
    //

  }

  ngOnInit() {
    //

    this.http.get<Result>(this.baseUrl + 'hc').subscribe(
      data => {
        this.result = data;
      },
      error => {
        console.error(error);
      }

    );

  }



}
