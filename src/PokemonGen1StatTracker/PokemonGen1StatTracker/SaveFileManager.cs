using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PokemonGen1StatTracker
{
    internal static class SaveFileManager
    {
        internal static List<SaveData.Pokemon> LoadSavedPokemonList()
        {
            if (File.Exists(@".\\save\\save.bin"))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@".\\save\\save.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                SaveData save = (SaveData)formatter.Deserialize(stream);
                stream.Close();
                return save.savedPokemon;
            }
            else return new List<SaveData.Pokemon>(151);
        }


        internal static void SavePokemonListToFile(List<SaveData.Pokemon> yourPokemon)
        {
            SaveData save = new SaveData();
            save.savedPokemon = yourPokemon;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@".\\save\\save.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, save);
            stream.Close();
        }
    }
}
