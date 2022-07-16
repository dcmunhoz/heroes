import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HeroIndexComponent } from './index/index.component';

const routes: Routes = [
  {
    path: '',
    component: HeroIndexComponent
  },{
    path: ':id',
    component: HeroIndexComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HeroRoutingModule { }
