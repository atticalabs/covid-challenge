import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HigienePersonalPage } from './higiene-personal.page';

const routes: Routes = [
  {
    path: '',
    component: HigienePersonalPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HigienePersonalPageRoutingModule {}
