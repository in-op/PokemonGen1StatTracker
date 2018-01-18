using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGen1StatTracker
{
    internal static class Util
    {
        internal static string ToString(Pokemon.Type type)
        {
            if (type == Pokemon.Type.None)
                return "";
            else return type.ToString();
        }
    }
}
