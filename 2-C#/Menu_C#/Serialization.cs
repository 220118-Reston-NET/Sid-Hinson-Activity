using System.Text.Json;
using UserStatsFunction;
using System.Collections.Generic;

namespace Serialization
{

    public class Serialize
    {

        //**We are working with a String object and a List object both in two separate files for training**


        //Begin Demo Area
        // Anything in a static method MUST also be in a static field as well or it will fail
        private static string _filepath1 = "./Database/NewUser.json";
        private static string _filepath2 = "./Database/NewListUser.json";
        public static void SerialMain()
        {
            Console.WriteLine("=== My First Serialization ===");
            Console.WriteLine("=Converting object to JSON=");
            
            UserStats NewUser = new UserStats()
            {
                    Company = "Revature",
                    Age = 41,
                    FavRest = "Original Oyster House"

            };

  


            //Storing Multiple Objects Inside of a JSON file USE A LIST
            //This is a LIST T class uses systems collections generic
            List<UserStats> ListofUserStats = new List<UserStats>();
            //Add the created UserStat NewUser to List object
            //Note: this will be a problem if we go to add it, since the Serializer will expect only 1 object!!!! 
            ListofUserStats.Add(NewUser);

            // Serializes the object into a JSON formatted string 
            //the JsonSerializerOptions make it to a corrrect format easier to later work with
            string jsonstring1 = JsonSerializer.Serialize(NewUser, new JsonSerializerOptions {WriteIndented = true});
            //Print out JSON string object
            Console.WriteLine(" Here Is your JSON serialized Object");
            Console.WriteLine(jsonstring1);
            //Using the Built in File Class to write the string to a File
            File.WriteAllText(_filepath1, jsonstring1);
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

            //Deserailize the Jsonstring into an object
            Console.WriteLine("=Converting JSON to Object=");
            string jsonstring2 = File.ReadAllText(_filepath1);
            //Note: Putting a ? is null conditional operator. 
            // It basically means: "Evaluate the first operand; if that's null, stop, with a result of null.
            //This method turn it into a object
            UserStats? NewUser1 = JsonSerializer.Deserialize<UserStats>(jsonstring2);
            //Print out JSON string object
            Console.WriteLine(" Here are your JSON STRING object Deserialized Class Properties");
            Console.WriteLine(NewUser1.Company);
            Console.WriteLine(NewUser1.Age);
            Console.WriteLine(NewUser1.FavRest);
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

             // Serializes the object into a JSON formatted string 
            //the JsonSerializerOptions make it to a corrrect format easier to later work with
            string jsonstring3 = JsonSerializer.Serialize(ListofUserStats, new JsonSerializerOptions {WriteIndented = true});
            //Print out JSON string object
            Console.WriteLine(" Here Is your LIST JSON serialized Object");
            Console.WriteLine(jsonstring3);
            //Using the Built in File Class to write the string to a File
            File.WriteAllText(_filepath2, jsonstring3);
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

            //Creates a json object string with the NewUser stats
            string jsonstring4 = File.ReadAllText(_filepath2);
            //Creates a List to Deserialize the information from the string into
            List<UserStats>? NewListUser1 = JsonSerializer.Deserialize<List<UserStats>>(jsonstring4);
            //Writes the deserialized Individual List String object by Index position
            Console.WriteLine(" Here are your JSON LIST object Deserialized Class Properties");
            Console.WriteLine(NewListUser1[0].Company);
            Console.WriteLine(NewListUser1[0].Age);
            Console.WriteLine(NewListUser1[0].FavRest);
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

        }

    }
}