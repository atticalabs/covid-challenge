import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { MisLogrosPageRoutingModule } from './mis-logros-routing.module';

import { MisLogrosPage } from './mis-logros.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    MisLogrosPageRoutingModule
  ],
  declarations: [MisLogrosPage]
})
export class MisLogrosPageModule {}
