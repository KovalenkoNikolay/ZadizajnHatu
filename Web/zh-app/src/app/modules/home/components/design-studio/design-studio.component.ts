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

  private designStudio : DesignStudioDetails;
  constructor(public pageStateService : PageStateService, public designstudioService : DesignstudioService, private route : ActivatedRoute) { 
    this.pageStateService.setCurrentPageName("designstudio");
  }

  ngOnInit() {
    

    this.designstudioService.getDesignStudioById(this.route.snapshot.paramMap.get('id')).subscribe(data => 
      {
        this.designStudio = data;
      } , error => console.error(error));;
  }
}
