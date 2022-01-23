namespace DataFunctions
{

    public class UserProgam
    
    {
        // Name Security
        private string _firstname;
        private string _lastname;

        // Start Program
          public void ProgStart()
        {
                Console.WriteLine("*************************************************");
                Console.WriteLine("*           Tution Calculator Ver 1.0           *");
                Console.WriteLine("*                By Sid Hinson                  *");
                Console.WriteLine("*                    2022                       *");
                Console.WriteLine("*<Calculate Your Public Tution from Mid-Ga Area>*");
                Console.WriteLine("*************************************************");
                Console.WriteLine(" Press Enter to continue ");
                Console.ReadLine();
                Console.Clear();
        }

        //Grab Name as a Test to set Private Field
        public void SetName()
        {
                Console.WriteLine(" Please Enter your FIRST name ");
                string inputFirst = Console.ReadLine();
                Console.WriteLine(" Please Enter your LAST name ");
                string inputLast = Console.ReadLine();
                _firstname = inputFirst;
                _lastname = inputLast;
        }

        public string GetName()
        {
            return _firstname + " " + _lastname ;
        }

        //Welcome
        public void Welcome()
        {
                Console.WriteLine(" Welcome! ");
                Console.WriteLine(" First, We need to pick Your College ");
                Console.WriteLine(" Press Enter to continue ");
        }

        //Display Menu Choices
        public void DisplayChoices()
        {
        Console.WriteLine("******************************************");
        Console.WriteLine("        *Please Choose Your College:     *");
        Console.WriteLine("*       [1] Enter One for MGA            *");
        Console.WriteLine("*       [2] Enter Two for CGTC           *");
        Console.WriteLine("*       [3] Enter Three To Exit          *");
        Console.WriteLine("******************************************");
        Console.WriteLine(" Enter a Selection to Continue ");
        }
    }

      //College Object Class
      public class College
    
    {
        //Class Variables
        public double StHours { get; set; }
        public double TuitionRate { get; set; }
        public double ActRate { get; set; }
        public double AthRate { get; set; }
        public double HealthRate { get; set; }
        public double ParkRate { get; set; }
        public double InstRate { get; set; }
        public double RecRate { get; set; }
        public double TecRate { get; set; }

        //Display Fees
        public void printFees()
        {
            Console.WriteLine($" *****************************************************");
            Console.WriteLine($" Here are the MGA Institutional Fees:");
            Console.WriteLine($" Tution Rate per Hour: {TuitionRate}");
            Console.WriteLine($" Activity Fee: {ActRate}");
            Console.WriteLine($" Athletic Fee: {AthRate}");
            Console.WriteLine($" Health Fee: {HealthRate}");
            Console.WriteLine($" Parking Fee: {ParkRate}");
            Console.WriteLine($" Institutional Fee: {InstRate}");
            Console.WriteLine($" Recreational Fee: {RecRate}");
            Console.WriteLine($" Technology Fee: {TecRate}");
            Console.WriteLine($" *****************************************************");
        }
       
       //Display Tution
        public double DisplayTution()
        {
            return (StHours * TuitionRate) + StHours + TuitionRate + ActRate + AthRate + HealthRate + ParkRate + InstRate + RecRate + TecRate;
        }

        //Constructor
        public College(double hours, double rate, double activity, double athelete, double health, double park, double inst, double rec, double tech)
        {
        StHours = hours;
        TuitionRate = rate;
        ActRate = activity; 
        AthRate = athelete; 
        HealthRate = health;
        ParkRate = park;
        InstRate = inst;
        RecRate = rec;
        TecRate = tech;
        }
    }
    
}