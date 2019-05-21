import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DesignStudioPreviewComponent } from './design-studio-preview.component';

describe('DesignStudioPreviewComponent', () => {
  let component: DesignStudioPreviewComponent;
  let fixture: ComponentFixture<DesignStudioPreviewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DesignStudioPreviewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DesignStudioPreviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
