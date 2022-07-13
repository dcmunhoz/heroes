import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeroesListModule } from './pages/HeroesList/heroes-list.module';
import { LoginModule } from './pages/Login/login.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    LoginModule,
    HeroesListModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
