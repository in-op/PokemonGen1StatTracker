using System;
using System.IO;
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
            Directory.SetCurrentDirectory(@"..\..");
        }
        

        private void InitializePokemonDropDown()
        {
            pokemonDropDown.Items.AddRange(PokemonData.Species);
        }

        private void calcStatsButton_Click(object sender, EventArgs e)
        {
            int pokemonNumber = int.MinValue;
            for (int i = 0; i < 151; i++)
                if (pokemonDropDown.Text == PokemonData.Species[i])
                    pokemonNumber = i + 1;
            
            float.TryParse(hpTextBox.Text, out float hp);
            float.TryParse(levelInput.Text, out float lvl);
            float.TryParse(attackTextBox.Text, out float atk);
            float.TryParse(defenseTextBox.Text, out float def);
            float.TryParse(specialTextBox.Text, out float spc);
            float.TryParse(speedTextBox.Text, out float spd);
            
            // BUG (for now) ALL STAT EXP SET TO 0
            // FIX FIX FIX FIX for later
            hpIvLabel.Text = DVCalculator.MinHPDV(hp, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].HP) + 
                             "-" + DVCalculator.MaxHPDV(hp, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].HP);

            attackIvLabel.Text = DVCalculator.MinNonHPDV(atk, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].Attack) +
                                 "-" + DVCalculator.MaxNonHPDV(atk, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].Attack);

            defenseIvLabel.Text = DVCalculator.MinNonHPDV(def, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].Defense) +
                                  "-" + DVCalculator.MaxNonHPDV(def, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].Defense);

            specialIvLabel.Text = DVCalculator.MinNonHPDV(spc, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].Special) +
                                  "-" + DVCalculator.MaxNonHPDV(spc, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].Special);

            speedIvLabel.Text = DVCalculator.MinNonHPDV(spd, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].Speed) +
                                "-" + DVCalculator.MaxNonHPDV(spd, lvl, 0f, PokemonData.AllBaseStats[pokemonNumber].Speed);
        }

        private void pokemonDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                spriteBox.Load(".\\img\\" + pokemonDropDown.Text + ".png");
            }
            catch
            {
                spriteBox.Load(".\\img\\Missingno.png");
            }
        }
    }
}
