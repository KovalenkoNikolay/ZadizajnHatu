import { Component, OnInit } from '@angular/core';
import { DesignStudioSharedDataService } from 'src/app/core/services/design-studio-shared-data.service';
import { DesignStudioSearchFilter } from 'src/app/shared/models/design-studio-search-filter';

@Component({
  selector: '[id=design-studio-filter]',
  templateUrl: './design-studio-filter.component.html',
  styleUrls: ['./design-studio-filter.component.scss']
})
export class DesignStudioFilterComponent implements OnInit {

  constructor(private designStudioSharedDataService : DesignStudioSharedDataService) { }

  ngOnInit() {
  }

  searchDesignStudios(fromAmount: number, toAmount : number, name : string){
    let searchFilter = new DesignStudioSearchFilter();
    searchFilter.fromAmount = fromAmount;
    searchFilter.toAmount = toAmount;
    searchFilter.name = name;
    this.designStudioSharedDataService.addDesignStudioSearchFilter(searchFilter);
  }
}
