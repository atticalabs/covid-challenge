import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { LaCasaPageRoutingModule } from './la-casa-routing.module';

import { LaCasaPage } from './la-casa.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    LaCasaPageRoutingModule
  ],
  declarations: [LaCasaPage]
})
export class LaCasaPageModule {}
