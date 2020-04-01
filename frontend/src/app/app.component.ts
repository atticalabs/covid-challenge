import { Component, OnInit } from '@angular/core';

import { Platform } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss']
})
export class AppComponent implements OnInit {
  public selectedIndex = 0;
  public appPages = [
    {
      title: 'Salud personal',
      url: '/folder/Salud-personal',
      icon: 'medkit'
    },
    {
      title: 'La casa',
      url: '/folder/La-casa',
      icon: 'home'
    },
    {
      title: 'Vida social',
      url: '/folder/Vida-social',
      icon: 'people'
    },
    {
      title: 'Trabajo',
      url: '/folder/Trabajo',
      icon: 'briefcase'
    },
    {
      title: 'Economía',
      url: '/folder/Economia',
      icon: 'cash'
    },
    {
      title: 'Mis logros',
      url: '/folder/Mis-logros',
      icon: 'checkmark'
    },
    {
      title: 'El ranking',
      url: '/folder/Ranking',
      icon: 'podium'
    }
  ];
  public labels = ['Family', 'Friends', 'Notes', 'Work', 'Travel', 'Reminders'];

  constructor(
    private platform: Platform,
    private splashScreen: SplashScreen,
    private statusBar: StatusBar
  ) {
    this.initializeApp();
  }

  initializeApp() {
    this.platform.ready().then(() => {
      this.statusBar.styleDefault();
      this.splashScreen.hide();
    });
  }

  ngOnInit() {
    const path = window.location.pathname.split('folder/')[1];
    if (path !== undefined) {
      this.selectedIndex = this.appPages.findIndex(page => page.title.toLowerCase() === path.toLowerCase());
    }
  }
}
