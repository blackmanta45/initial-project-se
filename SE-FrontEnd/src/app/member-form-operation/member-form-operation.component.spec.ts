import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MemberFormOperationComponent } from './member-form-operation.component';

describe('MemberFormOperationComponent', () => {
  let component: MemberFormOperationComponent;
  let fixture: ComponentFixture<MemberFormOperationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MemberFormOperationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MemberFormOperationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
