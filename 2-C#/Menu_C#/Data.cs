using System.Collections;

// Data namespace to process the program data
namespace DataFunction
{

    //Creates List of Dinner selections
    public class DinnerSelection
    {
        public static List<string> Selection = new List<string>();
    
        public static void dinnerchoice(string item)
        {
            Selection.Add(item);

        }
    
    // Display Wine Selections
    public static void DisplaySelections()
    {
        Console.WriteLine("These are your selections : ");
              foreach (string x in Selection)
            {
                if (Selection.Count == 0 || Selection == null)
                {
                     Console.WriteLine(" !No Selections? You Should Add One Yourself! ");
                }
                else 
                {
                Console.WriteLine(x);
                }
            }
      }
    
    // Clear Selections
     public static void ClearSelections()
    {
        Selection.Clear();
        Console.WriteLine("The Selections are Now Cleared");
        Console.WriteLine("Press Enter to Start Over");
    }

    //Remove Selections
     public static void RemoveSelectionsDinner()
    {
        Selection.RemoveAt(0);
    }
     public static void RemoveSelectionsWine()
    {
        Selection.RemoveAt(1);

    }
        //Add Dinner Selection
     public static void AddSelectionsDinner(string item)
    {
        string x = item;
        //Selection.RemoveAt(0);
        Selection.Insert(0, x);
        Console.WriteLine(" Your Dinner Selection is Added! ");

    }
        //Add Selections Wine
     public static void AddSelectionsWine(string item)
    {
        string x = item;
        //Selection.RemoveAt(1);
        Selection.Insert(1, x);
        Console.WriteLine(" Your Wine Selection is Added! ");

    }

        //Search Class
        public static void SearchSelections(string item)
        {

            if (Selection.Count == 0)
                {
                    Console.WriteLine("You DO NOT have any selections!!!!");
                }
            else 
            {
                if (Selection.Contains(item))
                {
                        Console.WriteLine("Item IS in your selections!!!!");
                }
                 else
                {
                        Console.WriteLine("You DO NOT have this selection!!!!");
                }


            }


        }
    }


//Learning Class added/designed merely to explore serialization. Overall this class was unnecessary and is redundant.
  class Protein
{
   public string Decision { get; set;}

}


}
 
