import { waitForAsync, ComponentFixture, TestBed } from '@angular/core/testing';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from '@shared/shared.module';

import { LoansLoansComponent } from './loans.component';

describe('LoansLoansComponent', () => {
  let component: LoansLoansComponent;
  let fixture: ComponentFixture<LoansLoansComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [LoansLoansComponent],
      imports: [NoopAnimationsModule, SharedModule]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoansLoansComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
