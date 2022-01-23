namespace WineFunction
{

  public class WineType
    {

        public string color;
        public string  body;
        public string taste;
        public string aroma;

        public WineType(string ColorType, string BodyType, string TasteType, string AromaType)
        {
            color = ColorType;
            body = BodyType;
            taste = TasteType;
            aroma = AromaType;
        }
    
        public void DisplayWine()
        {
            Console.WriteLine($"This wine is a {color} wine with a {body} body, and is {taste} with a {aroma} scent");
        }
}













}