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
    filteredName:string = "";
    listofPokemon: Pokemon[];
    filteredListOfPoke:Pokemon[] = [];
    isRatingVisible:boolean = false;

    //PokeService complete with Service Method that returns an Observable 
    constructor(private pokeServ:PokeService) {
        this.listofPokemon = [];
        this.filteredListOfPoke = [];
        this.pokeServ.getAllPokemon().subscribe(result =>{result.forEach(poke => poke.rating = this.getRandomInt(5)); this.listofPokemon = result; this.filteredListOfPoke = result});
    }

    getRandomInt(max:number){
        return Math.floor(Math.random()*max)
    }

    changeTitle()
    {
        this.title = "DragonballZ is better than Pokemon";
        this.src1 = "https://upload.wikimedia.org/wikipedia/commons/c/ca/Pomeranian.JPG";
        
    }

    changeVisible()
    {
        this.isVisible = !this.isVisible;
    }

    // public get FilteredName():string
    // {
    //     return this.filteredName; 
    // }

    public set FilteredName(s1:string)
    {
        this.filteredName = s1;
        this.filteredListOfPoke = this.filteredName ? this.SearchFilter(this.filteredName) : this.listofPokemon;
    }

    //filters array of Pokemon based on user input
    SearchFilter(filter:string):Pokemon[]
    {
        filter = filter.toLowerCase();
        let templistpoke:Pokemon[];
        //The -1 filters out garbage that does not link with the filter, other it will return 1 - index of 1 will equal victory
        //This will be useful for broad searches, making it 1 would require EXACTNESS
        templistpoke = this.listofPokemon.filter((pokemon:Pokemon) => pokemon.name.toLowerCase().indexOf(filter) != -1)
        return templistpoke;
    }

    starEventWasTriggered(num1:number)
    {
        this.isRatingVisible = !this.isRatingVisible; 
    }
}