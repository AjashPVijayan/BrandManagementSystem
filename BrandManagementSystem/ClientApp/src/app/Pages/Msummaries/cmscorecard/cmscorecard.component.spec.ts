import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CMScorecardComponent } from './cmscorecard.component';

describe('CMScorecardComponent', () => {
  let component: CMScorecardComponent;
  let fixture: ComponentFixture<CMScorecardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CMScorecardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CMScorecardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
