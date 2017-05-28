using System.Collections.Generic;
using System.IO;
using Saving;

namespace PokemonGen1StatTracker
{
    internal static class SaveFile
    {
        internal static List<Pokemon> Load()
        {
            if (File.Exists(@".\\save\\save.bin"))
                return SaveManager.Load<List<Pokemon>>(@".\\save\\save.bin");
            else return new List<Pokemon>(151);
        }


        internal static void Save(List<Pokemon> yourPokemon)
        {
            SaveManager.Save(@".\\save\\save.bin", yourPokemon);
        }
    }
}