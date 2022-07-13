import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { HeroesListIndexComponent } from "./index/index.component";

const routes: Routes = [{
    path: '',
    component: HeroesListIndexComponent
}]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class HeroesListRouter{}