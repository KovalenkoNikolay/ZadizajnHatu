import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DesignStudioDetailsComponent } from './design-studio-details.component';

describe('DesignStudioDetailsComponent', () => {
  let component: DesignStudioDetailsComponent;
  let fixture: ComponentFixture<DesignStudioDetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DesignStudioDetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DesignStudioDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
