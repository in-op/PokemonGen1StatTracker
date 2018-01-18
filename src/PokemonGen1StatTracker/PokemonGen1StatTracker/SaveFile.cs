using System.Collections.Generic;
using System.IO;
using Saving;

namespace PokemonGen1StatTracker
{
    internal static class SaveFile
    {
        private static readonly string path = @".\\save\\save.bin";

        internal static List<PokemonDTO> Load()
        {
            if (File.Exists(path))
                return SaveManager.Load<List<PokemonDTO>>(path);
            else return new List<PokemonDTO>(151);
        }

        internal static void Save(List<PokemonDTO> yourPokemon)
        {
            SaveManager.Save(path, yourPokemon);
        }
    }
}
