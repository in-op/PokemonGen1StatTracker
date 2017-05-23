using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PokemonGen1StatTracker
{
    internal static class SaveManager
    {
        internal static List<Pokemon> Load()
        {
            if (File.Exists(@".\\save\\save.bin"))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@".\\save\\save.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                SaveData save = (SaveData)formatter.Deserialize(stream);
                stream.Close();
                return save.savedPokemon;
            }
            else return new List<Pokemon>(151);
        }


        internal static void Save(List<Pokemon> yourPokemon)
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