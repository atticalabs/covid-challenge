import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { VidaSocialPage } from './vida-social.page';

const routes: Routes = [
  {
    path: '',
    component: VidaSocialPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class VidaSocialPageRoutingModule {}
