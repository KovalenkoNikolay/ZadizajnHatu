import { Component, OnInit } from '@angular/core';
import { DesignStudio } from 'src/app/shared/models/designstudio';
import { DesignstudioService } from 'src/app/core/services/designstudio.service';

@Component({
  selector: '[id=main]',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {

  public designStudios : DesignStudio[]=[];

  constructor(private _designstudioService: DesignstudioService) { 
  }

  ngOnInit() {
    this._designstudioService.getDesignStudio().subscribe(data => 
      {
        this.designStudios = data;
      } , error => console.error(error));
  }
}
 