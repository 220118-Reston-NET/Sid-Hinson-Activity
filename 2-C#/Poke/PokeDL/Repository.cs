using System.Text.Json;
using PokeModel;

namespace PokeDL
{
    public class Repository : IRepository
    {
        //Relative filepath 
        private string _filepath = "../PokeDL/Database/";
        private string _jsonString;
        public Pokemon AddPokemon(Pokemon p_poke)
        {
            //So we can change which JSON files 
            string path = _filepath + "Pokemon.json";
            List<Pokemon> listOfPoke = GetAllPokemon();
            listOfPoke.Add(p_poke);

            _jsonString = JsonSerializer.Serialize(listOfPoke, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path , _jsonString);

            return p_poke;
        }

        public List<Pokemon> GetAllPokemon()
        {
            //Grab info
            _jsonString = File.ReadAllText(_filepath + "Pokemon.json");

            //Deserialize the jsonString
            return JsonSerializer.Deserialize<List<Pokemon>>(_jsonString);
        }
    }
}