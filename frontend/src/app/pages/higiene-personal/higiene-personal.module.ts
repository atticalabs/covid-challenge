import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { HigienePersonalPageRoutingModule } from './higiene-personal-routing.module';

import { HigienePersonalPage } from './higiene-personal.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    HigienePersonalPageRoutingModule
  ],
  declarations: [HigienePersonalPage]
})
export class HigienePersonalPageModule {}
