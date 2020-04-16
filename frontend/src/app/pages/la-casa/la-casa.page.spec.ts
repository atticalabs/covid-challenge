import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { LaCasaPage } from './la-casa.page';

describe('LaCasaPage', () => {
  let component: LaCasaPage;
  let fixture: ComponentFixture<LaCasaPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LaCasaPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(LaCasaPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
