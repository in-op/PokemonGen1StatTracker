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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PokemonGen1StatTracker
{
    public partial class Form1 : Form
    {
        private List<SaveData.Pokemon> yourPokemon;

        public Form1()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(@"..\..");
            LoadSavedPokemon();
            InitializeDropDowns();
        }

        

        private void InitializeDropDowns()
        {
            pokemonDropDown.Items.AddRange(PokemonData.Species);
            koedPokemonDropDown.Items.AddRange(PokemonData.Species);
            UpdateYourPokemonDropDown();
        }


        private void addToYourPokemonButton_Click(object sender, EventArgs e)
        {
            AddYourPokemonToList();
            SaveYourPokemonToFile();
            UpdateYourPokemonDropDown();
        }

        

        private void AddYourPokemonToList()
        {
            yourPokemon.Add(new SaveData.Pokemon()
            {
                nickname = nicknameInput.Text,
                species = pokemonDropDown.Text,
                level = levelInput.Text,

                hpStat = hpTextBox.Text,
                attackStat = attackTextBox.Text,
                defenseStat = defenseTextBox.Text,
                specialStat = specialTextBox.Text,
                speedStat = speedTextBox.Text,

                hpExp = hpExpInput.Text,
                attackExp = attackExpInput.Text,
                defenseExp = defenseExpInput.Text,
                specialExp = specialExpInput.Text,
                speedExp = speedExpInput.Text
            });
        }

        private void addExpButton_Click(object sender, EventArgs e)
        {
            float.TryParse(hpExpInput.Text, out float hpExp);
            float.TryParse(attackExpInput.Text, out float atkExp);
            float.TryParse(defenseExpInput.Text, out float defExp);
            float.TryParse(specialExpInput.Text, out float spcExp);
            float.TryParse(speedExpInput.Text, out float spdExp);

            int pokemonNumber = GetPokemonNumberFromKOedList();
            var baseStats = PokemonData.AllBaseStats[pokemonNumber];

            hpExp += baseStats.HP;
            atkExp += baseStats.Attack;
            defExp += baseStats.Defense;
            spcExp += baseStats.Special;
            spdExp += baseStats.Speed;

            if (hpExp > 65535f) hpExp = 65535f;
            if (atkExp > 65535f) atkExp = 65535f;
            if (defExp > 65535f) defExp = 65535f;
            if (spcExp > 65535f) spcExp = 65535f;
            if (spdExp > 65535f) spdExp = 65535f;

            hpExpInput.Text = hpExp.ToString();
            attackExpInput.Text = atkExp.ToString();
            defenseExpInput.Text = defExp.ToString();
            specialExpInput.Text = spcExp.ToString();
            speedExpInput.Text = spdExp.ToString();
        }


        private void calcStatsButton_Click(object sender, EventArgs e)
        {
            int pokemonNumber = GetPokemonNumber();

            float.TryParse(levelInput.Text, out float lvl);
            float.TryParse(hpTextBox.Text, out float hp);
            float.TryParse(attackTextBox.Text, out float atk);
            float.TryParse(defenseTextBox.Text, out float def);
            float.TryParse(specialTextBox.Text, out float spc);
            float.TryParse(speedTextBox.Text, out float spd);

            float.TryParse(hpExpInput.Text, out float hpExp);
            float.TryParse(attackExpInput.Text, out float atkExp);
            float.TryParse(defenseExpInput.Text, out float defExp);
            float.TryParse(specialExpInput.Text, out float spcExp);
            float.TryParse(speedExpInput.Text, out float spdExp);

            hpExp = StatCalculator.StatExp(hpExp);
            atkExp = StatCalculator.StatExp(atkExp);
            defExp = StatCalculator.StatExp(defExp);
            spcExp = StatCalculator.StatExp(spcExp);
            spdExp = StatCalculator.StatExp(spdExp);


            hpIvLabel.Text = StatCalculator.MinHPDV(hp, lvl, hpExp, PokemonData.AllBaseStats[pokemonNumber].HP) + 
                             "-" + StatCalculator.MaxHPDV(hp, lvl, hpExp, PokemonData.AllBaseStats[pokemonNumber].HP);

            attackIvLabel.Text = StatCalculator.MinNonHPDV(atk, lvl, atkExp, PokemonData.AllBaseStats[pokemonNumber].Attack) +
                                 "-" + StatCalculator.MaxNonHPDV(atk, lvl, atkExp, PokemonData.AllBaseStats[pokemonNumber].Attack);

            defenseIvLabel.Text = StatCalculator.MinNonHPDV(def, lvl, defExp, PokemonData.AllBaseStats[pokemonNumber].Defense) +
                                  "-" + StatCalculator.MaxNonHPDV(def, lvl, defExp, PokemonData.AllBaseStats[pokemonNumber].Defense);

            specialIvLabel.Text = StatCalculator.MinNonHPDV(spc, lvl, spcExp, PokemonData.AllBaseStats[pokemonNumber].Special) +
                                  "-" + StatCalculator.MaxNonHPDV(spc, lvl, spcExp, PokemonData.AllBaseStats[pokemonNumber].Special);

            speedIvLabel.Text = StatCalculator.MinNonHPDV(spd, lvl, spdExp, PokemonData.AllBaseStats[pokemonNumber].Speed) +
                                "-" + StatCalculator.MaxNonHPDV(spd, lvl, spdExp, PokemonData.AllBaseStats[pokemonNumber].Speed);
        }

        private void pokemonDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSprite();
            DisplayBaseStats();
        }

        private void DisplayBaseStats()
        {
            int pokemonNumber = GetPokemonNumber();
            baseHpLabel.Text = PokemonData.AllBaseStats[pokemonNumber].HP.ToString();
            baseAttackLabel.Text = PokemonData.AllBaseStats[pokemonNumber].Attack.ToString();
            baseDefenseLabel.Text = PokemonData.AllBaseStats[pokemonNumber].Defense.ToString();
            baseSpecialLabel.Text = PokemonData.AllBaseStats[pokemonNumber].Special.ToString();
            baseSpeedLabel.Text = PokemonData.AllBaseStats[pokemonNumber].Speed.ToString();
        }

        private void LoadSprite()
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

        private int GetPokemonNumber()
        {
            for (int i = 0; i < 151; i++)
                if (pokemonDropDown.Text == PokemonData.Species[i])
                    return i + 1;
            return 1;
        }

        private int GetPokemonNumberFromKOedList()
        {
            for (int i = 0; i < 151; i++)
                if (koedPokemonDropDown.Text == PokemonData.Species[i])
                    return i + 1;
            return 1;
        }


        private void UpdateYourPokemonDropDown()
        {
            yourPokemonDropDown.Items.Clear();
            yourPokemonDropDown.Items.AddRange(GetYourPokemonNames());
        }

        private string[] GetYourPokemonNames()
        {
            string[] output = new string[yourPokemon.Count];
            int length = output.Length;
            for (int i = 0; i < length; i++)
            {
                output[i] = yourPokemon[i].species;
                if (yourPokemon[i].nickname != "")
                    output[i] += " - " + yourPokemon[i].nickname;
            }
            return output;
        }

        private void LoadSavedPokemon()
        {
            if (File.Exists(@".\\save\\save.bin"))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@".\\save\\save.bin",
                                          FileMode.Open,
                                          FileAccess.Read,
                                          FileShare.Read);
                SaveData save = (SaveData)formatter.Deserialize(stream);
                stream.Close();
                yourPokemon = save.savedPokemon;
            }
            else
                yourPokemon = new List<SaveData.Pokemon>(151);
        }

        private void SaveYourPokemonToFile()
        {
            SaveData save = new SaveData();
            save.savedPokemon = yourPokemon;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@".\\save\\save.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, save);
            stream.Close();
        }


    }
}
