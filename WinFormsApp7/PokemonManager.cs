using System;
using System.Collections.Generic;

namespace WinFormsApp7
{
    public class PokemonManager
    {

        private List<Pokemon> pokemons = new List<Pokemon>();

        public void AjouterPokemon(Pokemon nouveauPokemon)
        {
            pokemons.Add(nouveauPokemon);
        }

     
        public List<Pokemon> GetAllPokemons()
        {
            return pokemons;
        }

  
        internal IEnumerable<Pokemon> ObtenirTousLesPokemons()
        {
            return pokemons; 
        }
    }
}
