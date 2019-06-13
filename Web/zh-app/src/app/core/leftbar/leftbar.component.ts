import { Component, OnInit } from '@angular/core';
import { PageStateService } from '../services/page-state.service';

@Component({
  providers: [PageStateService],
  selector: '[id=leftbar]',
  templateUrl: './leftbar.component.html',
  styleUrls: ['./leftbar.component.scss']
})
export class LeftbarComponent implements OnInit {
  constructor(public pageStateService :PageStateService) { }

  ngOnInit() {
  }

  public GetPageState() : string {
    return this.pageStateService.getCurrentPageName();
  } 
}
