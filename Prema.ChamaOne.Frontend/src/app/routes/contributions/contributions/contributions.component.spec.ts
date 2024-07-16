import { waitForAsync, ComponentFixture, TestBed } from '@angular/core/testing';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from '@shared/shared.module';

import { ContributionsContributionsComponent } from './contributions.component';

describe('ContributionsContributionsComponent', () => {
  let component: ContributionsContributionsComponent;
  let fixture: ComponentFixture<ContributionsContributionsComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ContributionsContributionsComponent],
      imports: [NoopAnimationsModule, SharedModule]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ContributionsContributionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
