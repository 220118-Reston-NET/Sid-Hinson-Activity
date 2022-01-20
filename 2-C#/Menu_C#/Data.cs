using System.Collections;

namespace DataFunction
{
   
    public class DinnerSelection
    {
        public static List<string> _addSelection = new List<string>();
    
        public static void dinnerchoice(string item)
        {
            _addSelection.Add(item);

        }
    
    public static void DisplaySelections()
    {
        Console.WriteLine("These are your selections :");
              foreach (string item in _addSelection)
            {
                Console.WriteLine(item);
            }
      }
    }

 }
