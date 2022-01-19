// // See https://aka.ms/new-console-template for more information
// using CarFunction;

// Console.WriteLine("Hello, World!");

// //NameofClass NameofVariable = new NameofClass();
// Car car1 = new Car();
// Console.WriteLine(car1.Color);
// car1.Color = "Red";
// Console.WriteLine(car1.Color);
// car1.Fuel =10;
// Console.WriteLine(car1.Fuel);
// car1.Start();
// car1.Start(100);

// //Another way of initializing objects out of class but preconfiguring our states already
// Car car2 = new Car()
// {
//     Color = "Yellow",
//     Fuel = 100,
//     owner ="Stephen",

// };

// Console.WriteLine(car2.Fuel);
// Console.WriteLine(car2.Color);
// Console.WriteLine(car2.TotalDistance());

bool repeat = true;


Console.Clear();
Console.WriteLine("Welcome to Programming");
Console.WriteLine("Please tell me your name");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}, what do you want to to do today?");
Console.WriteLine("[1] - Add Two Numbers");
Console.WriteLine("[2] - Exit");

string userInput = Console.ReadLine();

if (userInput == "1")
{
    Console.WriteLine("Please Give Me Two Numbers!");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The sum is: {num2+num1}");
}