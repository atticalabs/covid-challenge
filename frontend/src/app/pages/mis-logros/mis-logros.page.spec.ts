import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { MisLogrosPage } from './mis-logros.page';

describe('MisLogrosPage', () => {
  let component: MisLogrosPage;
  let fixture: ComponentFixture<MisLogrosPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MisLogrosPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(MisLogrosPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
