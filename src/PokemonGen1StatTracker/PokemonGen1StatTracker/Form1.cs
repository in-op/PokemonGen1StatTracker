using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PokemonGen1StatTracker
{
    public partial class StatTrackerForm : Form
    {
        private List<PokemonDTO> yourPokemon;
        private Dictionary<string, PokemonDTO> nameStringToPokemon;

        public StatTrackerForm()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            yourPokemon = SaveFile.Load();
            RefreshSavedPokemonDropdown();

            pokemonDropDown.Items.AddRange(Pokemon.Species);
            koedPokemonDropDown.Items.AddRange(Pokemon.Species);
            vitaminDropDown.Items.AddRange(Pokemon.Vitamins);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string name = GetSaveNameOfCurrentPokemon();
            string[] names = GetYourPokemonNames();
            for (int i = 0; i < yourPokemon.Count; i++)
                if (name == GetSaveName(yourPokemon[i]))
                    yourPokemon.Remove(yourPokemon[i]);
            SaveFile.Save(yourPokemon);
            RefreshSavedPokemonDropdown();
        }
        private void savePokemonButton_Click(object sender, EventArgs e)
        {
            AddOrUpdatePokemonToList();
            SaveFile.Save(yourPokemon);
            RefreshSavedPokemonDropdown();
        }
        private void addExpFromVitaminButton_Click(object sender, EventArgs e)
        {
            string vitamin = vitaminDropDown.Text;

            float.TryParse(hpExpLabel.Text, out float hpExp);
            float.TryParse(attackExpLabel.Text, out float atkExp);
            float.TryParse(defenseExpLabel.Text, out float defExp);
            float.TryParse(specialExpLabel.Text, out float spcExp);
            float.TryParse(speedExpLabel.Text, out float spdExp);

            switch (vitamin)
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

            var baseStats = Pokemon.AllBaseStats[pokemonNumber];

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

            int minHP = StatCalculator.MinHPDV(hp, lvl, hpExp, Pokemon.AllBaseStats[pokemonNumber].HP);
            int maxHP = StatCalculator.MaxHPDV(hp, lvl, hpExp, Pokemon.AllBaseStats[pokemonNumber].HP);
            int minAttack = StatCalculator.MinNonHPDV(atk, lvl, atkExp, Pokemon.AllBaseStats[pokemonNumber].Attack);
            int maxAttack = StatCalculator.MaxNonHPDV(atk, lvl, atkExp, Pokemon.AllBaseStats[pokemonNumber].Attack);
            int minDefense = StatCalculator.MinNonHPDV(def, lvl, defExp, Pokemon.AllBaseStats[pokemonNumber].Defense);
            int maxDefense = StatCalculator.MaxNonHPDV(def, lvl, defExp, Pokemon.AllBaseStats[pokemonNumber].Defense);
            int minSpecial = StatCalculator.MinNonHPDV(spc, lvl, spcExp, Pokemon.AllBaseStats[pokemonNumber].Special);
            int maxSpecial = StatCalculator.MaxNonHPDV(spc, lvl, spcExp, Pokemon.AllBaseStats[pokemonNumber].Special);
            int minSpeed = StatCalculator.MinNonHPDV(spd, lvl, spdExp, Pokemon.AllBaseStats[pokemonNumber].Speed);
            int maxSpeed = StatCalculator.MaxNonHPDV(spd, lvl, spdExp, Pokemon.AllBaseStats[pokemonNumber].Speed);

            if (minHP < 0) minHP = 0;
            if (maxHP > 15) maxHP = 15;
            if (minAttack < 0) minAttack = 0;
            if (maxAttack > 15) maxAttack = 15;
            if (minDefense < 0) minDefense = 0;
            if (maxDefense > 15) maxDefense = 15;
            if (minSpecial < 0) minSpecial = 0;
            if (maxSpecial > 15) maxSpecial = 15;
            if (minSpeed < 0) minSpeed = 0;
            if (maxSpeed > 15) maxSpeed = 15;

            hpIvLabel.Text = (minHP == maxHP) ? minHP.ToString() : minHP + "-" + maxHP;
            attackIvLabel.Text = (minAttack == maxAttack) ? minAttack.ToString() : minAttack + "-" + maxAttack;
            defenseIvLabel.Text = (minDefense == maxDefense) ? minDefense.ToString() : minDefense + "-" + maxDefense;
            specialIvLabel.Text = (minSpecial == maxSpecial) ? minSpecial.ToString() : minSpecial + "-" + maxSpecial;
            speedIvLabel.Text = (minSpeed == maxSpeed) ? minSpeed.ToString() : minSpeed + "-" + maxSpeed;
        }




        private void savedPokemonDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySavedPokemonInfo(GetCurrentlySelectedSavedPokemon());
        }

        private void DisplaySavedPokemonInfo(PokemonDTO pokemon)
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
                PokemonDTO pokemon =
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
                yourPokemon.Add(new PokemonDTO()
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
            type1Label.Text = Util.ToString(Pokemon.AllTypes[pokemonNumber][0]);
            type2Label.Text = Util.ToString(Pokemon.AllTypes[pokemonNumber][1]);
        }

        private void DisplayBaseStats(int pokemonNumber)
        {
            baseHpLabel.Text = Pokemon.AllBaseStats[pokemonNumber].HP.ToString();
            baseAttackLabel.Text = Pokemon.AllBaseStats[pokemonNumber].Attack.ToString();
            baseDefenseLabel.Text = Pokemon.AllBaseStats[pokemonNumber].Defense.ToString();
            baseSpecialLabel.Text = Pokemon.AllBaseStats[pokemonNumber].Special.ToString();
            baseSpeedLabel.Text = Pokemon.AllBaseStats[pokemonNumber].Speed.ToString();
        }

        private void LoadSprite()
        {
            spriteBox.Load(".\\img\\" + pokemonDropDown.Text + ".png");
        }

        private int GetPokemonNumber()
        {
            for (int i = 0; i < 151; i++)
                if (pokemonDropDown.Text == Pokemon.Species[i])
                    return i + 1;
            return 1;
        }

        private int GetPokemonNumberFromKOedList()
        {
            for (int i = 0; i < 151; i++)
                if (koedPokemonDropDown.Text == Pokemon.Species[i])
                    return i + 1;
            return 0;
        }



        private PokemonDTO GetCurrentlySelectedSavedPokemon()
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


        private void RefreshSavedPokemonDropdown()
        {
            yourPokemonDropDown.Items.Clear();
            yourPokemonDropDown.Items.AddRange(GetYourPokemonNames());
        }

        private string[] GetYourPokemonNames()
        {
            int length = yourPokemon.Count;
            string[] output = new string[length];

            for (int i = 0; i < length; i++)
            {
                output[i] = yourPokemon[i].species;
                if (yourPokemon[i].nickname != "")
                    output[i] += " - " + yourPokemon[i].nickname;
            }
            return output;
        }


        private string GetSaveName(PokemonDTO pokemon)
        {
            string output = pokemon.species;
            if (pokemon.nickname != "")
                output += " - " + pokemon.nickname;
            return output;
        }




    }
}
