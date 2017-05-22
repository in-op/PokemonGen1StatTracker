using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGen1StatTracker
{
    public static class StatCalculator
    {

        public static float StatExp(float exp)
        {
            return (float)Math.Floor(
                (Math.Ceiling(Math.Sqrt(exp)))
                / 4f);
        }



        public static int MinHPDV(float stat, float lvl, float exp, float baseStat)
        {
            return (int)Math.Ceiling(
                (((100f * stat) - 1000f - (100f * lvl)) / (2f * lvl))
                - (exp / 2f)
                - baseStat);
        }

        public static int MaxHPDV(float stat, float lvl, float exp, float baseStat)
        {
            return (int)Math.Floor(
                (((100f * stat) + 99.9999f - 1000f - (100f * lvl)) / (2f * lvl))
                - (exp / 2f)
                - baseStat);
        }

        public static int MinNonHPDV(float stat, float lvl, float exp, float baseStat)
        {
            return (int)Math.Ceiling(
                (((100f * stat) - 500f) / (2f * lvl))
                - (exp / 2f)
                - baseStat);
        }

        public static int MaxNonHPDV(float stat, float lvl, float exp, float baseStat)
        {
            return (int)Math.Floor(
                (((100f * stat) + 99.9999f - 500f) / (2f * lvl))
                - (exp / 2f)
                - baseStat);
        }
    }
}
