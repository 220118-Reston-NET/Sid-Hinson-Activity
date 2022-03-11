import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PokemonListComponent } from './pokemon-list/pokemon-list.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FormsModule } from '@angular/forms';
import { PokeProfileComponent } from './poke-profile/poke-profile.component';
import { RouterModule } from '@angular/router';
import { NotFoundComponent } from './not-found/not-found.component';


@NgModule({
  declarations: [
    AppComponent,
    PokemonListComponent,
    NavBarComponent,
    PokeProfileComponent,
    NotFoundComponent,
  

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {path: "listofPoke", component: PokemonListComponent},
      {path: "profile/:pokename", component: PokeProfileComponent},
      {path: "", component: PokeProfileComponent}, //Default Endpoint
      {path: "**", component:NotFoundComponent }, //WildcardEndpoint
      
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
