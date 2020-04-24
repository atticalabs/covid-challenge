import { Component, OnInit } from '@angular/core';

import { Goal } from '../goal.model';

@Component({
  selector: 'app-goal-list',
  templateUrl: './goal-list.component.html',
  styleUrls: ['./goal-list.component.scss'],
})
export class GoalListComponent implements OnInit {

  goals: Goal[] = [
    new Goal('1', 'Lavarse las manos', 'Lavarse las manos cada dos horas', 
    'https://w7.pngwing.com/pngs/212/551/png-transparent-person-washing-hands-art-hand-washing-wash-your-face-text-photography-hand.png', new Date().toISOString())
  ];

  constructor() { }

  ngOnInit() {  }

  
}
