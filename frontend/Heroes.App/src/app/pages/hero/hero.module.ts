import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HeroRoutingModule } from './hero-routing.module';
import { HeroIndexComponent } from './index/index.component';
import { HeroDetailsComponent } from './hero-details/hero-details.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    HeroIndexComponent,
    HeroDetailsComponent
  ],
  imports: [
    CommonModule,
    HeroRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class HeroModule { }
