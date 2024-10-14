import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomePagComponent } from './home-pag.component';

describe('HomePagComponent', () => {
  let component: HomePagComponent;
  let fixture: ComponentFixture<HomePagComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HomePagComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomePagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
