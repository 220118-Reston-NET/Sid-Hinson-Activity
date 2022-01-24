// See https://aka.ms/new-console-template for more information
//Sid Hinson
//Program converted from shell script from first day1 shell prog
//1-20-2022 Expanded to include more functionality
using DataFunction;
using WineFunction;
using UserStatsFunction;
using Serialization;

//User Created Object to Later Serialize and Use as an example of Constructor
var user = new UserStats()
{
    Company = "Tesla",
    Age = 41,
    FavRest = "Bonefish Grill"

};





Console.Clear();
bool repeat = true;
string tx ="Selections are Made!";
string gb ="Press Enter to Continue";
string red ="Please Choose [1] for Cabernet or [2] for Merlot";
string white ="Please Choose [1] for Chardonnay or [2] for Sauvignon";
string sweet ="Please Choose [1] for Riesling or [2] for Pinot Grigio";
while (repeat)
{

Console.WriteLine("******************************************************");
Console.WriteLine("* Welcome to the Wine Pairing Optimizer Application  *");
Console.WriteLine("*----------------------------------------------------*");
Console.WriteLine("*  We will find what wine is best with your dinner!  *");
Console.WriteLine("*    Enter 1 if you are having steak for dinner!     *");
Console.WriteLine("*   Enter 2 if you are having chicken for dinner!    *");
Console.WriteLine("*    Enter 3 if you are having pork for dinner!      *");
Console.WriteLine("*   Enter 4 if you are having seafood for dinner!    *");
Console.WriteLine("*    Enter 5 if you are vegetarian for dinner!       *");
Console.WriteLine("*         Enter 6 to exit this program!              *");
Console.WriteLine("*   !PRESS ENTER TWICE TO SKIP TO CUSTOMIZE MENU!    *");
Console.WriteLine("******************************************************");

Console.WriteLine(" Please Enter a Number to make your selection!");
string choice = Console.ReadLine();



    if (choice == "1")
    {
            string item = "Steak";
            DinnerSelection.dinnerchoice(item);
            Console.WriteLine(red);
            string choice2 = Console.ReadLine();
             if (choice2 == "1")
            {
                string item2 = "Intrinsic Cabernet";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine(tx);
                WineType Intrinsic = new WineType("Red", "Full", "Dry", "Earthy");
                Intrinsic.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
                
                
            }
            else if(choice2 == "2")
            {
                string item2 = "JLohr Merlot";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.WriteLine(tx);
                WineType JLohr = new WineType("Red", "Full", "Dry", "Oaky");
                JLohr.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
               
            }
    }

      else if(choice == "2")
    {
            string item = "Chicken";
            DinnerSelection.dinnerchoice(item);
            Console.WriteLine(white);
            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                string item2 = "La Crema Chardonnay";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine(tx);
                WineType LaCrema = new WineType("White", "Full", "Sweet", "Floral");
                LaCrema.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
               
            }
            else if(choice2 == "2")
            {
                string item2 = "Alphonse Sauvignon";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine(tx);
                WineType Alphonse = new WineType("White", "Full", "Dry", "Floral");
                Alphonse.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
               
            }
    }

     else if(choice == "3")
    {
            string item = "Pork";
            DinnerSelection.dinnerchoice(item);
            Console.WriteLine(white);
            string choice2 = Console.ReadLine();
                if (choice2 == "1")
            {
                string item2 = "La Crema Chardonnay";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine(tx);
                WineType LaCrema = new WineType("White", "Full", "Dry", "Floral");
                LaCrema.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
            else if(choice2 == "2")
            {
                string item2 = "Alphonse Sauvignon";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine(tx);
                WineType Alphonse = new WineType("White", "Full", "Sweet", "Floral");
                Alphonse.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
    } 

     else if(choice == "4")
    {
            
            string item = "Seafood";
            DinnerSelection.dinnerchoice(item);
            Console.WriteLine(white);
            string choice2 = Console.ReadLine();
                if (choice2 == "1")
            {
                string item2 = "La Crema Chardonnay";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine(tx);
                WineType LaCrema = new WineType("White", "Full", "Dry", "Floral");
                LaCrema.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
            else if(choice2 == "2")
            {
                string item2 = "Alphonse Sauvignon";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine(tx);
                WineType Alphonse = new WineType("White", "Full", "Sweet", "Floral");
                Alphonse.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
    }

     else if(choice == "5")
    {
            string item = "Vegetarian Meal";
            DinnerSelection.dinnerchoice(item);
            Console.WriteLine(sweet);
            string choice2 = Console.ReadLine();
                if (choice2 == "1")
            {
                string item2 = "St.Michelle Riesling";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine(tx);
                WineType StMich = new WineType("White", "Full", "Sweet", "Fruity");
                StMich.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
            else if(choice2 == "2")
            {
                
                string item2 = "King Estate Pinot Grigio";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine(tx);
                WineType KingEst = new WineType("White", "Light", "Buttery", "Floral");
                KingEst.DisplayWine();
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
    }

    else if(choice == "6")
    {
        Console.WriteLine(" Thank you for using the Wine Selection Program!");
        Console.WriteLine(" Press Enter to go to Customization Menu!");
        Console.ReadLine();
        repeat = false;
    }

    else
    {
        Console.WriteLine(" Command Not Found!!!!! ");
        Console.WriteLine(" Please try Again!! Press Enter to restart the Program!");
        Console.ReadLine();
    }
 



    {

    //Stats and Selections
    Console.Clear();
    Console.WriteLine(" ****************************************************************");
    Console.WriteLine(" *                 Your User Stats Are :                        *");
    Console.WriteLine(" ****************************************************************");
    user.DisplayStats();
    Console.WriteLine(" ****************************************************************");
    Console.WriteLine(" *=           Here are your Current Dinner selections:          =*");
    Console.WriteLine(" ****************************************************************"); 
    DinnerSelection.DisplaySelections();
    Console.WriteLine(" ****************************************************************");
    Console.WriteLine(" Press Enter to Continue");
    Console.ReadLine();
    Console.Clear();

    //Customization Menu
    Console.WriteLine(" ================================================================");
    Console.WriteLine(" =[1] Do you wish to Clear Selections and Start Over? Enter 1?  =");
    Console.WriteLine(" =[2] Do you wish to Remove Selections?                         =");
    Console.WriteLine(" =[3] Do you wish to Replace Selections?                        =");
    Console.WriteLine(" =[4] Do you wish to Search Selections?                         =");
    Console.WriteLine(" =[5] Do you wish to end the Wine Selection Program? Enter 5?   =");
    Console.WriteLine(" ================================================================");
    Console.WriteLine(" ================================================================");
    Console.WriteLine(" =We have made a great wine selection to pair with your entree! =");
    Console.WriteLine(" ================================================================");
    Console.WriteLine(" =              Enter a Selection to Continue                   =");
    Console.WriteLine(" ================================================================"); 
    string choice3 = Console.ReadLine();

    
    if (choice3 == "1")
        {
        
        Console.WriteLine(" Press Enter to Clear Selections");
        Console.ReadLine();
        DinnerSelection.ClearSelections();
        Console.WriteLine(" Here are your Dinner selections:"); 
        DinnerSelection.DisplaySelections();
        Console.WriteLine(" Press Enter to go back to Start Menu");
        Console.ReadLine();
 
        }
    else if(choice3 == "2")
        {
        Console.WriteLine(" Do you want to remove Dinner or Wine? Enter [1] for Dinner or [2] for Wine.");
        string choice4 = Console.ReadLine();
            if (choice4 == "1")
            {
                DinnerSelection.RemoveSelectionsDinner();
                
                Console.WriteLine(" Steak has been removed ");
                DinnerSelection.DisplaySelections();
                Console.WriteLine(" Press Enter to continue");
                Console.ReadLine();
                
                
            }
            else if (choice4 == "2")
            {
                DinnerSelection.RemoveSelectionsWine();

                Console.WriteLine(" Wine has been removed ");
                DinnerSelection.DisplaySelections();
                Console.WriteLine(" Press Enter to continue");
                Console.ReadLine();
                
            }
            else
            {
            Console.WriteLine(" Command Not Found!!!!! ");
            Console.WriteLine(" Please try Again!! Press Enter to go to Customization Menu!");
            Console.ReadLine();
           
            }
         }

    else if(choice3 == "3")
        {
        Console.WriteLine(" Do you wan to Replace Dinner or Wine? Enter [1] for Dinner or [2] for Wine.");
        string choice5 = Console.ReadLine();
            if (choice5 == "1")
            {
                Console.WriteLine(" Type in Your Replacement! ");
                DinnerSelection.Selection.RemoveAt(0);
                string replaceDinner = Console.ReadLine();
                DinnerSelection.AddSelectionsDinner(replaceDinner);
                DinnerSelection.DisplaySelections();
                Console.WriteLine(" Press Enter to continue");
                Console.ReadLine();
               
                
            }
            else if (choice5 == "2")
            {
                Console.WriteLine(" Type in Your Replacement! ");
                DinnerSelection.Selection.RemoveAt(1);
                string replaceWine = Console.ReadLine();
                DinnerSelection.AddSelectionsWine(replaceWine);
                DinnerSelection.DisplaySelections();
                Console.WriteLine(" Press Enter to continue");
                Console.ReadLine();
                
            }
            else
            {
            Console.WriteLine(" Command Not Found!!!!! ");
            Console.WriteLine(" Please try Again!! Press Enter to restart!");
            Console.ReadLine();
            
            }

        }
    else if(choice3 == "4")
        {
        
        Console.WriteLine(" Please type in your search selection");
        string item3 = Console.ReadLine();
        DinnerSelection.SearchSelections(item3);
        Console.WriteLine(" Press Enter to Continue");
        Console.ReadLine();
        

        }
    else if(choice3 == "5")
        {
        
        Console.WriteLine(" Thank you for using the Wine Selection Program!");
        Console.WriteLine(" Press Enter to end the Program!");
        Console.ReadLine();
        repeat = false;
                
        }
     else
    {
        Console.WriteLine(" Command Not Found!!!!! ");
        Console.WriteLine(" Program Will Now Restart");
        Console.ReadLine();
 
    }


    }

    // Testing Serialization
    Console.WriteLine(" But wait! There's more!");
    Console.WriteLine("Press Enter to Continue");
    Console.ReadLine();
    Console.Clear();
    Serialize.SerialMain();
    Console.WriteLine(" Press Enter to really end the Program this time!");
    Console.ReadLine();
}

