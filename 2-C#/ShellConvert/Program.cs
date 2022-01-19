﻿// See https://aka.ms/new-console-template for more information
//Sid Hinson
//Program converted from shell script from first day1 shell prog

Console.Clear();
bool repeat = true;
string tx ="Thanks for Using this program!";
string gb ="Press Enter to End Program! Goodbye!";
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
            Console.WriteLine(red);
            string choice2 = Console.ReadLine();
             if (choice2 == "1")
            {
                Console.WriteLine("We recommend one glass of Intrinsic Cabernet");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
            }
            else if(choice2 == "2")
            {
                Console.WriteLine("We recommend one glass of JLohr Merlot");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
            }
    }

      else if(choice == "2")
    {
            Console.WriteLine(white);
            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Console.WriteLine("We recommend one glass of La Crema Chardonnay");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
            }
            else if(choice2 == "2")
            {
                Console.WriteLine("We recommend one glass of Alphonse Sauvignon");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
            }
    }

     else if(choice == "3")
    {
            Console.WriteLine(white);
            string choice2 = Console.ReadLine();
                if (choice2 == "1")
            {
                Console.WriteLine("We recommend one glass of La Crema Chardonnay");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
            }
            else if(choice2 == "2")
            {
                Console.WriteLine("We recommend one glass of Alphonse Sauvignon");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
            }
    } 

     else if(choice == "4")
    {
            Console.WriteLine(white);
            string choice2 = Console.ReadLine();
                if (choice2 == "1")
            {
                Console.WriteLine("We recommend one glass of La Crema Chardonnay");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
            }
            else if(choice2 == "2")
            {
                Console.WriteLine("We recommend one glass of Alphonse Sauvignon");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
            }
    }

     else if(choice == "5")
    {
        
            Console.WriteLine(sweet);
            string choice2 = Console.ReadLine();
                if (choice2 == "1")
            {
                Console.WriteLine("We recommend one glass of St.Michelle Riesling");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
            }
            else if(choice2 == "2")
            {
                Console.WriteLine("We recommend one glass of King Estate Pinot Grigio");
                Console.WriteLine(tx);
                Console.WriteLine(gb);
                Console.ReadLine();
                repeat = false;
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
        Console.WriteLine(" Please try Again!! Press Enter to end the Program!");
        Console.ReadLine();
        repeat = false;
    }

}





