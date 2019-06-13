import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PageStateService {

  constructor() { }

  getCurrentPageName() : string {
    return "filter"
  }
}
