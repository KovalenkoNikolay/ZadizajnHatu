import { TestBed } from '@angular/core/testing';

import { DesignstudioService } from './designstudio.service';

describe('DesignstudioService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DesignstudioService = TestBed.get(DesignstudioService);
    expect(service).toBeTruthy();
  });
});
