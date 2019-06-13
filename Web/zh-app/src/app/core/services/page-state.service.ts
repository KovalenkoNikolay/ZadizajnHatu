import { Injectable } from '@angular/core';

@Injectable()

export class PageStateService {

public currentPage : string;

  constructor() { }

  getCurrentPageName() : string {
    return this.currentPage;
  }

  setCurrentPageName(pageName : string) {
    this.currentPage = pageName;
  }

}
