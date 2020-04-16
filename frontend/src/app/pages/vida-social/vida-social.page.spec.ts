import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { VidaSocialPage } from './vida-social.page';

describe('VidaSocialPage', () => {
  let component: VidaSocialPage;
  let fixture: ComponentFixture<VidaSocialPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VidaSocialPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(VidaSocialPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
