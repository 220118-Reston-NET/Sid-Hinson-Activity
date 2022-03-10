import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PokemonListComponent } from './pokemon-list/pokemon-list.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FormsModule } from '@angular/forms';
import { PokeProfileComponent } from './poke-profile/poke-profile.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    PokemonListComponent,
    NavBarComponent,
    PokeProfileComponent,

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([{path: "listofPoke", component: PokemonListComponent},{path: "profile", component: PokeProfileComponent}, {path: "", component:PokemonListComponent}])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
