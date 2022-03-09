//=====================================Variable============================
console.log(" ======= Variables Be Here ========");
//String Variables
let s1 = "hello";
// s1 = 10;
console.log(`s1 is typeof ${typeof s1}`);
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
let num1;
//Union Type in TypeScript
let t1;
t1 = 10;
t1 = "hello";
//Arrays
//Declare like enforcement
let arry1;
arry1 = [23, 5, 45, 6];
arry1.push(500);
//Different than arrays in C#, more like LIST COLLECTIONS
let arry2;
//Can even hold Array of array
let arry3;
arry3 = ["Car", "fox"];
arry3 = 10;
//Tuple - array but fixed position of datatypes
let tul;
tul = [10, "Car", 10, "Boat", true];
//push will allow you to enter a value that would normally break it
//This kinda does break it though - so careful
tul.push(70000);
//Enums - make code look more pleasant, similar to what happened in c# with Menus Stephen made
//In JS it is done through a process with functions
var Engine;
(function (Engine) {
    Engine[Engine["Off"] = 0] = "Off";
    Engine[Engine["Idle"] = 1] = "Idle";
    Engine[Engine["Accelerate"] = 2] = "Accelerate";
})(Engine || (Engine = {}));
let enginestate = Engine.Accelerate;
if (enginestate == Engine.Accelerate) {
    console.log("This thing is going to crash!!!!!!");
}
//=====================FUNCTIONS BE HERE===========================//
//Similar to JS but STRICT TYPING changes how it works
function myFunc(params1) {
    console.log(`${params1}`);
}
myFunc("YEEEEEOCCCHHH");
//Returns like this
//If not return type, its a VOID return...like C#
function thatFunch(params2) {
    return params2.concat("Now there are TWO OF THEM!!!!");
}
//======================Classes and oBjects BE HERE======================//
class Dog {
    constructor(color, name, breed) {
        this.color = color;
        this.name = name;
        this.breed = breed;
    }
    //Method Overloading is performed with If statement [Not shown]
    giveColor() {
        console.log("The dog's color is" + this.color);
    }
}
//Sets interface into variable
let ani;
ani = {
    numoflegs: 18,
    isDead: true,
    speed: 200,
    speak() {
        return "SNARF";
    }
};
