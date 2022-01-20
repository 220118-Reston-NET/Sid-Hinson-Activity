// See https://aka.ms/new-console-template for more information
//Sid Hinson
//Program converted from shell script from first day1 shell prog
using DataFunction;

Console.Clear();
bool repeat = true;
string tx ="Selections are Made!";
string gb ="Press Enter to Continue";
string red ="Please Choose [1] for Cabernet or [2] for Merlot";
string white ="Please Choose [1] for Chardonnay or [2] for Sauvignon";
string sweet ="Please Choose [1] for Riesling or [2] for Pinot Grigio";


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
Console.WriteLine("******************************************************");

Console.WriteLine(" Please Enter a Number to make your selection!");
string choice = Console.ReadLine();

while (repeat)
{

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
                Console.WriteLine("We recommend one glass of Intrinsic Cabernet");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                
                
            }
            else if(choice2 == "2")
            {
                string item2 = "JLohr Merlot";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine("We recommend one glass of JLohr Merlot");
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.WriteLine(tx);
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
                Console.WriteLine("We recommend one glass of La Crema Chardonnay");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
               
            }
            else if(choice2 == "2")
            {
                string item2 = "Alphonse Sauvignon";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine("We recommend one glass of Alphonse Sauvignon");
                Console.WriteLine(tx);
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
                Console.WriteLine("We recommend one glass of La Crema Chardonnay");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
            else if(choice2 == "2")
            {
                string item2 = "Alphonse Sauvignon";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine("We recommend one glass of Alphonse Sauvignon");
                Console.WriteLine(tx);
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
                Console.WriteLine("We recommend one glass of La Crema Chardonnay");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
            else if(choice2 == "2")
            {
                string item2 = "Alphonse Sauvignon";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine("We recommend one glass of Alphonse Sauvignon");
                Console.WriteLine(tx);
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
                Console.WriteLine("We recommend one glass of St.Michelle Riesling");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
            else if(choice2 == "2")
            {
                
                string item2 = "King Estate Pinot Grigio";
                DinnerSelection.dinnerchoice(item2);
                Console.WriteLine("We recommend one glass of King Estate Pinot Grigio");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                
            }
    }

    else if(choice == "6")
    {
        Console.WriteLine(" Thank you for using the Wine Selection Program!");
        Console.WriteLine(" Press Enter to end the Program!");
        Console.ReadLine();
        repeat = false;
    }

    else
    {
        Console.WriteLine(" Command Not Found!!!!! ");
        Console.WriteLine(" Please try Again!! Press Enter to restart the Program!");
        Console.ReadLine();
    }

bool repeat2 = true;

while (repeat2)
    {
    Console.Clear();
    Console.WriteLine(" Here are your Dinner selections:"); 
    DinnerSelection.DisplaySelections();
    Console.WriteLine(" [1] Do you wish to Clear Selections and Start Over? Enter 1?");
    Console.WriteLine(" [2] Do you wish to Remove Selections?");
    Console.WriteLine(" [3] Do you wish to Search Selections?");
    Console.WriteLine(" [4] Do you wish to end the Wine Selection Program? Enter 4?");
    string choice3 = Console.ReadLine();

    
    if (choice3 == "1")
        {
        
        Console.WriteLine(" Press Enter to Clear Selections");
        Console.ReadLine();
        DinnerSelection.ClearSelections();
        Console.WriteLine(" Here are your Dinner selections:"); 
        DinnerSelection.DisplaySelections();
        repeat2 = false;
        }
    else if(choice3 == "2")
        {
        Console.WriteLine(" Do you wan to remove Dinner or Wine? Enter [1] for Dinner or [2] for Wine.");
        string choice4 = Console.ReadLine();
            if (choice4 == "1")
            {
                DinnerSelection.RemoveSelectionsDinner();
                
                Console.WriteLine(" Steak has been removed ");
                Console.WriteLine(" Thank you for using the Wine Selection Program!");
                Console.WriteLine(" Press Enter to continue");
                Console.ReadLine();
                repeat2 = false;
                
            }
            else if (choice4 == "2")
            {
                DinnerSelection.RemoveSelectionsWine();

                Console.WriteLine(" Wine has been removed ");
                Console.WriteLine(" Thank you for using the Wine Selection Program!");
                Console.WriteLine(" Press Enter to continue");
                Console.ReadLine();
                repeat2 = false;
            }
            else
            {
            Console.WriteLine(" Command Not Found!!!!! ");
            Console.WriteLine(" Please try Again!! Press Enter to restart!");
            Console.ReadLine();
            repeat2 = false;
            }


        }
      else if(choice3 == "3")
        {
        
        Console.WriteLine(" Please type in your search selection");
        string item3 = Console.ReadLine();
        DinnerSelection.SearchSelections(item3);
        }
    else if(choice3 == "4")
        {
        
        Console.WriteLine(" Thank you for using the Wine Selection Program!");
        Console.WriteLine(" Press Enter to end the Program!");
        Console.ReadLine();
        repeat2 = false;
        repeat = false;
                
        }
     else
    {
        Console.WriteLine(" Command Not Found!!!!! ");
        Console.WriteLine(" Please try Again!! Press Enter to restart!");
        Console.ReadLine();
        repeat2 = false;
    }


    }
}





