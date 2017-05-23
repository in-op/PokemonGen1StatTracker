using System;
using System.Collections.Generic;

namespace PokemonGen1StatTracker
{
    [Serializable]
    public class SaveData
    {
        public List<Pokemon> savedPokemon = new List<Pokemon>(151);

        
        [Serializable]
        public class Pokemon
        {
            public string nickname;
            public string species;
            public string level;

            public string hpStat;
            public string attackStat;
            public string defenseStat;
            public string specialStat;
            public string speedStat;

            public string hpExp;
            public string attackExp;
            public string defenseExp;
            public string specialExp;
            public string speedExp;
        }

    }
}
