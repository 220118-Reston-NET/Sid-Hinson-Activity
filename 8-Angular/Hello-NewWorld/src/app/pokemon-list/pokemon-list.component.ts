import { Component } from "@angular/core";
import { Pokemon } from "../models/pokemon.model";
import { PokeService } from "../Services/poke.service";

//Decorator
@Component({
    //Selector instantiates the directive and displays the specific component
    //Template points to HTML
    //styleUrl points to the CSS for style
    selector:'app-pokemon-list',
    templateUrl: './pokemon-list.component.html',
    styleUrls: ['./pokemon-list.component.css']
})

//Export makes this file be available to external Typescript
export class PokemonListComponent {
    title:string = "List of Pokemon";
    src1:string = "https://upload.wikimedia.org/wikipedia/commons/e/e1/Apocalypse_vasnetsov.jpg";
    isVisible:boolean = true;

    listofPokemon: Pokemon[];

    constructor(private pokeServ:PokeService) {
        this.listofPokemon = [];

    }
    changeTitle()
    {
        this.title = "I was never a fan of Pokemon";
        this.src1 = "https://upload.wikimedia.org/wikipedia/commons/c/ca/Pomeranian.JPG";
        this.listofPokemon.push({base_experience:64, id:1, name:'bulbosaur', sprites: {front_default: 'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/25.png'}})
    }

    changeVisible()
    {
        this.isVisible = !this.isVisible;
    }


    // this.listofPokemon[{
    //     id:132,
    //     base_experience: 101,
    //     name: 'ditto',
    //     sprites: {
    //         front_default: 'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/132.png'
    //     }

    // },
    // {
    //     id:125,
    //     base_experience: 112,
    //     name: 'pikachu',
    //     sprites: {
    //         front_default: 'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/25.png'
    //     }
    // }];

}