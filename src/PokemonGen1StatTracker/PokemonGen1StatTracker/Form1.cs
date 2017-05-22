using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonGeneration1.Source.PokemonData;

namespace PokemonGen1StatTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializePokemonDropDown();
        }
        

        private void InitializePokemonDropDown()
        {
            pokemonDropDown.Items.AddRange(PokemonData.Species);
        }

        private void calcStatsButton_Click(object sender, EventArgs e)
        {
            hpIvLabel.Text = "100";
            attackIvLabel.Text = "100";
            defenseIvLabel.Text = "100";
            specialIvLabel.Text = "100";
            speedIvLabel.Text = "100";
        }

        

        
    }
}
