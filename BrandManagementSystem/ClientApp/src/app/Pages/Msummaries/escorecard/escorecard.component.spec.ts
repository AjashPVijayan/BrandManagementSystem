import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EscorecardComponent } from './escorecard.component';

describe('EscorecardComponent', () => {
  let component: EscorecardComponent;
  let fixture: ComponentFixture<EscorecardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EscorecardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EscorecardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
