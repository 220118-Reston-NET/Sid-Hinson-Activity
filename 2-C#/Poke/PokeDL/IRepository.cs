using PokeModel;

namespace PokeDL
{
    
    public interface IRepository
    {
      
        Pokemon AddPokemon(Pokemon p_poke);

     
        List<Pokemon> GetAllPokemon();
    }
}
