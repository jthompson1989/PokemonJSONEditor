namespace PokemonJSONEditor_WinForm
{
    partial class Add
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
            this.pokeDexAddBox = new System.Windows.Forms.GroupBox();
            this.btnSavePokedexEntry = new System.Windows.Forms.Button();
            this.txtPokedexEntry = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.versionDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pokeTypeBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPokeType = new System.Windows.Forms.TextBox();
            this.btnSavePokeType = new System.Windows.Forms.Button();
            this.weaknessBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeakness = new System.Windows.Forms.TextBox();
            this.btnSaveWeakness = new System.Windows.Forms.Button();
            this.abilitiesBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAbility = new System.Windows.Forms.TextBox();
            this.btnSaveAbility = new System.Windows.Forms.Button();
            this.captureLocationBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.locCapVersionDropDown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCaptureLocation = new System.Windows.Forms.TextBox();
            this.btnSaveCaptureLocation = new System.Windows.Forms.Button();
            this.evBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEVValue = new System.Windows.Forms.TextBox();
            this.evStatDropDown = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveEV = new System.Windows.Forms.Button();
            this.evolutionBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPokeIDEvolution = new System.Windows.Forms.TextBox();
            this.btnSaveEvolutions = new System.Windows.Forms.Button();
            this.pokeDexAddBox.SuspendLayout();
            this.pokeTypeBox.SuspendLayout();
            this.weaknessBox.SuspendLayout();
            this.abilitiesBox.SuspendLayout();
            this.captureLocationBox.SuspendLayout();
            this.evBox.SuspendLayout();
            this.evolutionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pokeDexAddBox
            // 
            this.pokeDexAddBox.Controls.Add(this.btnSavePokedexEntry);
            this.pokeDexAddBox.Controls.Add(this.txtPokedexEntry);
            this.pokeDexAddBox.Controls.Add(this.label2);
            this.pokeDexAddBox.Controls.Add(this.versionDropDown);
            this.pokeDexAddBox.Controls.Add(this.label1);
            this.pokeDexAddBox.Location = new System.Drawing.Point(12, 12);
            this.pokeDexAddBox.Name = "pokeDexAddBox";
            this.pokeDexAddBox.Size = new System.Drawing.Size(294, 237);
            this.pokeDexAddBox.TabIndex = 0;
            this.pokeDexAddBox.TabStop = false;
            this.pokeDexAddBox.Text = "Pokedex Entry";
            // 
            // btnSavePokedexEntry
            // 
            this.btnSavePokedexEntry.Location = new System.Drawing.Point(185, 195);
            this.btnSavePokedexEntry.Name = "btnSavePokedexEntry";
            this.btnSavePokedexEntry.Size = new System.Drawing.Size(75, 23);
            this.btnSavePokedexEntry.TabIndex = 4;
            this.btnSavePokedexEntry.Text = "Save";
            this.btnSavePokedexEntry.UseVisualStyleBackColor = true;
            this.btnSavePokedexEntry.Click += new System.EventHandler(this.btnSavePokedexEntry_Click);
            // 
            // txtPokedexEntry
            // 
            this.txtPokedexEntry.Location = new System.Drawing.Point(22, 73);
            this.txtPokedexEntry.Name = "txtPokedexEntry";
            this.txtPokedexEntry.Size = new System.Drawing.Size(238, 107);
            this.txtPokedexEntry.TabIndex = 3;
            this.txtPokedexEntry.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pokedex Entry";
            // 
            // versionDropDown
            // 
            this.versionDropDown.FormattingEnabled = true;
            this.versionDropDown.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Gold",
            "Silver",
            "Crystal",
            "Ruby",
            "Sapphire",
            "Emerald",
            "FireRed",
            "LeafGreen",
            "Pearl",
            "Diamond",
            "Platinum",
            "HeartGold",
            "SoulSilver",
            "Black",
            "White",
            "Black2",
            "White2",
            "X",
            "Y",
            "OmegaRuby",
            "AlphaSapphire",
            "Sun",
            "Moon",
            "UltraSun",
            "UltraMoon",
            "LetsGoEevee",
            "LetsGoPikachu",
            "Sword",
            "Shield",
            "BrilliandDiamond",
            "ShiningPearl",
            ""});
            this.versionDropDown.Location = new System.Drawing.Point(60, 21);
            this.versionDropDown.Name = "versionDropDown";
            this.versionDropDown.Size = new System.Drawing.Size(185, 23);
            this.versionDropDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game:";
            // 
            // pokeTypeBox
            // 
            this.pokeTypeBox.Controls.Add(this.label3);
            this.pokeTypeBox.Controls.Add(this.txtPokeType);
            this.pokeTypeBox.Controls.Add(this.btnSavePokeType);
            this.pokeTypeBox.Location = new System.Drawing.Point(323, 12);
            this.pokeTypeBox.Name = "pokeTypeBox";
            this.pokeTypeBox.Size = new System.Drawing.Size(294, 237);
            this.pokeTypeBox.TabIndex = 5;
            this.pokeTypeBox.TabStop = false;
            this.pokeTypeBox.Text = "Poke Types";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Poke Type:";
            // 
            // txtPokeType
            // 
            this.txtPokeType.Location = new System.Drawing.Point(97, 34);
            this.txtPokeType.Name = "txtPokeType";
            this.txtPokeType.Size = new System.Drawing.Size(182, 23);
            this.txtPokeType.TabIndex = 5;
            // 
            // btnSavePokeType
            // 
            this.btnSavePokeType.Location = new System.Drawing.Point(204, 73);
            this.btnSavePokeType.Name = "btnSavePokeType";
            this.btnSavePokeType.Size = new System.Drawing.Size(75, 23);
            this.btnSavePokeType.TabIndex = 4;
            this.btnSavePokeType.Text = "Save";
            this.btnSavePokeType.UseVisualStyleBackColor = true;
            this.btnSavePokeType.Click += new System.EventHandler(this.btnSavePokeType_Click);
            // 
            // weaknessBox
            // 
            this.weaknessBox.Controls.Add(this.label4);
            this.weaknessBox.Controls.Add(this.txtWeakness);
            this.weaknessBox.Controls.Add(this.btnSaveWeakness);
            this.weaknessBox.Location = new System.Drawing.Point(634, 12);
            this.weaknessBox.Name = "weaknessBox";
            this.weaknessBox.Size = new System.Drawing.Size(294, 237);
            this.weaknessBox.TabIndex = 7;
            this.weaknessBox.TabStop = false;
            this.weaknessBox.Text = "Weakness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Weakness:";
            // 
            // txtWeakness
            // 
            this.txtWeakness.Location = new System.Drawing.Point(97, 34);
            this.txtWeakness.Name = "txtWeakness";
            this.txtWeakness.Size = new System.Drawing.Size(182, 23);
            this.txtWeakness.TabIndex = 5;
            // 
            // btnSaveWeakness
            // 
            this.btnSaveWeakness.Location = new System.Drawing.Point(204, 73);
            this.btnSaveWeakness.Name = "btnSaveWeakness";
            this.btnSaveWeakness.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWeakness.TabIndex = 4;
            this.btnSaveWeakness.Text = "Save";
            this.btnSaveWeakness.UseVisualStyleBackColor = true;
            this.btnSaveWeakness.Click += new System.EventHandler(this.btnSaveWeakness_Click);
            // 
            // abilitiesBox
            // 
            this.abilitiesBox.Controls.Add(this.label5);
            this.abilitiesBox.Controls.Add(this.txtAbility);
            this.abilitiesBox.Controls.Add(this.btnSaveAbility);
            this.abilitiesBox.Location = new System.Drawing.Point(12, 279);
            this.abilitiesBox.Name = "abilitiesBox";
            this.abilitiesBox.Size = new System.Drawing.Size(294, 237);
            this.abilitiesBox.TabIndex = 8;
            this.abilitiesBox.TabStop = false;
            this.abilitiesBox.Text = "Abilities";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ability:";
            // 
            // txtAbility
            // 
            this.txtAbility.Location = new System.Drawing.Point(70, 34);
            this.txtAbility.Name = "txtAbility";
            this.txtAbility.Size = new System.Drawing.Size(209, 23);
            this.txtAbility.TabIndex = 5;
            // 
            // btnSaveAbility
            // 
            this.btnSaveAbility.Location = new System.Drawing.Point(204, 73);
            this.btnSaveAbility.Name = "btnSaveAbility";
            this.btnSaveAbility.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAbility.TabIndex = 4;
            this.btnSaveAbility.Text = "Save";
            this.btnSaveAbility.UseVisualStyleBackColor = true;
            this.btnSaveAbility.Click += new System.EventHandler(this.btnSaveAbility_Click);
            // 
            // captureLocationBox
            // 
            this.captureLocationBox.Controls.Add(this.label7);
            this.captureLocationBox.Controls.Add(this.locCapVersionDropDown);
            this.captureLocationBox.Controls.Add(this.label6);
            this.captureLocationBox.Controls.Add(this.txtCaptureLocation);
            this.captureLocationBox.Controls.Add(this.btnSaveCaptureLocation);
            this.captureLocationBox.Location = new System.Drawing.Point(323, 279);
            this.captureLocationBox.Name = "captureLocationBox";
            this.captureLocationBox.Size = new System.Drawing.Size(294, 237);
            this.captureLocationBox.TabIndex = 9;
            this.captureLocationBox.TabStop = false;
            this.captureLocationBox.Text = "Capture Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Locations:";
            // 
            // locCapVersionDropDown
            // 
            this.locCapVersionDropDown.FormattingEnabled = true;
            this.locCapVersionDropDown.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Gold",
            "Silver",
            "Crystal",
            "Ruby",
            "Sapphire",
            "Emerald",
            "FireRed",
            "LeafGreen",
            "Pearl",
            "Diamond",
            "Platinum",
            "HeartGold",
            "SoulSilver",
            "Black",
            "White",
            "Black2",
            "White2",
            "X",
            "Y",
            "OmegaRuby",
            "AlphaSapphire",
            "Sun",
            "Moon",
            "UltraSun",
            "UltraMoon",
            "LetsGoEevee",
            "LetsGoPikachu",
            "Sword",
            "Shield",
            "BrilliandDiamond",
            "ShiningPearl",
            ""});
            this.locCapVersionDropDown.Location = new System.Drawing.Point(75, 34);
            this.locCapVersionDropDown.Name = "locCapVersionDropDown";
            this.locCapVersionDropDown.Size = new System.Drawing.Size(185, 23);
            this.locCapVersionDropDown.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Game:";
            // 
            // txtCaptureLocation
            // 
            this.txtCaptureLocation.Location = new System.Drawing.Point(75, 74);
            this.txtCaptureLocation.Name = "txtCaptureLocation";
            this.txtCaptureLocation.Size = new System.Drawing.Size(189, 23);
            this.txtCaptureLocation.TabIndex = 5;
            // 
            // btnSaveCaptureLocation
            // 
            this.btnSaveCaptureLocation.Location = new System.Drawing.Point(189, 122);
            this.btnSaveCaptureLocation.Name = "btnSaveCaptureLocation";
            this.btnSaveCaptureLocation.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCaptureLocation.TabIndex = 4;
            this.btnSaveCaptureLocation.Text = "Save";
            this.btnSaveCaptureLocation.UseVisualStyleBackColor = true;
            this.btnSaveCaptureLocation.Click += new System.EventHandler(this.btnSaveCaptureLocation_Click);
            // 
            // evBox
            // 
            this.evBox.Controls.Add(this.label9);
            this.evBox.Controls.Add(this.txtEVValue);
            this.evBox.Controls.Add(this.evStatDropDown);
            this.evBox.Controls.Add(this.label8);
            this.evBox.Controls.Add(this.btnSaveEV);
            this.evBox.Location = new System.Drawing.Point(634, 279);
            this.evBox.Name = "evBox";
            this.evBox.Size = new System.Drawing.Size(294, 237);
            this.evBox.TabIndex = 10;
            this.evBox.TabStop = false;
            this.evBox.Text = "EV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "EV Value";
            // 
            // txtEVValue
            // 
            this.txtEVValue.Location = new System.Drawing.Point(64, 77);
            this.txtEVValue.Name = "txtEVValue";
            this.txtEVValue.Size = new System.Drawing.Size(215, 23);
            this.txtEVValue.TabIndex = 8;
            // 
            // evStatDropDown
            // 
            this.evStatDropDown.FormattingEnabled = true;
            this.evStatDropDown.Items.AddRange(new object[] {
            "Attack",
            "Defense",
            "HitPoint",
            "SpecialAttack",
            "SpecialDefense",
            "Speed"});
            this.evStatDropDown.Location = new System.Drawing.Point(64, 35);
            this.evStatDropDown.Name = "evStatDropDown";
            this.evStatDropDown.Size = new System.Drawing.Size(215, 23);
            this.evStatDropDown.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Stat:";
            // 
            // btnSaveEV
            // 
            this.btnSaveEV.Location = new System.Drawing.Point(204, 122);
            this.btnSaveEV.Name = "btnSaveEV";
            this.btnSaveEV.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEV.TabIndex = 4;
            this.btnSaveEV.Text = "Save";
            this.btnSaveEV.UseVisualStyleBackColor = true;
            this.btnSaveEV.Click += new System.EventHandler(this.btnSaveEV_Click);
            // 
            // evolutionBox
            // 
            this.evolutionBox.Controls.Add(this.label10);
            this.evolutionBox.Controls.Add(this.txtPokeIDEvolution);
            this.evolutionBox.Controls.Add(this.btnSaveEvolutions);
            this.evolutionBox.Location = new System.Drawing.Point(934, 12);
            this.evolutionBox.Name = "evolutionBox";
            this.evolutionBox.Size = new System.Drawing.Size(294, 237);
            this.evolutionBox.TabIndex = 9;
            this.evolutionBox.TabStop = false;
            this.evolutionBox.Text = "Evolutions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "PokeID:";
            // 
            // txtPokeIDEvolution
            // 
            this.txtPokeIDEvolution.Location = new System.Drawing.Point(70, 34);
            this.txtPokeIDEvolution.Name = "txtPokeIDEvolution";
            this.txtPokeIDEvolution.Size = new System.Drawing.Size(209, 23);
            this.txtPokeIDEvolution.TabIndex = 5;
            // 
            // btnSaveEvolutions
            // 
            this.btnSaveEvolutions.Location = new System.Drawing.Point(204, 73);
            this.btnSaveEvolutions.Name = "btnSaveEvolutions";
            this.btnSaveEvolutions.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEvolutions.TabIndex = 4;
            this.btnSaveEvolutions.Text = "Save";
            this.btnSaveEvolutions.UseVisualStyleBackColor = true;
            this.btnSaveEvolutions.Click += new System.EventHandler(this.btnSaveEvolutions_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 677);
            this.Controls.Add(this.evolutionBox);
            this.Controls.Add(this.evBox);
            this.Controls.Add(this.captureLocationBox);
            this.Controls.Add(this.abilitiesBox);
            this.Controls.Add(this.weaknessBox);
            this.Controls.Add(this.pokeTypeBox);
            this.Controls.Add(this.pokeDexAddBox);
            this.Name = "Add";
            this.Text = "Add";
            this.pokeDexAddBox.ResumeLayout(false);
            this.pokeDexAddBox.PerformLayout();
            this.pokeTypeBox.ResumeLayout(false);
            this.pokeTypeBox.PerformLayout();
            this.weaknessBox.ResumeLayout(false);
            this.weaknessBox.PerformLayout();
            this.abilitiesBox.ResumeLayout(false);
            this.abilitiesBox.PerformLayout();
            this.captureLocationBox.ResumeLayout(false);
            this.captureLocationBox.PerformLayout();
            this.evBox.ResumeLayout(false);
            this.evBox.PerformLayout();
            this.evolutionBox.ResumeLayout(false);
            this.evolutionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox pokeDexAddBox;
        private Button btnSavePokedexEntry;
        private RichTextBox txtPokedexEntry;
        private Label label2;
        private ComboBox versionDropDown;
        private Label label1;
        private GroupBox pokeTypeBox;
        private Label label3;
        private TextBox txtPokeType;
        private Button btnSavePokeType;
        private GroupBox weaknessBox;
        private Label label4;
        private TextBox txtWeakness;
        private Button btnSaveWeakness;
        private GroupBox abilitiesBox;
        private Label label5;
        private TextBox txtAbility;
        private Button btnSaveAbility;
        private GroupBox captureLocationBox;
        private Label label7;
        private ComboBox locCapVersionDropDown;
        private Label label6;
        private TextBox txtCaptureLocation;
        private Button btnSaveCaptureLocation;
        private GroupBox evBox;
        private Label label9;
        private TextBox txtEVValue;
        private ComboBox evStatDropDown;
        private Label label8;
        private Button btnSaveEV;
        private GroupBox evolutionBox;
        private Label label10;
        private TextBox txtPokeIDEvolution;
        private Button btnSaveEvolutions;
    }
}