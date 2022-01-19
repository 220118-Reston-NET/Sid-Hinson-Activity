//Namespace is agreat way to organize your code
namespace CarFunction
{ 
    //This is how you create a class while using the class keyword
    //Public is there to make a class viisible for everyone else
    public class Car
    {

        //Field
        //It is used to store the information and define the current state of the object
        //Private means that only the class itself we can use that field
        private string _color = "Blue";
        private string _owner;
        private int _fuel;
        private int _gallonPerMile;

        //Property
        //They are in PascalCase
        public string Color
        {
            //getter - make private keyword readable
            get { return "The color is " +_color; }

            //setter - make one of your private fields writable
            set {_color = value; }

        }

        public string owner 
        { 
            get { return _owner; }
            set { _owner = value; } 
            
        }
        
        public Car()
        {
         _color = "Blue";
         _gallonPerMile = 10;
         _owner = "No Owner";
         Fuel = 100;

        }
        public int Fuel { get; set; }

        //Below is an example of Polymorphism (Overriding)
        public void Start ()
        {
            Console.WriteLine("The car will start now!!");
            Console.WriteLine($"Current fuel : {Fuel}");

        }

        //You can add parameters to a method to pass in data to be used inside method
        //Make sure the parameter has a datatype and then a name
        public void Start (int p_fuel)
        {
            Fuel = p_fuel;
            Console.WriteLine("The car will start now!!");
            Console.WriteLine($"Current fuel : {Fuel}");
        }

        //Will give the total distance of the car
       public double TotalDistance()
       {
            return (double)Fuel/_gallonPerMile;
       }




    }   

}