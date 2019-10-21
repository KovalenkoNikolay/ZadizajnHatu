import { Injectable } from '@angular/core';
import { DesignStudioSearchFilter } from 'src/app/shared/models/design-studio-search-filter';
import { Observable, of, BehaviorSubject } from 'rxjs';

@Injectable()

export class DesignStudioSharedDataService {

  public dsId : string; 
  private dsSearchFilter: BehaviorSubject<DesignStudioSearchFilter> = new BehaviorSubject<DesignStudioSearchFilter>(null)

  constructor() { }

  setCurrentDsId(id : string) {
    this.dsId = id;
  }

  getCurrentDsId() : Observable<string> {
    return of (this.dsId);
  }

  addDesignStudioSearchFilter(searchFilter : DesignStudioSearchFilter){
    this.dsSearchFilter.next(searchFilter)
  }

  getDesignStudioSearchFilter() : Observable<DesignStudioSearchFilter>{
    let search = this.dsSearchFilter.asObservable();

    return search;
  }
}
