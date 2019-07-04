import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DesignstudioService } from '../../../../core/services/designstudio.service';
import { DesignStudioSharedDataService } from 'src/app/core/services/design-studio-shared-data.service';
import { DesignStudio } from 'src/app/shared/models/designstudio';

@Component({
  selector: '[id=design-studio-details]',
  templateUrl: './design-studio-details.component.html',
  styleUrls: ['./design-studio-details.component.scss']
})
export class DesignStudioDetailsComponent implements OnInit {

  public designStudio : DesignStudioDetails;
  constructor(private designstudioService : DesignstudioService, private route : ActivatedRoute, private dsSharedService : DesignStudioSharedDataService) {  }

  ngOnInit() {
     this.dsSharedService.getCurrentDsId()
     .subscribe(dsId => {
      this.designstudioService.getDesignStudioById(dsId).subscribe(data => 
        {
          this.designStudio = data;
        } , error => console.error(this.dsSharedService.getCurrentDsId()));;
     } , error => console.error(this.dsSharedService.getCurrentDsId()));
  }
}
