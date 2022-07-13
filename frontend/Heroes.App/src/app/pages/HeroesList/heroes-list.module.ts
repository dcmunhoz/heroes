import { NgModule } from "@angular/core";
import { HeroesListRouter } from "./heroes-list-routing.module";
import { HeroesListIndexComponent } from "./index/index.component";

@NgModule({
    declarations: [ 
        HeroesListIndexComponent
     ],
    imports: [HeroesListRouter],
    exports: []
})
export class HeroesListModule{}