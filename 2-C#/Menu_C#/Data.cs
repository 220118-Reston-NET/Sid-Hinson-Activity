using System.Collections;

namespace DataFunction
{
   
    public class DinnerSelection
    {
        public List<string> _choices = new List<string>();
        public string dinner = _choices[0];
        public string wine = _choices[1];

        

        public void DisplayChoices() 
        {
            
          Console.WriteLine("Your selection for dinner is: " + _choices[0]);
          Console.WriteLine("Your selection for wine is: " + _choices[1]);
                
        }

        public void RemoveChoices()
        {

          _choices[0] = "Nothing";
          _choices[1] = "Nothing";
          Console.WriteLine("Your selection for dinner is: " + _choices[0]);
          Console.WriteLine("Your selection for wine is: " + _choices[1]);

        }

        public void SetDinner()
        {
            dinner = value;

        }

        public void SetWine()
        {
            wine = value;

        }


    }
}