import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.page.html',
  styleUrls: ['./menu.page.scss'],
})
export class MenuPage implements OnInit {

  //TODO: Main y La casa tienen el mismo icono, cambiar alguno
  pages = [
    {
      title: 'Login test',
      url: '/menu/login',
      icon: 'log-in-outline'
    },
    {
      title: 'Main',
      url: '/menu/main',
      icon: 'home'
    },
    {
      title: 'Mis logros',
      url: '/menu/mis-logros',
      icon: 'checkmark'
    },
    {
      title: 'Ranking',
      url: '/menu/ranking',
      icon: 'podium'
    },
    {
      title: 'Categorías',
      children: [
        {
          title: 'Higiene personal',
          url: '/menu/higiene-personal',
          icon: 'medkit'
        },
        {
          title: 'Vida social',
          url: '/menu/vida-social',
          icon: 'people'
        },
        {
          title: 'Trabajo',
          url: '/menu/trabajo',
          icon: 'briefcase'
        },
        {
          title: 'La casa',
          url: '/menu/la-casa',
          icon: 'home'
        },
        {
          title: 'Economía',
          url: '/menu/economia',
          icon: 'cash'
        },
      ]
    }
  ]
  constructor() { }

  ngOnInit() {
  }

}
