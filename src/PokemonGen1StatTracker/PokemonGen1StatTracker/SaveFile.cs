using System.Collections.Generic;
using System.IO;
using Saving;

namespace PokemonGen1StatTracker
{
    internal static class SaveFile
    {
        private static readonly string path = @".\\save\\save.bin";

        internal static List<Pokemon> Load()
        {
            if (File.Exists(path))
                return SaveManager.Load<List<Pokemon>>(path);
            else return new List<Pokemon>(151);
        }

        internal static void Save(List<Pokemon> yourPokemon)
        {
            SaveManager.Save(path, yourPokemon);
        }
    }
}
