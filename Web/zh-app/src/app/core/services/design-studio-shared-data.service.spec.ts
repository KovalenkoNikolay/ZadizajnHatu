import { TestBed } from '@angular/core/testing';

import { DesignStudioSharedDataService } from './design-studio-shared-data.service';

describe('DesignStudioSharedDataService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DesignStudioSharedDataService = TestBed.get(DesignStudioSharedDataService);
    expect(service).toBeTruthy();
  });
});
