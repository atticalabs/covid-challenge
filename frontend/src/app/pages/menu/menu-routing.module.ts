import { HomePageModule } from '../home/home.module';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MenuPage } from './menu.page';

const routes: Routes = [
  {
    path: '',
    redirectTo:'/menu/main',
    pathMatch: 'full',
  },
  {
    path: '',
    component: MenuPage,
    children: [
      {
        path: 'login',
        loadChildren: () => import('../login/login.module').then( m => m.LoginPageModule)
      },
      {
        path: 'home',
        loadChildren: () => import('../home/home.module').then( m => m.HomePageModule)
      },
      {
        path: 'main',
        loadChildren: () => import('../main/main.module').then( m => m.MainPageModule)
      },
      {
        path: 'mis-logros',
        loadChildren: () => import('../mis-logros/mis-logros.module').then( m => m.MisLogrosPageModule)
      },
      {
        path: 'ranking',
        loadChildren: () => import('../ranking/ranking.module').then( m => m.RankingPageModule)
      },
      {
        path: 'higiene-personal',
        loadChildren: () => import('../higiene-personal/higiene-personal.module').then( m => m.HigienePersonalPageModule)
      },
      {
        path: 'vida-social',
        loadChildren: () => import('../vida-social/vida-social.module').then( m => m.VidaSocialPageModule)
      },
      {
        path: 'trabajo',
        loadChildren: () => import('../trabajo/trabajo.module').then( m => m.TrabajoPageModule)
      },
      {
        path: 'la-casa',
        loadChildren: () => import('../la-casa/la-casa.module').then( m => m.LaCasaPageModule)
      },
      {
        path: 'economia',
        loadChildren: () => import('../economia/economia.module').then( m => m.EconomiaPageModule)
      },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class MenuPageRoutingModule {}
