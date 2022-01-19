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
        private int _mpg;

        //Property
        //They are in PascalCase
        public string Color
        {
            //getter - make private keyword readable
            get { return "The color is " +_color; }

            //setter - make one of your private fields writable
            set {_color = value; }

        }

        
    }   

}