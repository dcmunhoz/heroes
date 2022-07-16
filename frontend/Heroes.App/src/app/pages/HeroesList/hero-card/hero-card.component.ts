import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-hero-card',
  templateUrl: './hero-card.component.html',
  styleUrls: ['./hero-card.component.scss']
})
export class HeroCardComponent implements OnInit {

  @Input() hero: any = {};

  constructor(
    private _router: Router    
  ) { }

  ngOnInit(): void {
  }

  public showHero(): void{
    this._router.navigate(['hero', this.hero.id]);
  }

}
