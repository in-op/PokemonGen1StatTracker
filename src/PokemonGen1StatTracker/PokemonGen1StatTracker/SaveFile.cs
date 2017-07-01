using System.Collections.Generic;
using System.IO;
using Saving;

namespace PokemonGen1StatTracker
{
    internal static class SaveFile
    {
        internal static List<Pokemon> Load() =>
            File.Exists(@".\\save\\save.bin") ?
            SaveManager.Load<List<Pokemon>>(@".\\save\\save.bin") :
            new List<Pokemon>(151);


        internal static void Save(List<Pokemon> yourPokemon)
        {
            SaveManager.Save(@".\\save\\save.bin", yourPokemon);
        }
    }
}