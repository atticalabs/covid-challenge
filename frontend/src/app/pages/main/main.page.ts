import { Component, OnInit } from '@angular/core';
import { GoalsComponent } from '../../goals/goals.component';
import { GoalListComponent } from '../../goals/goal-list/goal-list.component';

@Component({
  selector: 'app-main',
  templateUrl: './main.page.html',
  styleUrls: ['./main.page.scss'],
})
export class MainPage implements OnInit {

  date = new Date().toISOString();
  constructor() { }

  ngOnInit() {

  }

}
