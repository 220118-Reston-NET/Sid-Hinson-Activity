
//=====================================Variable============================
console.log(" ======= Variables Be Here ========");

//String Variables
let s1 = "hello";
// s1 = 10;
console.log(`s1 is typeof ${ typeof s1}`)

//Any -- Default type of declared variable if no type explicitly given
let a1;
a1 = "string";
a1 = 10;
a1 = null;
a1 = true;

//Null or Undefined
let nu1;
let null1 = null;

//Enforcement of type
let num1 : number;

//Union Type in TypeScript
let t1:number | string;
t1 = 10;
t1 = "hello";

//Arrays
//Declare like enforcement
let arry1: number[];
arry1 = [23,5,45,6];
arry1.push(500);
//Different than arrays in C#, more like LIST COLLECTIONS
let arry2: (number | string)[];
//Can even hold Array of array
let arry3: string[] | number;
arry3 = ["Car" , "fox"]
arry3 = 10;

//Tuple - array but fixed position of datatypes
let tul: [number, string, number, string, boolean];
tul = [10, "Car", 10, "Boat", true]
//push will allow you to enter a value that would normally break it
//This kinda does break it though - so careful
tul.push(70000);


//Enums - make code look more pleasant, similar to what happened in c# with Menus Stephen made
//In JS it is done through a process with functions
enum Engine
{
    Off,
    Idle,
    Accelerate
}
let enginestate = Engine.Accelerate;
if(enginestate == Engine.Accelerate)
{
    console.log("This thing is going to crash!!!!!!");
}

//=====================FUNCTIONS BE HERE===========================//
//Similar to JS but STRICT TYPING changes how it works

function myFunc(params1:string) {
    
    console.log(`${params1}`);
}
myFunc("YEEEEEOCCCHHH");

//Returns like this
//If not return type, its a VOID return...like C#
function thatFunch(params2:string) : string {
    return params2.concat("Now there are TWO OF THEM!!!!");
}

//======================Classes and oBjects BE HERE======================//
class Dog {
        color:string;
        name:string;
        breed:string;
    constructor(color:string, name:string, breed:string) {
        this.color = color;
        this.name = name;
        this.breed = breed;
    }

    //Method Overloading is performed with If statement [Not shown]
    giveColor()
    {
        console.log("The dog's color is" + this.color);
    }

}
//=======Interface Demo
//Merely a Scaffold
//Notice the different between c# where we declare the type
interface Animal
{
    numoflegs:number;
    isDead: boolean;
    speed?: number;
    //THE ? make it optional, can add to methods, params, etc

    speak:() => string; // function returns a string

}

//Sets interface into variable
let ani:Animal

ani = {
    numoflegs: 18,
    isDead: true,
    speed: 200,

    speak()
    {
        return "SNARF";
    }
}






