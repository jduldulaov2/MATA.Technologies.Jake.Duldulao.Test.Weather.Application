import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecentForecastComponent } from './recent-forecast.component';

describe('RecentForecastComponent', () => {
  let component: RecentForecastComponent;
  let fixture: ComponentFixture<RecentForecastComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecentForecastComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecentForecastComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
