import { Injectable } from '@angular/core';
import { Subject, Observable, of } from 'rxjs';
import { DesignStudio } from 'src/app/shared/models/designstudio';

@Injectable()

export class DesignStudioSharedDataService {

  public dsId : string; 

  constructor() { }

  setCurrentDsId(id : string) {
    this.dsId = id;
  }

  getCurrentDsId() : Observable<string> {
    return of (this.dsId);
  }
}
