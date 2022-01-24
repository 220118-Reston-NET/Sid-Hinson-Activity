namespace WineFunction
{

    //Class to Call Wine Properties
  public class WineType
    {

        public string color;
        public string  body;
        public string taste;
        public string aroma;

        //Testing Parameterized Constructor
        public WineType(string ColorType, string BodyType, string TasteType, string AromaType)
        {
            color = ColorType;
            body = BodyType;
            taste = TasteType;
            aroma = AromaType;
        }

        //Displays Wine
        public void DisplayWine()
        {
            Console.WriteLine($"This wine is a {color} wine with a {body} body, and is {taste} with a {aroma} scent");
        }
}













}