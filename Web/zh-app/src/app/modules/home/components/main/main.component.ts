import { Component, OnInit } from '@angular/core';
import { DesignStudio } from 'src/app/shared/models/designstudio';
import { DesignStudioSearchFilter } from 'src/app/shared/models/design-studio-search-filter';
import { DesignstudioService } from 'src/app/core/services/designstudio.service';
import { PageStateService } from 'src/app/core/services/page-state.service';
import { DesignStudioSharedDataService } from 'src/app/core/services/design-studio-shared-data.service';

@Component({
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {

  public designStudios : DesignStudio[]=[];

  constructor(private _designstudioService: DesignstudioService, pageStateService : PageStateService, private designStudioSharedDataService : DesignStudioSharedDataService) { 
    pageStateService.setCurrentPageName("designstudiolist");
  }

  ngOnInit() {
     this.designStudioSharedDataService.getDesignStudioSearchFilter().subscribe(dsSearchFilter => {
         let searchFilter : DesignStudioSearchFilter = dsSearchFilter || new DesignStudioSearchFilter();
         searchFilter.name = "hello"

         this._designstudioService.getDesignStudios(searchFilter.fromAmount, searchFilter.toAmount, searchFilter.name).subscribe(data => 
          {
            this.designStudios = data;
          } , error => console.error(error));

     } , error => console.error(error));
  }
}
 