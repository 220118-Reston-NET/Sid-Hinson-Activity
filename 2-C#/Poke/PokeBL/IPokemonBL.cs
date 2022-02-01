using PokeModel;

namespace PokeBL
{
    
    ///Business Layer is responsible for further validation or processing of data obtained from either the DB
   
    
    public interface IPokemonBL
    {
      
        Pokemon AddPokemon(Pokemon p_poke);

       
        List<Pokemon> SearchPokemon(string p_name);
    }
}
