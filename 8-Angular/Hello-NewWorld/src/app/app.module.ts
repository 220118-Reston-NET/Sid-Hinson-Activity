import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PokemonListComponent } from './pokemon-list/pokemon-list.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PokeProfileComponent } from './poke-profile/poke-profile.component';
import { RouterModule } from '@angular/router';
import { NotFoundComponent } from './not-found/not-found.component';
import { StarComponent } from './star/star.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AddPokeComponent } from './add-poke/add-poke.component';


@NgModule({
  declarations: [
    AppComponent,
    PokemonListComponent,
    NavBarComponent,
    PokeProfileComponent,
    NotFoundComponent,
    StarComponent,
    AddPokeComponent
    

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {path: "listofPoke", component: PokemonListComponent},
      {path: "profile/:pokename", component: PokeProfileComponent},
      {path: "pokemon", component: AddPokeComponent},
      {path: "", component: PokeProfileComponent}, //Default Endpoint
      {path: "**", component:NotFoundComponent }, //WildcardEndpoint
    ]),
    ReactiveFormsModule,
    FontAwesomeModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
