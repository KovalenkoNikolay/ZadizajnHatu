import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-api',
  templateUrl: './api.component.html',
  styleUrls: ['./api.component.sass']
})
export class ApiComponent implements OnInit {
  helloWorld: string = "hello";
  resp: any;
  constructor(private http: HttpClient) {
    
  }

  getHelloWorld(){
    this.http.get('https://localhost:44378/api/user')
.subscribe((response)=> {
this.resp = response;
this.helloWorld = this.resp.hello;
})
  }
  
  ngOnInit() {
  }

}
