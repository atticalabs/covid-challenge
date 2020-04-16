import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { HigienePersonalPage } from './higiene-personal.page';

describe('HigienePersonalPage', () => {
  let component: HigienePersonalPage;
  let fixture: ComponentFixture<HigienePersonalPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HigienePersonalPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(HigienePersonalPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
