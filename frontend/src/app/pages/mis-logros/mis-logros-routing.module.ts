import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MisLogrosPage } from './mis-logros.page';

const routes: Routes = [
  {
    path: '',
    component: MisLogrosPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class MisLogrosPageRoutingModule {}
