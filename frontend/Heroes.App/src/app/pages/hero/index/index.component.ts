import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Hero } from '../model/Hero';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class HeroIndexComponent implements OnInit {

  public hero: Hero = new Hero();

  constructor(
    private _router: ActivatedRoute
  ) { 
    
  }

  ngOnInit(): void {
    this._router.params.subscribe(p => {
      this.hero.id = p['id'];
    })
  }

}
