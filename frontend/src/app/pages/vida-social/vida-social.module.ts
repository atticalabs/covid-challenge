import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { VidaSocialPageRoutingModule } from './vida-social-routing.module';

import { VidaSocialPage } from './vida-social.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    VidaSocialPageRoutingModule
  ],
  declarations: [VidaSocialPage]
})
export class VidaSocialPageModule {}
