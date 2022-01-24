
namespace UserStatsFunction
{
public class UserStats
    {
        public string Company { get; set; }
        public int Age { get; set; }
        public string FavRest { get; set; }

         public void DisplayStats()
        {
            Console.WriteLine($"Your Company is {Company} ");
            Console.WriteLine($"Your Age is {Age}");
            Console.WriteLine($"Your Favorite Restaurant is {FavRest}");
        }



    }

       
}