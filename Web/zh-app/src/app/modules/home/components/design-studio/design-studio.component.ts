import { Component, OnInit } from '@angular/core';
import { PageStateService } from '../../../../core/services/page-state.service';
import { DesignstudioService } from '../../../../core/services/designstudio.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-design-studio',
  templateUrl: './design-studio.component.html',
  styleUrls: ['./design-studio.component.scss']
})
export class DesignStudioComponent implements OnInit {

  constructor(public pageStateService : PageStateService, public designstudioService : DesignstudioService, private route : ActivatedRoute) { }

  ngOnInit() {
    let designStudioId = this.route.snapshot.paramMap.get('id');

    this.pageStateService.setCurrentPageName("designstudio");
    var designStudio = this.designstudioService.getDesignStudioById(designStudioId);
  }
}
