using System;
using System.IO;
using System.Windows.Forms;

namespace PokemonGen1StatTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Directory.SetCurrentDirectory(@"..\..");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StatTrackerForm());
        }
    }
}
