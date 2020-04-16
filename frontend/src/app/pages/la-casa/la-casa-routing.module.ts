import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LaCasaPage } from './la-casa.page';

const routes: Routes = [
  {
    path: '',
    component: LaCasaPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class LaCasaPageRoutingModule {}
