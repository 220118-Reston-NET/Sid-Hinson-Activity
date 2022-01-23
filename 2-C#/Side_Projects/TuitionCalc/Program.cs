using DataFunctions;

//Create New Instance of Program
UserProgam User1 = new UserProgam();

//Menu Operation
User1.ProgStart();
User1.SetName();
Console.WriteLine($" Hello there {User1.GetName()} ");
User1.Welcome();

//Program Logic
bool repeat = true;
while (repeat)
{

User1.DisplayChoices();
string input1 = Console.ReadLine();

    try
    {
        int choice = Int32.Parse(input1);
        switch (choice) 
        {
        case 1:
            Console.WriteLine("You have chosen Middle Georgia State College.");
            Console.WriteLine("Please Enter the Number of Credit Hours you are Taking.");
            string choice1 = Console.ReadLine();
            int MgaHours = Int32.Parse(choice1);
            College MGA = new College(MgaHours, 113.67, 3.00, 45.00, 20.00, 10.00, 125.00, 165.00, 46.00);
            MGA.StHours = MgaHours;
            MGA.printFees();
            Console.WriteLine("Your Final Overall Semester Tution is");
            Console.WriteLine($"MGA TUITION for {MgaHours} hours = ${MGA.DisplayTution()}");
            Console.WriteLine("Program Will now restart. Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
            break;
   


        case 2:
            Console.WriteLine("You have chosen Central Georgia Technical College");
            Console.WriteLine("Please Enter the Number of Credit Hours you are Taking.");
            string choice2 = Console.ReadLine();
            int CgtcHours = Int32.Parse(choice2);
            College CGTC = new College(CgtcHours, 100.00, 40.00, 0.00, 6.00, 0.00, 55.00, 0.00, 105.00);
            CGTC.StHours = CgtcHours;
            CGTC.printFees();
            Console.WriteLine("Your Final Overall Semester Tution is");
            Console.WriteLine($"CGTC TUITION for {CgtcHours} hours = ${CGTC.DisplayTution()}");
            Console.WriteLine("Program Will now restart. Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
            break;

        case 3:
            Console.WriteLine("Thank you for using Tuition Calculator. Bye for now. Press Enter to Exit");
            Console.ReadLine();
            Console.Clear();
            repeat = false;
            break;

        default:
            Console.WriteLine("You Must Choose 1 or 2");
            Console.WriteLine("Program Will now restart. Press Enter to Continue");
            Console.ReadLine();
            break;
        }
    }
    catch(Exception e)
    {
           Console.WriteLine("You MUST type either [1] [2] [3]");
    }
}
