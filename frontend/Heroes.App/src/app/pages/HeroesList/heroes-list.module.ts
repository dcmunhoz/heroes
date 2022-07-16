import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { HeroesListRouter } from "./heroes-list-routing.module";
import { HeroesListIndexComponent } from "./index/index.component";
import { HeroCardComponent } from './hero-card/hero-card.component';

@NgModule({
    declarations: [ 
        HeroesListIndexComponent, HeroCardComponent
     ],
    imports: [CommonModule, HeroesListRouter],
    exports: []
})
export class HeroesListModule{}