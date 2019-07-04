import { Component, OnInit } from '@angular/core';
import { PageStateService } from '../../../../core/services/page-state.service';
import { DesignstudioService } from '../../../../core/services/designstudio.service';
import { ActivatedRoute } from '@angular/router';
import { DesignStudioSharedDataService } from 'src/app/core/services/design-studio-shared-data.service';
import { DesignStudioPortfolio } from 'src/app/shared/models/design-studio-portfolio';

@Component({
  selector: 'app-design-studio',
  templateUrl: './design-studio.component.html',
  styleUrls: ['./design-studio.component.scss']
})
export class DesignStudioComponent implements OnInit {

  public dsPorfolios : DesignStudioPortfolio[];

  constructor(public pageStateService : PageStateService, public designstudioService : DesignstudioService, private route : ActivatedRoute, private dsSharedService : DesignStudioSharedDataService) { 
    this.pageStateService.setCurrentPageName("designstudio");
  }

  ngOnInit() {
    let currentDsId = this.route.snapshot.paramMap.get('id')
    this.dsSharedService.setCurrentDsId(currentDsId);

    if (currentDsId != null)
      {
        this.designstudioService.getPortfoliosByDesignStudioId(currentDsId).subscribe(data => 
          {
            this.dsPorfolios = data;
          });
      }
  }
}
