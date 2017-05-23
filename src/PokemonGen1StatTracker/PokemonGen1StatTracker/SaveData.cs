using System;
using System.Collections.Generic;

namespace PokemonGen1StatTracker
{
    [Serializable]
    public class SaveData
    {
        public List<Pokemon> savedPokemon = new List<Pokemon>(151);
    }
}
