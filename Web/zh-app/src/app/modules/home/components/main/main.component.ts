import { Component, OnInit } from '@angular/core';
import { DesignStudio } from 'src/app/shared/models/designstudio';
import { DesignstudioService } from 'src/app/core/services/designstudio.service';
import { PageStateService } from 'src/app/core/services/page-state.service';

@Component({
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {

  public designStudios : DesignStudio[]=[];

  constructor(private _designstudioService: DesignstudioService, pageStateService : PageStateService) { 
    pageStateService.setCurrentPageName("designstudiolist");
  }

  ngOnInit() {
    this._designstudioService.getDesignStudios().subscribe(data => 
      {
        this.designStudios = data;
      } , error => console.error(error));
  }
}
 