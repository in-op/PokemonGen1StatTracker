namespace PokemonGen1StatTracker
{
    partial class StatTrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.levelLabel = new System.Windows.Forms.Label();
            this.pokemonDropDown = new System.Windows.Forms.ComboBox();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.nicknameInput = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.savePokemonButton = new System.Windows.Forms.Button();
            this.yourPokemonDropDown = new System.Windows.Forms.ComboBox();
            this.savedPokemonLabel = new System.Windows.Forms.Label();
            this.addExpButton = new System.Windows.Forms.Button();
            this.koedPokemonDropDown = new System.Windows.Forms.ComboBox();
            this.calcDVsButton = new System.Windows.Forms.Button();
            this.baseSpeedLabel = new System.Windows.Forms.Label();
            this.baseSpecialLabel = new System.Windows.Forms.Label();
            this.baseDefenseLabel = new System.Windows.Forms.Label();
            this.baseAttackLabel = new System.Windows.Forms.Label();
            this.baseHpLabel = new System.Windows.Forms.Label();
            this.speedExpInput = new System.Windows.Forms.TextBox();
            this.specialExpInput = new System.Windows.Forms.TextBox();
            this.defenseExpInput = new System.Windows.Forms.TextBox();
            this.attackExpInput = new System.Windows.Forms.TextBox();
            this.hpExpInput = new System.Windows.Forms.TextBox();
            this.statExpLabel = new System.Windows.Forms.Label();
            this.specialIvLabel = new System.Windows.Forms.Label();
            this.speedIvLabel = new System.Windows.Forms.Label();
            this.defenseIvLabel = new System.Windows.Forms.Label();
            this.attackIvLabel = new System.Windows.Forms.Label();
            this.hpIvLabel = new System.Windows.Forms.Label();
            this.ivLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.specialTextBox = new System.Windows.Forms.TextBox();
            this.defenseTextBox = new System.Windows.Forms.TextBox();
            this.attackTextBox = new System.Windows.Forms.TextBox();
            this.hpTextBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.specialLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.attackLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.levelInput = new System.Windows.Forms.TextBox();
            this.spriteBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numberHeaderLabel = new System.Windows.Forms.Label();
            this.numberDisplayLabel = new System.Windows.Forms.Label();
            this.typesLabel = new System.Windows.Forms.Label();
            this.type1Label = new System.Windows.Forms.Label();
            this.type2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spriteBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(272, 134);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(46, 17);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "Level:";
            // 
            // pokemonDropDown
            // 
            this.pokemonDropDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.pokemonDropDown, 2);
            this.pokemonDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokemonDropDown.FormattingEnabled = true;
            this.pokemonDropDown.Location = new System.Drawing.Point(357, 9);
            this.pokemonDropDown.Name = "pokemonDropDown";
            this.pokemonDropDown.Size = new System.Drawing.Size(130, 24);
            this.pokemonDropDown.TabIndex = 1;
            this.pokemonDropDown.SelectedIndexChanged += new System.EventHandler(this.pokemonDropDown_SelectedIndexChanged);
            // 
            // speciesLabel
            // 
            this.speciesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(264, 13);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(62, 17);
            this.speciesLabel.TabIndex = 2;
            this.speciesLabel.Text = "Species:";
            // 
            // nicknameInput
            // 
            this.nicknameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nicknameInput.Location = new System.Drawing.Point(711, 11);
            this.nicknameInput.Name = "nicknameInput";
            this.nicknameInput.Size = new System.Drawing.Size(112, 22);
            this.nicknameInput.TabIndex = 38;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(612, 13);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(74, 17);
            this.nicknameLabel.TabIndex = 37;
            this.nicknameLabel.Text = "Nickname:";
            // 
            // savePokemonButton
            // 
            this.savePokemonButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.savePokemonButton, 2);
            this.savePokemonButton.Location = new System.Drawing.Point(829, 86);
            this.savePokemonButton.Name = "savePokemonButton";
            this.savePokemonButton.Size = new System.Drawing.Size(186, 34);
            this.savePokemonButton.TabIndex = 41;
            this.savePokemonButton.Text = "Save Pokemon";
            this.savePokemonButton.UseVisualStyleBackColor = true;
            this.savePokemonButton.Click += new System.EventHandler(this.addToYourPokemonButton_Click);
            // 
            // yourPokemonDropDown
            // 
            this.yourPokemonDropDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.yourPokemonDropDown, 2);
            this.yourPokemonDropDown.DropDownHeight = 300;
            this.yourPokemonDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yourPokemonDropDown.FormattingEnabled = true;
            this.yourPokemonDropDown.IntegralHeight = false;
            this.yourPokemonDropDown.Location = new System.Drawing.Point(947, 176);
            this.yourPokemonDropDown.Name = "yourPokemonDropDown";
            this.yourPokemonDropDown.Size = new System.Drawing.Size(200, 24);
            this.yourPokemonDropDown.TabIndex = 40;
            // 
            // savedPokemonLabel
            // 
            this.savedPokemonLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.savedPokemonLabel.AutoSize = true;
            this.savedPokemonLabel.Location = new System.Drawing.Point(849, 171);
            this.savedPokemonLabel.Name = "savedPokemonLabel";
            this.savedPokemonLabel.Size = new System.Drawing.Size(71, 34);
            this.savedPokemonLabel.TabIndex = 39;
            this.savedPokemonLabel.Text = "Saved Pokemon:";
            // 
            // addExpButton
            // 
            this.addExpButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.SetColumnSpan(this.addExpButton, 2);
            this.addExpButton.Location = new System.Drawing.Point(47, 479);
            this.addExpButton.Name = "addExpButton";
            this.addExpButton.Size = new System.Drawing.Size(186, 34);
            this.addExpButton.TabIndex = 1;
            this.addExpButton.Text = "Add exp from defeating:";
            this.addExpButton.UseVisualStyleBackColor = true;
            this.addExpButton.Click += new System.EventHandler(this.addExpButton_Click);
            // 
            // koedPokemonDropDown
            // 
            this.koedPokemonDropDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.koedPokemonDropDown, 2);
            this.koedPokemonDropDown.DropDownHeight = 180;
            this.koedPokemonDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.koedPokemonDropDown.FormattingEnabled = true;
            this.koedPokemonDropDown.IntegralHeight = false;
            this.koedPokemonDropDown.Location = new System.Drawing.Point(239, 483);
            this.koedPokemonDropDown.Name = "koedPokemonDropDown";
            this.koedPokemonDropDown.Size = new System.Drawing.Size(130, 24);
            this.koedPokemonDropDown.TabIndex = 36;
            // 
            // calcDVsButton
            // 
            this.calcDVsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.calcDVsButton, 2);
            this.calcDVsButton.Location = new System.Drawing.Point(51, 637);
            this.calcDVsButton.Name = "calcDVsButton";
            this.calcDVsButton.Size = new System.Drawing.Size(133, 35);
            this.calcDVsButton.TabIndex = 17;
            this.calcDVsButton.Text = "Calculate DVs";
            this.calcDVsButton.UseVisualStyleBackColor = true;
            this.calcDVsButton.Click += new System.EventHandler(this.calcStatsButton_Click);
            // 
            // baseSpeedLabel
            // 
            this.baseSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseSpeedLabel.AutoSize = true;
            this.baseSpeedLabel.Location = new System.Drawing.Point(643, 411);
            this.baseSpeedLabel.Name = "baseSpeedLabel";
            this.baseSpeedLabel.Size = new System.Drawing.Size(12, 17);
            this.baseSpeedLabel.TabIndex = 30;
            this.baseSpeedLabel.Text = " ";
            // 
            // baseSpecialLabel
            // 
            this.baseSpecialLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseSpecialLabel.AutoSize = true;
            this.baseSpecialLabel.Location = new System.Drawing.Point(525, 411);
            this.baseSpecialLabel.Name = "baseSpecialLabel";
            this.baseSpecialLabel.Size = new System.Drawing.Size(12, 17);
            this.baseSpecialLabel.TabIndex = 34;
            this.baseSpecialLabel.Text = " ";
            // 
            // baseDefenseLabel
            // 
            this.baseDefenseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseDefenseLabel.AutoSize = true;
            this.baseDefenseLabel.Location = new System.Drawing.Point(407, 411);
            this.baseDefenseLabel.Name = "baseDefenseLabel";
            this.baseDefenseLabel.Size = new System.Drawing.Size(12, 17);
            this.baseDefenseLabel.TabIndex = 31;
            this.baseDefenseLabel.Text = " ";
            // 
            // baseAttackLabel
            // 
            this.baseAttackLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseAttackLabel.AutoSize = true;
            this.baseAttackLabel.Location = new System.Drawing.Point(289, 411);
            this.baseAttackLabel.Name = "baseAttackLabel";
            this.baseAttackLabel.Size = new System.Drawing.Size(12, 17);
            this.baseAttackLabel.TabIndex = 33;
            this.baseAttackLabel.Text = " ";
            // 
            // baseHpLabel
            // 
            this.baseHpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseHpLabel.AutoSize = true;
            this.baseHpLabel.Location = new System.Drawing.Point(171, 411);
            this.baseHpLabel.Name = "baseHpLabel";
            this.baseHpLabel.Size = new System.Drawing.Size(12, 17);
            this.baseHpLabel.TabIndex = 32;
            this.baseHpLabel.Text = " ";
            // 
            // speedExpInput
            // 
            this.speedExpInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedExpInput.Location = new System.Drawing.Point(599, 321);
            this.speedExpInput.Name = "speedExpInput";
            this.speedExpInput.Size = new System.Drawing.Size(100, 22);
            this.speedExpInput.TabIndex = 25;
            this.speedExpInput.Text = "0";
            // 
            // specialExpInput
            // 
            this.specialExpInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialExpInput.Location = new System.Drawing.Point(481, 321);
            this.specialExpInput.Name = "specialExpInput";
            this.specialExpInput.Size = new System.Drawing.Size(100, 22);
            this.specialExpInput.TabIndex = 29;
            this.specialExpInput.Text = "0";
            // 
            // defenseExpInput
            // 
            this.defenseExpInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defenseExpInput.Location = new System.Drawing.Point(363, 321);
            this.defenseExpInput.Name = "defenseExpInput";
            this.defenseExpInput.Size = new System.Drawing.Size(100, 22);
            this.defenseExpInput.TabIndex = 27;
            this.defenseExpInput.Text = "0";
            // 
            // attackExpInput
            // 
            this.attackExpInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attackExpInput.Location = new System.Drawing.Point(245, 321);
            this.attackExpInput.Name = "attackExpInput";
            this.attackExpInput.Size = new System.Drawing.Size(100, 22);
            this.attackExpInput.TabIndex = 28;
            this.attackExpInput.Text = "0";
            // 
            // hpExpInput
            // 
            this.hpExpInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hpExpInput.Location = new System.Drawing.Point(127, 321);
            this.hpExpInput.Name = "hpExpInput";
            this.hpExpInput.Size = new System.Drawing.Size(100, 22);
            this.hpExpInput.TabIndex = 26;
            this.hpExpInput.Text = "0";
            // 
            // statExpLabel
            // 
            this.statExpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statExpLabel.AutoSize = true;
            this.statExpLabel.Location = new System.Drawing.Point(27, 324);
            this.statExpLabel.Name = "statExpLabel";
            this.statExpLabel.Size = new System.Drawing.Size(64, 17);
            this.statExpLabel.TabIndex = 24;
            this.statExpLabel.Text = "Stat Exp:";
            // 
            // specialIvLabel
            // 
            this.specialIvLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialIvLabel.AutoSize = true;
            this.specialIvLabel.Location = new System.Drawing.Point(525, 368);
            this.specialIvLabel.Name = "specialIvLabel";
            this.specialIvLabel.Size = new System.Drawing.Size(12, 17);
            this.specialIvLabel.TabIndex = 21;
            this.specialIvLabel.Text = " ";
            // 
            // speedIvLabel
            // 
            this.speedIvLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedIvLabel.AutoSize = true;
            this.speedIvLabel.Location = new System.Drawing.Point(643, 368);
            this.speedIvLabel.Name = "speedIvLabel";
            this.speedIvLabel.Size = new System.Drawing.Size(12, 17);
            this.speedIvLabel.TabIndex = 22;
            this.speedIvLabel.Text = " ";
            // 
            // defenseIvLabel
            // 
            this.defenseIvLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defenseIvLabel.AutoSize = true;
            this.defenseIvLabel.Location = new System.Drawing.Point(407, 368);
            this.defenseIvLabel.Name = "defenseIvLabel";
            this.defenseIvLabel.Size = new System.Drawing.Size(12, 17);
            this.defenseIvLabel.TabIndex = 20;
            this.defenseIvLabel.Text = " ";
            // 
            // attackIvLabel
            // 
            this.attackIvLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attackIvLabel.AutoSize = true;
            this.attackIvLabel.Location = new System.Drawing.Point(289, 368);
            this.attackIvLabel.Name = "attackIvLabel";
            this.attackIvLabel.Size = new System.Drawing.Size(12, 17);
            this.attackIvLabel.TabIndex = 19;
            this.attackIvLabel.Text = " ";
            // 
            // hpIvLabel
            // 
            this.hpIvLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hpIvLabel.AutoSize = true;
            this.hpIvLabel.Location = new System.Drawing.Point(171, 368);
            this.hpIvLabel.Name = "hpIvLabel";
            this.hpIvLabel.Size = new System.Drawing.Size(12, 17);
            this.hpIvLabel.TabIndex = 18;
            this.hpIvLabel.Text = " ";
            // 
            // ivLabel
            // 
            this.ivLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ivLabel.AutoSize = true;
            this.ivLabel.Location = new System.Drawing.Point(40, 368);
            this.ivLabel.Name = "ivLabel";
            this.ivLabel.Size = new System.Drawing.Size(38, 17);
            this.ivLabel.TabIndex = 16;
            this.ivLabel.Text = "DVs:";
            // 
            // baseLabel
            // 
            this.baseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(19, 411);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(80, 17);
            this.baseLabel.TabIndex = 23;
            this.baseLabel.Text = "Base Stats:";
            // 
            // statsLabel
            // 
            this.statsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statsLabel.AutoSize = true;
            this.statsLabel.Location = new System.Drawing.Point(37, 275);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(44, 17);
            this.statsLabel.TabIndex = 15;
            this.statsLabel.Text = "Stats:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedTextBox.Location = new System.Drawing.Point(599, 272);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 22);
            this.speedTextBox.TabIndex = 10;
            // 
            // specialTextBox
            // 
            this.specialTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialTextBox.Location = new System.Drawing.Point(481, 272);
            this.specialTextBox.Name = "specialTextBox";
            this.specialTextBox.Size = new System.Drawing.Size(100, 22);
            this.specialTextBox.TabIndex = 9;
            // 
            // defenseTextBox
            // 
            this.defenseTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defenseTextBox.Location = new System.Drawing.Point(363, 272);
            this.defenseTextBox.Name = "defenseTextBox";
            this.defenseTextBox.Size = new System.Drawing.Size(100, 22);
            this.defenseTextBox.TabIndex = 8;
            // 
            // attackTextBox
            // 
            this.attackTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attackTextBox.Location = new System.Drawing.Point(245, 272);
            this.attackTextBox.Name = "attackTextBox";
            this.attackTextBox.Size = new System.Drawing.Size(100, 22);
            this.attackTextBox.TabIndex = 7;
            // 
            // hpTextBox
            // 
            this.hpTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hpTextBox.Location = new System.Drawing.Point(127, 272);
            this.hpTextBox.Name = "hpTextBox";
            this.hpTextBox.Size = new System.Drawing.Size(100, 22);
            this.hpTextBox.TabIndex = 6;
            // 
            // speedLabel
            // 
            this.speedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(624, 228);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(49, 17);
            this.speedLabel.TabIndex = 14;
            this.speedLabel.Text = "Speed";
            // 
            // specialLabel
            // 
            this.specialLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialLabel.AutoSize = true;
            this.specialLabel.Location = new System.Drawing.Point(504, 228);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(54, 17);
            this.specialLabel.TabIndex = 13;
            this.specialLabel.Text = "Special";
            // 
            // defenseLabel
            // 
            this.defenseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(382, 228);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(61, 17);
            this.defenseLabel.TabIndex = 12;
            this.defenseLabel.Text = "Defense";
            // 
            // attackLabel
            // 
            this.attackLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(271, 228);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(47, 17);
            this.attackLabel.TabIndex = 11;
            this.attackLabel.Text = "Attack";
            // 
            // hpLabel
            // 
            this.hpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(163, 228);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(27, 17);
            this.hpLabel.TabIndex = 5;
            this.hpLabel.Text = "HP";
            // 
            // levelInput
            // 
            this.levelInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelInput.Location = new System.Drawing.Point(394, 131);
            this.levelInput.Name = "levelInput";
            this.levelInput.Size = new System.Drawing.Size(38, 22);
            this.levelInput.TabIndex = 4;
            // 
            // spriteBox
            // 
            this.spriteBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.spriteBox, 2);
            this.spriteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spriteBox.Location = new System.Drawing.Point(3, 3);
            this.spriteBox.Name = "spriteBox";
            this.tableLayoutPanel1.SetRowSpan(this.spriteBox, 5);
            this.spriteBox.Size = new System.Drawing.Size(230, 209);
            this.spriteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spriteBox.TabIndex = 0;
            this.spriteBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.spriteBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hpLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.attackLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.defenseLabel, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.specialLabel, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.speedLabel, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.hpTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.attackTextBox, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.defenseTextBox, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.specialTextBox, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.speedTextBox, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.statsLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.baseLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.ivLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.hpIvLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.attackIvLabel, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.defenseIvLabel, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.speedIvLabel, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.specialIvLabel, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.statExpLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.hpExpInput, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.attackExpInput, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.defenseExpInput, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.specialExpInput, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.speedExpInput, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.baseHpLabel, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.baseAttackLabel, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.baseDefenseLabel, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.baseSpecialLabel, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.baseSpeedLabel, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.calcDVsButton, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.koedPokemonDropDown, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.addExpButton, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.savedPokemonLabel, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.yourPokemonDropDown, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.speciesLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pokemonDropDown, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.savePokemonButton, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberHeaderLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberDisplayLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.typesLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.type1Label, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.type2Label, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.nicknameLabel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.nicknameInput, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.levelLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.levelInput, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.78261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.04482F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.12849F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.73184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.776536F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numberHeaderLabel
            // 
            this.numberHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberHeaderLabel.AutoSize = true;
            this.numberHeaderLabel.Location = new System.Drawing.Point(280, 55);
            this.numberHeaderLabel.Name = "numberHeaderLabel";
            this.numberHeaderLabel.Size = new System.Drawing.Size(30, 17);
            this.numberHeaderLabel.TabIndex = 42;
            this.numberHeaderLabel.Text = "No:";
            // 
            // numberDisplayLabel
            // 
            this.numberDisplayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberDisplayLabel.AutoSize = true;
            this.numberDisplayLabel.Location = new System.Drawing.Point(407, 55);
            this.numberDisplayLabel.Name = "numberDisplayLabel";
            this.numberDisplayLabel.Size = new System.Drawing.Size(12, 17);
            this.numberDisplayLabel.TabIndex = 43;
            this.numberDisplayLabel.Text = " ";
            // 
            // typesLabel
            // 
            this.typesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typesLabel.AutoSize = true;
            this.typesLabel.Location = new System.Drawing.Point(269, 94);
            this.typesLabel.Name = "typesLabel";
            this.typesLabel.Size = new System.Drawing.Size(51, 17);
            this.typesLabel.TabIndex = 44;
            this.typesLabel.Text = "Types:";
            // 
            // type1Label
            // 
            this.type1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type1Label.AutoSize = true;
            this.type1Label.Location = new System.Drawing.Point(407, 94);
            this.type1Label.Name = "type1Label";
            this.type1Label.Size = new System.Drawing.Size(12, 17);
            this.type1Label.TabIndex = 45;
            this.type1Label.Text = " ";
            // 
            // type2Label
            // 
            this.type2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type2Label.AutoSize = true;
            this.type2Label.Location = new System.Drawing.Point(525, 94);
            this.type2Label.Name = "type2Label";
            this.type2Label.Size = new System.Drawing.Size(12, 17);
            this.type2Label.TabIndex = 46;
            this.type2Label.Text = " ";
            // 
            // StatTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StatTrackerForm";
            this.Text = "Pokemon Stat Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.spriteBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.ComboBox pokemonDropDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox spriteBox;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label specialLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox hpTextBox;
        private System.Windows.Forms.TextBox attackTextBox;
        private System.Windows.Forms.TextBox defenseTextBox;
        private System.Windows.Forms.TextBox specialTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label ivLabel;
        private System.Windows.Forms.Label hpIvLabel;
        private System.Windows.Forms.Label attackIvLabel;
        private System.Windows.Forms.Label defenseIvLabel;
        private System.Windows.Forms.Label speedIvLabel;
        private System.Windows.Forms.Label specialIvLabel;
        private System.Windows.Forms.Label statExpLabel;
        private System.Windows.Forms.TextBox hpExpInput;
        private System.Windows.Forms.TextBox attackExpInput;
        private System.Windows.Forms.TextBox defenseExpInput;
        private System.Windows.Forms.TextBox specialExpInput;
        private System.Windows.Forms.TextBox speedExpInput;
        private System.Windows.Forms.Label baseHpLabel;
        private System.Windows.Forms.Label baseAttackLabel;
        private System.Windows.Forms.Label baseDefenseLabel;
        private System.Windows.Forms.Label baseSpecialLabel;
        private System.Windows.Forms.Label baseSpeedLabel;
        private System.Windows.Forms.Button calcDVsButton;
        private System.Windows.Forms.ComboBox koedPokemonDropDown;
        private System.Windows.Forms.Button addExpButton;
        private System.Windows.Forms.Label savedPokemonLabel;
        private System.Windows.Forms.ComboBox yourPokemonDropDown;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.TextBox nicknameInput;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Button savePokemonButton;
        private System.Windows.Forms.TextBox levelInput;
        private System.Windows.Forms.Label numberHeaderLabel;
        private System.Windows.Forms.Label numberDisplayLabel;
        private System.Windows.Forms.Label typesLabel;
        private System.Windows.Forms.Label type1Label;
        private System.Windows.Forms.Label type2Label;
    }
}

