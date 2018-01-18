using System;

namespace PokemonGen1StatTracker
{
    [Serializable]
    public class PokemonDTO
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
