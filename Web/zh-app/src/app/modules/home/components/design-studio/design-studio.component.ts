import { Component, OnInit } from '@angular/core';
import { PageStateService } from '../../../../core/services/page-state.service';

@Component({
  selector: 'app-design-studio',
  templateUrl: './design-studio.component.html',
  styleUrls: ['./design-studio.component.scss']
})
export class DesignStudioComponent implements OnInit {

  constructor(public pageStateService : PageStateService) { }

  ngOnInit() {
    this.pageStateService.setCurrentPageName("designstudio");
  }

}
