import { Component, Input, OnInit } from "@angular/core";
import { Hero } from "../model/Hero";

@Component({
    selector: 'app-hero-detail',
    templateUrl: './hero-details.component.html',
    styleUrls: ['./hero-details.component.scss']
})
export class HeroDetailsComponent implements OnInit {
    
    @Input() hero: Hero = new Hero();
    
    ngOnInit(): void {
        if(this.hero.id){
            this.hero.name = "Atrox";
            this.hero.power = 10;
            this.hero.defense = 30;
            this.hero.description = "Roubado";
        }
    }

}