import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PokeApi } from '../models/pokeApi.model';
import { SpriteApi } from '../models/spriteApi.model';
import { PokeService } from '../Services/poke.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-poke-profile',
  templateUrl: './poke-profile.component.html',
  styleUrls: ['./poke-profile.component.css']
})
export class PokeProfileComponent implements OnInit {
  pokeName:string | null = "No Pokemon Selected";
  pokemon:PokeApi;

  constructor(private router:ActivatedRoute, private pokeServ:PokeService) 
  {
    this.pokemon = {sprites: {
      back_default:"",
      front_default:"",
    } };
  }

  //Lifecycle hooks in Angular
  ngOnInit(): void {
    //certain functionality before things happen
    this.pokeName = this.router.snapshot.paramMap.get("pokename");
    this.pokeServ.getPokeByName(this.pokeName).subscribe(result => {
      this.pokemon = result;
    });
  }

  get PokeSprite() : SpriteApi
  {
    return this.pokemon.sprites;
  }

}
