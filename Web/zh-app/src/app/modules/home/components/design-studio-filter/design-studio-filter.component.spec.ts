import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DesignStudioFilterComponent } from './design-studio-filter.component';

describe('DesignStudioFilterComponent', () => {
  let component: DesignStudioFilterComponent;
  let fixture: ComponentFixture<DesignStudioFilterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DesignStudioFilterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DesignStudioFilterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
