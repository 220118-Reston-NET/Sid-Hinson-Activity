using PokeDL;
using PokeModel;

namespace PokeBL
{
    public class PokemonBL : IPokemonBL
    {

        //Dependency Injection Pattern
        //==============
        private IRepository _repo;
        public PokemonBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //==============

        public Pokemon AddPokemon(Pokemon p_poke)
        {
            Random rand = new Random();

            //Processing data
            //It will esubstract add range from -5 to 5
            p_poke.Attack += rand.Next(-5,5);
            p_poke.Defense += rand.Next(-5,5);
            p_poke.Health += rand.Next(-5,5);

            //Validation process
            List<Pokemon> listOfPoke = _repo.GetAllPokemon();
            if (listOfPoke.Count < 4)
            {
                return _repo.AddPokemon(p_poke);
            }
            else
            {
                throw new Exception("You cannot have more than 4 pokemons!");
            }
        }

        public List<Pokemon> SearchPokemon(string p_name)
        {
            List<Pokemon> listOfPokemon = _repo.GetAllPokemon();


            // LINQ library
            return listOfPokemon
                        .Where(poke => poke.Name.Contains(p_name)) //Where method is designed to filter collection on a condition
                        .ToList(); //ToList method just converts into a list collection that our method needs to return

            // foreach (Pokemon poke in listOfPokemon)
            // {
            //     if (poke.Name.Contains(p_name))
            //     {
            //         //Add to another list
            //     }
            // }

            // //return the filtered/another list
        }
    }
}