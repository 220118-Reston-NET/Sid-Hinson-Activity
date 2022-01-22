using DataFunctions;

//Create New Instance of Program
UserProgam User1 = new UserProgam();

//Menu Operation
User1.ProgStart();
User1.GetName();
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
            int choice1 = Convert.ToInt32(Console.ReadLine());
            MGA mga1 = new MGA();
            break;


        case 2:
            Console.WriteLine("You have chosen Central Georgia Technical College");
            Console.WriteLine("Please Enter the Number of Credit Hours you are Taking.");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            CGTC cgtc1 = new CGTC();
            break;

        case 3:
            Console.WriteLine("Thank you for using Tuition Calculator. Bye for now.");
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
