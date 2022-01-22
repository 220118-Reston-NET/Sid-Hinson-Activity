namespace DataFunctions
{

    public class UserProgam
    
    {
        private string FirstName;
        private string LastName;


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


        public void GetName()
        {
                Console.WriteLine(" Please Enter your FIRST name ");
                string inputFirst = Console.ReadLine();
                Console.WriteLine(" Please Enter your LAST name ");
                string inputLast = Console.ReadLine();
                FirstName = inputFirst;
                LastName = inputLast;
        }
        public void Welcome()
        {
                Console.WriteLine($" Hello there");
                Console.WriteLine(" It is time to Pick Your College ");
                Console.WriteLine(" Press Enter to continue ");
        }

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


      public class MGA
    
    {
        public double MgaStHours { get; set; }
        public double MgaTutionRate = 113.67;
        double MgaActRate = 3.00;
        double MgaAthRate = 45.00;
        double MgaHealthRate = 20.00;
        double MgaParkRate = 10.00 ;
        double MgaInstRate = 125.00;
        double MgaRecRate = 165.00 ;
        double MgaTecRate = 46.00 ;

        double FeeTotal = 527.64;

        public void printFees()
        {
            Console.WriteLine($" ***********************************************");
            Console.WriteLine($" MGA Institutional Fees: {MgaTutionRate}");
            Console.WriteLine($" Tution Rate per Hour: {MgaActRate}");
            Console.WriteLine($" Activity Fee: {MgaActRate}");
            Console.WriteLine($" Athletic Fee: {MgaAthRate}");
            Console.WriteLine($" Health Fee: {MgaHealthRate}");
            Console.WriteLine($" Parking Fee: {MgaParkRate}");
            Console.WriteLine($" Institutional Fee: {MgaInstRate}");
            Console.WriteLine($" Recreational Fee: {MgaRecRate}");
            Console.WriteLine($" Technology Fee: {MgaRecRate}");
            Console.WriteLine($" **********************************************");
        }
       


    }

      public class CGTC
    
    {
       
        public double CgtcStHours { get; set; }
        double CgtcTutionRate = 100.00;
        double CgtcActRate = 40.00;
        double CgtcAthRate = 0.00;
        double CgtcHealthRate = 6.00;
        double CgtcParkRate = 0.00;
        double CgtcInstRate = 55.00;
        double CgtcRecRate = 0.00;
        double CgtcTecRate = 105.00;

        double FeeTotal = 306.00;

        public void printFees()
        {
            Console.WriteLine($" ***********************************************");
            Console.WriteLine($" CGTC Institutional Fees: {CgtcTutionRate}");
            Console.WriteLine($" Tution Rate per Hour: {CgtcActRate}");
            Console.WriteLine($" Activity Fee: {CgtcActRate}");
            Console.WriteLine($" Athletic Fee: {CgtcAthRate}");
            Console.WriteLine($" Health Fee: {CgtcHealthRate}");
            Console.WriteLine($" Parking Fee: {CgtcParkRate}");
            Console.WriteLine($" Institutional Fee: {CgtcInstRate}");
            Console.WriteLine($" Recreational Fee: {CgtcRecRate}");
            Console.WriteLine($" Technology Fee: {CgtcRecRate}");
            Console.WriteLine($" **********************************************");

        }

    }


    
}