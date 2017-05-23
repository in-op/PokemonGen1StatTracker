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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PokemonGen1StatTracker
{
    public partial class StatTrackerForm : Form
    {
        private List<SaveData.Pokemon> yourPokemon;

        public StatTrackerForm()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(@"..\..");
            LoadSavedPokemonList();
            InitializeDropDowns();
        }

        

        private void InitializeDropDowns()
        {
            pokemonDropDown.Items.AddRange(PokemonData.Species);
            koedPokemonDropDown.Items.AddRange(PokemonData.Species);
            RefreshSavedPokemonDropdown();
            vitaminDropDown.Items.AddRange(PokemonData.Vitamins);
        }


        private void savePokemonButton_Click(object sender, EventArgs e)
        {
            AddOrUpdatePokemonToList();
            SavePokemonListToFile();
            RefreshSavedPokemonDropdown();
        }

        private SaveData.Pokemon GetCurrentlySelectedSavedPokemon()
        {
            string name = yourPokemonDropDown.Text;
            string[] names = GetYourPokemonNames();
            int index = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    index = i;
                    break;
                }
            }
            return yourPokemon[index];
        }


        private void savedPokemonDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySavedPokemonInfo(
                GetCurrentlySelectedSavedPokemon());
        }

        private void DisplaySavedPokemonInfo(SaveData.Pokemon pokemon)
        {
            pokemonDropDown.Text = pokemon.species;
            nicknameInput.Text = pokemon.nickname;
            levelInput.Text = pokemon.level;

            hpTextBox.Text = pokemon.hpStat;
            attackTextBox.Text = pokemon.attackStat;
            defenseTextBox.Text = pokemon.defenseStat;
            specialTextBox.Text = pokemon.specialStat;
            speedTextBox.Text = pokemon.speedStat;

            hpExpLabel.Text = pokemon.hpExp;
            attackExpLabel.Text = pokemon.attackExp;
            defenseExpLabel.Text = pokemon.defenseExp;
            specialExpLabel.Text = pokemon.specialExp;
            speedExpLabel.Text = pokemon.speedExp;
        }


        private string GetSaveNameOfCurrentPokemon()
        {
            string name = pokemonDropDown.Text;
            if (nicknameInput.Text != "")
                name += " - " + nicknameInput.Text;
            return name;
        }


        private void AddOrUpdatePokemonToList()
        {
            string[] names = GetYourPokemonNames();
            string name = GetSaveNameOfCurrentPokemon();

            if (names.Contains(name)) //update
            {
                SaveData.Pokemon pokemon =
                    yourPokemon[Array.IndexOf(names, name)];

                pokemon.level = levelInput.Text;
                pokemon.hpStat = hpTextBox.Text;

                pokemon.hpStat = hpTextBox.Text;
                pokemon.attackStat = attackTextBox.Text;
                pokemon.defenseStat = defenseTextBox.Text;
                pokemon.specialStat = specialTextBox.Text;
                pokemon.speedStat = speedTextBox.Text;

                pokemon.hpExp = hpExpLabel.Text;
                pokemon.attackExp = attackExpLabel.Text;
                pokemon.defenseExp = defenseExpLabel.Text;
                pokemon.specialExp = specialExpLabel.Text;
                pokemon.speedExp = speedExpLabel.Text;
            }
            else //add
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

                    hpExp = hpExpLabel.Text,
                    attackExp = attackExpLabel.Text,
                    defenseExp = defenseExpLabel.Text,
                    specialExp = specialExpLabel.Text,
                    speedExp = speedExpLabel.Text
                });
            }
            
        }

        private void addExpFromVitaminButton_Click(object sender, EventArgs e)
        {
            string vitamin = vitaminDropDown.Text;

            float.TryParse(hpExpLabel.Text, out float hpExp);
            float.TryParse(attackExpLabel.Text, out float atkExp);
            float.TryParse(defenseExpLabel.Text, out float defExp);
            float.TryParse(specialExpLabel.Text, out float spcExp);
            float.TryParse(speedExpLabel.Text, out float spdExp);

            switch(vitamin)
            {
                case "HP Up":
                    if (hpExp < 25600f)
                    {
                        hpExp += 2560f;
                        if (hpExp > 25600f)
                            hpExp = 25600f;
                    }
                    break;
                case "Protein":
                    if (atkExp < 25600f)
                    {
                        atkExp += 2560f;
                        if (atkExp > 25600f)
                            atkExp = 25600f;
                    }
                    break;
                case "Iron":
                    if (defExp < 25600f)
                    {
                        defExp += 2560f;
                        if (defExp > 25600f)
                            defExp = 25600f;
                    }
                    break;
                case "Calcium":
                    if (spcExp < 25600f)
                    {
                        spcExp += 2560f;
                        if (spcExp > 25600f)
                            spcExp = 25600f;
                    }
                    break;
                case "Carbos":
                    if (spdExp < 25600f)
                    {
                        spdExp += 2560f;
                        if (spdExp > 25600f)
                            spdExp = 25600f;
                    }
                    break;
            }

            hpExpLabel.Text = hpExp.ToString();
            attackExpLabel.Text = atkExp.ToString();
            defenseExpLabel.Text = defExp.ToString();
            specialExpLabel.Text = spcExp.ToString();
            speedExpLabel.Text = spdExp.ToString();
        }

        private void addExpFromDefeatingPokemonButton_Click(object sender, EventArgs e)
        {
            int pokemonNumber = GetPokemonNumberFromKOedList();
            if (pokemonNumber == 0) return;

            var baseStats = PokemonData.AllBaseStats[pokemonNumber];

            float.TryParse(hpExpLabel.Text, out float hpExp);
            float.TryParse(attackExpLabel.Text, out float atkExp);
            float.TryParse(defenseExpLabel.Text, out float defExp);
            float.TryParse(specialExpLabel.Text, out float spcExp);
            float.TryParse(speedExpLabel.Text, out float spdExp);
            
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

            hpExpLabel.Text = hpExp.ToString();
            attackExpLabel.Text = atkExp.ToString();
            defenseExpLabel.Text = defExp.ToString();
            specialExpLabel.Text = spcExp.ToString();
            speedExpLabel.Text = spdExp.ToString();
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

            float.TryParse(hpExpLabel.Text, out float hpExp);
            float.TryParse(attackExpLabel.Text, out float atkExp);
            float.TryParse(defenseExpLabel.Text, out float defExp);
            float.TryParse(specialExpLabel.Text, out float spcExp);
            float.TryParse(speedExpLabel.Text, out float spdExp);

            hpExp = StatCalculator.StatExp(hpExp);
            atkExp = StatCalculator.StatExp(atkExp);
            defExp = StatCalculator.StatExp(defExp);
            spcExp = StatCalculator.StatExp(spcExp);
            spdExp = StatCalculator.StatExp(spdExp);

            int minHP = StatCalculator.MinHPDV(hp, lvl, hpExp, PokemonData.AllBaseStats[pokemonNumber].HP);
            int maxHP = StatCalculator.MaxHPDV(hp, lvl, hpExp, PokemonData.AllBaseStats[pokemonNumber].HP);
            int minAttack = StatCalculator.MinNonHPDV(atk, lvl, atkExp, PokemonData.AllBaseStats[pokemonNumber].Attack);
            int maxAttack = StatCalculator.MaxNonHPDV(atk, lvl, atkExp, PokemonData.AllBaseStats[pokemonNumber].Attack);
            int minDefense = StatCalculator.MinNonHPDV(def, lvl, defExp, PokemonData.AllBaseStats[pokemonNumber].Defense);
            int maxDefense = StatCalculator.MaxNonHPDV(def, lvl, defExp, PokemonData.AllBaseStats[pokemonNumber].Defense);
            int minSpecial = StatCalculator.MinNonHPDV(spc, lvl, spcExp, PokemonData.AllBaseStats[pokemonNumber].Special);
            int maxSpecial = StatCalculator.MaxNonHPDV(spc, lvl, spcExp, PokemonData.AllBaseStats[pokemonNumber].Special);
            int minSpeed = StatCalculator.MinNonHPDV(spd, lvl, spdExp, PokemonData.AllBaseStats[pokemonNumber].Speed);
            int maxSpeed = StatCalculator.MaxNonHPDV(spd, lvl, spdExp, PokemonData.AllBaseStats[pokemonNumber].Speed);

            hpIvLabel.Text = (minHP == maxHP) ? minHP.ToString() : minHP + "-" + maxHP;
            attackIvLabel.Text = (minAttack == maxAttack) ? minAttack.ToString() : minAttack + "-" + maxAttack;
            defenseIvLabel.Text = (minDefense == maxDefense) ? minDefense.ToString() : minDefense + "-" + maxDefense;
            specialIvLabel.Text = (minSpecial == maxSpecial) ? minSpecial.ToString() : minSpecial + "-" + maxSpecial;
            speedIvLabel.Text = (minSpeed == maxSpeed) ? minSpeed.ToString() : minSpeed + "-" + maxSpeed;
        }

        private void pokemonDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSprite();
            RemoveInfo();
            DisplayInfo();
        }
        private void RemoveInfo()
        {
            hpTextBox.Text = "";
            attackTextBox.Text = "";
            defenseTextBox.Text = "";
            specialTextBox.Text = "";
            speedTextBox.Text = "";

            hpExpLabel.Text = "0";
            attackExpLabel.Text = "0";
            defenseExpLabel.Text = "0";
            specialExpLabel.Text = "0";
            speedExpLabel.Text = "0";

            hpIvLabel.Text = "";
            attackIvLabel.Text = "";
            defenseIvLabel.Text = "";
            specialIvLabel.Text = "";
            speedIvLabel.Text = "";

            levelInput.Text = "";
            nicknameInput.Text = "";
        }

        private void DisplayInfo()
        {
            int pokemonNumber = GetPokemonNumber();
            DisplayNumber(pokemonNumber);
            DisplayTypes(pokemonNumber);
            DisplayBaseStats(pokemonNumber);
        }

        private void DisplayNumber(int pokemonNumber)
        {
            numberDisplayLabel.Text = pokemonNumber.ToString();
        }

        private void DisplayTypes(int pokemonNumber)
        {
            type1Label.Text = PokemonData.TypeToString(PokemonData.AllTypes[pokemonNumber][0]);
            type2Label.Text = PokemonData.TypeToString(PokemonData.AllTypes[pokemonNumber][1]);
        }

        private void DisplayBaseStats(int pokemonNumber)
        {
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
            return 0;
        }


        private void RefreshSavedPokemonDropdown()
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

        private void LoadSavedPokemonList()
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

        private void SavePokemonListToFile()
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
