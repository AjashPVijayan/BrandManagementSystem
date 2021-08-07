import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PointintimeComponent } from './pointintime.component';

describe('PointintimeComponent', () => {
  let component: PointintimeComponent;
  let fixture: ComponentFixture<PointintimeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PointintimeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PointintimeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
