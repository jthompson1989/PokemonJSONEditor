namespace PokemonJSONEditor_WinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPokemonName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pokemonImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPokeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPokeHeight = new System.Windows.Forms.TextBox();
            this.txtPokeWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listPokedex = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listPokeTypes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveType = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveWeakness = new System.Windows.Forms.Button();
            this.listWeakness = new System.Windows.Forms.ListBox();
            this.btnAddWeakness = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveAbilities = new System.Windows.Forms.Button();
            this.listAbilities = new System.Windows.Forms.ListBox();
            this.btnAddAbilities = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.totalStat = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSpDefense = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSpAttack = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDefense = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHitPoint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRemoveCatchLocation = new System.Windows.Forms.Button();
            this.listCatchLocation = new System.Windows.Forms.ListBox();
            this.btnAddCatchLocation = new System.Windows.Forms.Button();
            this.txtCatchRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtEggGroup = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHatchTime = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFemalePercentage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMalePercent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBaseExp = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEvolveFrom = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEvolveReason = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.EV = new System.Windows.Forms.Label();
            this.listEV = new System.Windows.Forms.ListBox();
            this.btnRemoveEV = new System.Windows.Forms.Button();
            this.btnAddEV = new System.Windows.Forms.Button();
            this.btnNextPokemon = new System.Windows.Forms.Button();
            this.txtPokeImageURL = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnUpdateImage = new System.Windows.Forms.Button();
            this.btnJSONViewer = new System.Windows.Forms.Button();
            this.listEvolutions = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnAddEvolution = new System.Windows.Forms.Button();
            this.btnRemoveEvolution = new System.Windows.Forms.Button();
            this.btnSavePokeData = new System.Windows.Forms.Button();
            this.btnPublishPokeData = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txtJsonFile = new System.Windows.Forms.TextBox();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.btnEditPokedex = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pokemon Name:";
            // 
            // txtPokemonName
            // 
            this.txtPokemonName.Location = new System.Drawing.Point(114, 35);
            this.txtPokemonName.Name = "txtPokemonName";
            this.txtPokemonName.Size = new System.Drawing.Size(301, 23);
            this.txtPokemonName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(421, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pokemonImage
            // 
            this.pokemonImage.Location = new System.Drawing.Point(1006, 104);
            this.pokemonImage.Name = "pokemonImage";
            this.pokemonImage.Size = new System.Drawing.Size(281, 228);
            this.pokemonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pokemonImage.TabIndex = 3;
            this.pokemonImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "PokeID:";
            // 
            // txtPokeID
            // 
            this.txtPokeID.Location = new System.Drawing.Point(67, 66);
            this.txtPokeID.Name = "txtPokeID";
            this.txtPokeID.ReadOnly = true;
            this.txtPokeID.Size = new System.Drawing.Size(100, 23);
            this.txtPokeID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height:";
            // 
            // txtPokeHeight
            // 
            this.txtPokeHeight.Location = new System.Drawing.Point(234, 66);
            this.txtPokeHeight.Name = "txtPokeHeight";
            this.txtPokeHeight.Size = new System.Drawing.Size(92, 23);
            this.txtPokeHeight.TabIndex = 3;
            // 
            // txtPokeWeight
            // 
            this.txtPokeWeight.Location = new System.Drawing.Point(388, 66);
            this.txtPokeWeight.Name = "txtPokeWeight";
            this.txtPokeWeight.Size = new System.Drawing.Size(92, 23);
            this.txtPokeWeight.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Weight:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(555, 66);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(142, 23);
            this.txtCategory.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Category:";
            // 
            // listPokedex
            // 
            this.listPokedex.FormattingEnabled = true;
            this.listPokedex.ItemHeight = 15;
            this.listPokedex.Location = new System.Drawing.Point(11, 118);
            this.listPokedex.Name = "listPokedex";
            this.listPokedex.Size = new System.Drawing.Size(968, 214);
            this.listPokedex.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "PokeDex:";
            // 
            // listPokeTypes
            // 
            this.listPokeTypes.FormattingEnabled = true;
            this.listPokeTypes.ItemHeight = 15;
            this.listPokeTypes.Location = new System.Drawing.Point(8, 22);
            this.listPokeTypes.Name = "listPokeTypes";
            this.listPokeTypes.Size = new System.Drawing.Size(196, 94);
            this.listPokeTypes.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveType);
            this.groupBox1.Controls.Add(this.btnAddType);
            this.groupBox1.Controls.Add(this.listPokeTypes);
            this.groupBox1.Location = new System.Drawing.Point(14, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 129);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Types";
            // 
            // btnRemoveType
            // 
            this.btnRemoveType.Location = new System.Drawing.Point(210, 71);
            this.btnRemoveType.Name = "btnRemoveType";
            this.btnRemoveType.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveType.TabIndex = 17;
            this.btnRemoveType.Text = "Remove";
            this.btnRemoveType.UseVisualStyleBackColor = true;
            this.btnRemoveType.Click += new System.EventHandler(this.btnRemoveType_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(210, 42);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(75, 23);
            this.btnAddType.TabIndex = 8;
            this.btnAddType.Text = "Add";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveWeakness);
            this.groupBox2.Controls.Add(this.listWeakness);
            this.groupBox2.Controls.Add(this.btnAddWeakness);
            this.groupBox2.Location = new System.Drawing.Point(336, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 129);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weakness";
            // 
            // btnRemoveWeakness
            // 
            this.btnRemoveWeakness.Location = new System.Drawing.Point(219, 71);
            this.btnRemoveWeakness.Name = "btnRemoveWeakness";
            this.btnRemoveWeakness.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveWeakness.TabIndex = 19;
            this.btnRemoveWeakness.Text = "Remove";
            this.btnRemoveWeakness.UseVisualStyleBackColor = true;
            this.btnRemoveWeakness.Click += new System.EventHandler(this.btnRemoveWeakness_Click);
            // 
            // listWeakness
            // 
            this.listWeakness.FormattingEnabled = true;
            this.listWeakness.ItemHeight = 15;
            this.listWeakness.Location = new System.Drawing.Point(8, 22);
            this.listWeakness.Name = "listWeakness";
            this.listWeakness.Size = new System.Drawing.Size(196, 94);
            this.listWeakness.TabIndex = 15;
            // 
            // btnAddWeakness
            // 
            this.btnAddWeakness.Location = new System.Drawing.Point(219, 42);
            this.btnAddWeakness.Name = "btnAddWeakness";
            this.btnAddWeakness.Size = new System.Drawing.Size(75, 23);
            this.btnAddWeakness.TabIndex = 9;
            this.btnAddWeakness.Text = "Add";
            this.btnAddWeakness.UseVisualStyleBackColor = true;
            this.btnAddWeakness.Click += new System.EventHandler(this.btnAddWeakness_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveAbilities);
            this.groupBox3.Controls.Add(this.listAbilities);
            this.groupBox3.Controls.Add(this.btnAddAbilities);
            this.groupBox3.Location = new System.Drawing.Point(667, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 129);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abilities";
            // 
            // btnRemoveAbilities
            // 
            this.btnRemoveAbilities.Location = new System.Drawing.Point(219, 71);
            this.btnRemoveAbilities.Name = "btnRemoveAbilities";
            this.btnRemoveAbilities.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAbilities.TabIndex = 21;
            this.btnRemoveAbilities.Text = "Remove";
            this.btnRemoveAbilities.UseVisualStyleBackColor = true;
            this.btnRemoveAbilities.Click += new System.EventHandler(this.btnRemoveAbilities_Click);
            // 
            // listAbilities
            // 
            this.listAbilities.FormattingEnabled = true;
            this.listAbilities.ItemHeight = 15;
            this.listAbilities.Location = new System.Drawing.Point(8, 22);
            this.listAbilities.Name = "listAbilities";
            this.listAbilities.Size = new System.Drawing.Size(196, 94);
            this.listAbilities.TabIndex = 15;
            // 
            // btnAddAbilities
            // 
            this.btnAddAbilities.Location = new System.Drawing.Point(219, 42);
            this.btnAddAbilities.Name = "btnAddAbilities";
            this.btnAddAbilities.Size = new System.Drawing.Size(75, 23);
            this.btnAddAbilities.TabIndex = 10;
            this.btnAddAbilities.Text = "Add";
            this.btnAddAbilities.UseVisualStyleBackColor = true;
            this.btnAddAbilities.Click += new System.EventHandler(this.btnAddAbilities_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.totalStat);
            this.groupBox4.Controls.Add(this.txtSpeed);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtSpDefense);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtSpAttack);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtDefense);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtAttack);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtHitPoint);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(16, 489);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 208);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stats";
            // 
            // totalStat
            // 
            this.totalStat.AutoSize = true;
            this.totalStat.Location = new System.Drawing.Point(143, 171);
            this.totalStat.Name = "totalStat";
            this.totalStat.Size = new System.Drawing.Size(35, 15);
            this.totalStat.TabIndex = 12;
            this.totalStat.Text = "Total:";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(218, 131);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(50, 23);
            this.txtSpeed.TabIndex = 19;
            this.txtSpeed.Text = "0";
            this.txtSpeed.TextChanged += new System.EventHandler(this.txtSpeed_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Speed:";
            // 
            // txtSpDefense
            // 
            this.txtSpDefense.Location = new System.Drawing.Point(218, 84);
            this.txtSpDefense.Name = "txtSpDefense";
            this.txtSpDefense.Size = new System.Drawing.Size(50, 23);
            this.txtSpDefense.TabIndex = 17;
            this.txtSpDefense.Text = "0";
            this.txtSpDefense.TextChanged += new System.EventHandler(this.txtSpDefense_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sp. Defense:";
            // 
            // txtSpAttack
            // 
            this.txtSpAttack.Location = new System.Drawing.Point(218, 40);
            this.txtSpAttack.Name = "txtSpAttack";
            this.txtSpAttack.Size = new System.Drawing.Size(50, 23);
            this.txtSpAttack.TabIndex = 15;
            this.txtSpAttack.Text = "0";
            this.txtSpAttack.TextChanged += new System.EventHandler(this.txtSpAttack_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sp. Attack:";
            // 
            // txtDefense
            // 
            this.txtDefense.Location = new System.Drawing.Point(77, 131);
            this.txtDefense.Name = "txtDefense";
            this.txtDefense.Size = new System.Drawing.Size(50, 23);
            this.txtDefense.TabIndex = 18;
            this.txtDefense.Text = "0";
            this.txtDefense.TextChanged += new System.EventHandler(this.txtDefense_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Defense:";
            // 
            // txtAttack
            // 
            this.txtAttack.Location = new System.Drawing.Point(77, 79);
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(50, 23);
            this.txtAttack.TabIndex = 16;
            this.txtAttack.Text = "0";
            this.txtAttack.TextChanged += new System.EventHandler(this.txtAttack_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Attack:";
            // 
            // txtHitPoint
            // 
            this.txtHitPoint.Location = new System.Drawing.Point(77, 40);
            this.txtHitPoint.Name = "txtHitPoint";
            this.txtHitPoint.Size = new System.Drawing.Size(50, 23);
            this.txtHitPoint.TabIndex = 14;
            this.txtHitPoint.Text = "0";
            this.txtHitPoint.TextChanged += new System.EventHandler(this.txtHitPoint_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hitpoints:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRemoveCatchLocation);
            this.groupBox5.Controls.Add(this.listCatchLocation);
            this.groupBox5.Controls.Add(this.btnAddCatchLocation);
            this.groupBox5.Controls.Add(this.txtCatchRate);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(390, 491);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(402, 206);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Catch";
            // 
            // btnRemoveCatchLocation
            // 
            this.btnRemoveCatchLocation.Location = new System.Drawing.Point(313, 70);
            this.btnRemoveCatchLocation.Name = "btnRemoveCatchLocation";
            this.btnRemoveCatchLocation.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCatchLocation.TabIndex = 21;
            this.btnRemoveCatchLocation.Text = "Remove";
            this.btnRemoveCatchLocation.UseVisualStyleBackColor = true;
            this.btnRemoveCatchLocation.Click += new System.EventHandler(this.btnRemoveCatchLocation_Click);
            // 
            // listCatchLocation
            // 
            this.listCatchLocation.FormattingEnabled = true;
            this.listCatchLocation.ItemHeight = 15;
            this.listCatchLocation.Location = new System.Drawing.Point(13, 24);
            this.listCatchLocation.Name = "listCatchLocation";
            this.listCatchLocation.Size = new System.Drawing.Size(294, 139);
            this.listCatchLocation.TabIndex = 2;
            // 
            // btnAddCatchLocation
            // 
            this.btnAddCatchLocation.Location = new System.Drawing.Point(313, 41);
            this.btnAddCatchLocation.Name = "btnAddCatchLocation";
            this.btnAddCatchLocation.Size = new System.Drawing.Size(75, 23);
            this.btnAddCatchLocation.TabIndex = 20;
            this.btnAddCatchLocation.Text = "Add";
            this.btnAddCatchLocation.UseVisualStyleBackColor = true;
            this.btnAddCatchLocation.Click += new System.EventHandler(this.btnAddCatchLocation_Click);
            // 
            // txtCatchRate
            // 
            this.txtCatchRate.Location = new System.Drawing.Point(78, 175);
            this.txtCatchRate.Name = "txtCatchRate";
            this.txtCatchRate.Size = new System.Drawing.Size(53, 23);
            this.txtCatchRate.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Catch_Rate";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtEggGroup);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txtHatchTime);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtFemalePercentage);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtMalePercent);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(798, 489);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 208);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Breeding";
            // 
            // txtEggGroup
            // 
            this.txtEggGroup.Location = new System.Drawing.Point(72, 117);
            this.txtEggGroup.Name = "txtEggGroup";
            this.txtEggGroup.Size = new System.Drawing.Size(100, 23);
            this.txtEggGroup.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Egg Group:";
            // 
            // txtHatchTime
            // 
            this.txtHatchTime.Location = new System.Drawing.Point(72, 88);
            this.txtHatchTime.Name = "txtHatchTime";
            this.txtHatchTime.Size = new System.Drawing.Size(100, 23);
            this.txtHatchTime.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "Hatch TIme:";
            // 
            // txtFemalePercentage
            // 
            this.txtFemalePercentage.Location = new System.Drawing.Point(72, 51);
            this.txtFemalePercentage.Name = "txtFemalePercentage";
            this.txtFemalePercentage.Size = new System.Drawing.Size(100, 23);
            this.txtFemalePercentage.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Female %:";
            // 
            // txtMalePercent
            // 
            this.txtMalePercent.Location = new System.Drawing.Point(72, 22);
            this.txtMalePercent.Name = "txtMalePercent";
            this.txtMalePercent.Size = new System.Drawing.Size(100, 23);
            this.txtMalePercent.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Male %:";
            // 
            // txtBaseExp
            // 
            this.txtBaseExp.Location = new System.Drawing.Point(768, 66);
            this.txtBaseExp.Name = "txtBaseExp";
            this.txtBaseExp.Size = new System.Drawing.Size(54, 23);
            this.txtBaseExp.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(707, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 15);
            this.label18.TabIndex = 28;
            this.label18.Text = "Base EXP";
            // 
            // txtEvolveFrom
            // 
            this.txtEvolveFrom.Location = new System.Drawing.Point(1095, 343);
            this.txtEvolveFrom.Name = "txtEvolveFrom";
            this.txtEvolveFrom.Size = new System.Drawing.Size(128, 23);
            this.txtEvolveFrom.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1019, 347);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "Evolve From";
            // 
            // txtEvolveReason
            // 
            this.txtEvolveReason.Location = new System.Drawing.Point(1095, 372);
            this.txtEvolveReason.Name = "txtEvolveReason";
            this.txtEvolveReason.Size = new System.Drawing.Size(128, 23);
            this.txtEvolveReason.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1015, 376);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 15);
            this.label20.TabIndex = 30;
            this.label20.Text = "Evolve Reason";
            // 
            // EV
            // 
            this.EV.AutoSize = true;
            this.EV.Location = new System.Drawing.Point(1019, 484);
            this.EV.Name = "EV";
            this.EV.Size = new System.Drawing.Size(20, 15);
            this.EV.TabIndex = 32;
            this.EV.Text = "EV";
            // 
            // listEV
            // 
            this.listEV.FormattingEnabled = true;
            this.listEV.ItemHeight = 15;
            this.listEV.Location = new System.Drawing.Point(1019, 502);
            this.listEV.Name = "listEV";
            this.listEV.Size = new System.Drawing.Size(187, 184);
            this.listEV.TabIndex = 33;
            // 
            // btnRemoveEV
            // 
            this.btnRemoveEV.Location = new System.Drawing.Point(1212, 553);
            this.btnRemoveEV.Name = "btnRemoveEV";
            this.btnRemoveEV.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveEV.TabIndex = 23;
            this.btnRemoveEV.Text = "Remove";
            this.btnRemoveEV.UseVisualStyleBackColor = true;
            this.btnRemoveEV.Click += new System.EventHandler(this.btnRemoveEV_Click);
            // 
            // btnAddEV
            // 
            this.btnAddEV.Location = new System.Drawing.Point(1212, 524);
            this.btnAddEV.Name = "btnAddEV";
            this.btnAddEV.Size = new System.Drawing.Size(75, 23);
            this.btnAddEV.TabIndex = 22;
            this.btnAddEV.Text = "Add";
            this.btnAddEV.UseVisualStyleBackColor = true;
            this.btnAddEV.Click += new System.EventHandler(this.btnAddEV_Click);
            // 
            // btnNextPokemon
            // 
            this.btnNextPokemon.Location = new System.Drawing.Point(502, 34);
            this.btnNextPokemon.Name = "btnNextPokemon";
            this.btnNextPokemon.Size = new System.Drawing.Size(117, 23);
            this.btnNextPokemon.TabIndex = 34;
            this.btnNextPokemon.Text = "Next Pokemon";
            this.btnNextPokemon.UseVisualStyleBackColor = true;
            this.btnNextPokemon.Click += new System.EventHandler(this.btnNextPokemon_Click);
            // 
            // txtPokeImageURL
            // 
            this.txtPokeImageURL.Location = new System.Drawing.Point(1006, 69);
            this.txtPokeImageURL.Name = "txtPokeImageURL";
            this.txtPokeImageURL.Size = new System.Drawing.Size(217, 23);
            this.txtPokeImageURL.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1006, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 15);
            this.label21.TabIndex = 36;
            this.label21.Text = "Image URL:";
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.Location = new System.Drawing.Point(1229, 48);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(75, 44);
            this.btnUpdateImage.TabIndex = 37;
            this.btnUpdateImage.Text = "Update Image";
            this.btnUpdateImage.UseVisualStyleBackColor = true;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // btnJSONViewer
            // 
            this.btnJSONViewer.Location = new System.Drawing.Point(624, 34);
            this.btnJSONViewer.Name = "btnJSONViewer";
            this.btnJSONViewer.Size = new System.Drawing.Size(99, 23);
            this.btnJSONViewer.TabIndex = 38;
            this.btnJSONViewer.Text = "JSON Viewer";
            this.btnJSONViewer.UseVisualStyleBackColor = true;
            this.btnJSONViewer.Click += new System.EventHandler(this.btnJSONViewer_Click);
            // 
            // listEvolutions
            // 
            this.listEvolutions.FormattingEnabled = true;
            this.listEvolutions.ItemHeight = 15;
            this.listEvolutions.Location = new System.Drawing.Point(1095, 401);
            this.listEvolutions.Name = "listEvolutions";
            this.listEvolutions.Size = new System.Drawing.Size(128, 94);
            this.listEvolutions.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1019, 403);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 15);
            this.label22.TabIndex = 40;
            this.label22.Text = "Evolutions:";
            // 
            // btnAddEvolution
            // 
            this.btnAddEvolution.Location = new System.Drawing.Point(1229, 403);
            this.btnAddEvolution.Name = "btnAddEvolution";
            this.btnAddEvolution.Size = new System.Drawing.Size(75, 23);
            this.btnAddEvolution.TabIndex = 13;
            this.btnAddEvolution.Text = "Add";
            this.btnAddEvolution.UseVisualStyleBackColor = true;
            this.btnAddEvolution.Click += new System.EventHandler(this.btnAddEvolution_Click);
            // 
            // btnRemoveEvolution
            // 
            this.btnRemoveEvolution.Location = new System.Drawing.Point(1229, 432);
            this.btnRemoveEvolution.Name = "btnRemoveEvolution";
            this.btnRemoveEvolution.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveEvolution.TabIndex = 42;
            this.btnRemoveEvolution.Text = "Remove";
            this.btnRemoveEvolution.UseVisualStyleBackColor = true;
            this.btnRemoveEvolution.Click += new System.EventHandler(this.btnRemoveEvolution_Click);
            // 
            // btnSavePokeData
            // 
            this.btnSavePokeData.Location = new System.Drawing.Point(729, 34);
            this.btnSavePokeData.Name = "btnSavePokeData";
            this.btnSavePokeData.Size = new System.Drawing.Size(75, 23);
            this.btnSavePokeData.TabIndex = 43;
            this.btnSavePokeData.Text = "Save Data";
            this.btnSavePokeData.UseVisualStyleBackColor = true;
            this.btnSavePokeData.Click += new System.EventHandler(this.btnSavePokeData_Click);
            // 
            // btnPublishPokeData
            // 
            this.btnPublishPokeData.Location = new System.Drawing.Point(810, 34);
            this.btnPublishPokeData.Name = "btnPublishPokeData";
            this.btnPublishPokeData.Size = new System.Drawing.Size(105, 23);
            this.btnPublishPokeData.TabIndex = 44;
            this.btnPublishPokeData.Text = "Publish Data";
            this.btnPublishPokeData.UseVisualStyleBackColor = true;
            this.btnPublishPokeData.Click += new System.EventHandler(this.btnPublishPokeData_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 15);
            this.label23.TabIndex = 45;
            this.label23.Text = "JSON File:";
            // 
            // txtJsonFile
            // 
            this.txtJsonFile.Location = new System.Drawing.Point(77, 6);
            this.txtJsonFile.Name = "txtJsonFile";
            this.txtJsonFile.Size = new System.Drawing.Size(571, 23);
            this.txtJsonFile.TabIndex = 46;
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(654, 5);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(75, 23);
            this.btnLoadJson.TabIndex = 47;
            this.btnLoadJson.Text = "Load JSON";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // btnEditPokedex
            // 
            this.btnEditPokedex.Location = new System.Drawing.Point(68, 93);
            this.btnEditPokedex.Name = "btnEditPokedex";
            this.btnEditPokedex.Size = new System.Drawing.Size(99, 23);
            this.btnEditPokedex.TabIndex = 7;
            this.btnEditPokedex.Text = "Edit Pokedex";
            this.btnEditPokedex.UseVisualStyleBackColor = true;
            this.btnEditPokedex.Click += new System.EventHandler(this.btnEditPokedex_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(768, 5);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(105, 23);
            this.btnCreateNew.TabIndex = 49;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 712);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.btnEditPokedex);
            this.Controls.Add(this.btnLoadJson);
            this.Controls.Add(this.txtJsonFile);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnPublishPokeData);
            this.Controls.Add(this.btnSavePokeData);
            this.Controls.Add(this.btnRemoveEvolution);
            this.Controls.Add(this.btnAddEvolution);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.listEvolutions);
            this.Controls.Add(this.btnJSONViewer);
            this.Controls.Add(this.btnUpdateImage);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtPokeImageURL);
            this.Controls.Add(this.btnNextPokemon);
            this.Controls.Add(this.btnRemoveEV);
            this.Controls.Add(this.listEV);
            this.Controls.Add(this.btnAddEV);
            this.Controls.Add(this.EV);
            this.Controls.Add(this.txtEvolveReason);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtEvolveFrom);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtBaseExp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listPokedex);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPokeWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPokeHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPokeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pokemonImage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPokemonName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pokemon JSON Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPokemonName;
        private Button btnSearch;
        private PictureBox pokemonImage;
        private Label label2;
        private TextBox txtPokeID;
        private Label label3;
        private TextBox txtPokeHeight;
        private TextBox txtPokeWeight;
        private Label label4;
        private TextBox txtCategory;
        private Label label5;
        private ListBox listPokedex;
        private Label label6;
        private ListBox listPokeTypes;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listWeakness;
        private GroupBox groupBox3;
        private ListBox listAbilities;
        private Button btnRemoveType;
        private Button btnAddType;
        private Button btnRemoveWeakness;
        private Button btnAddWeakness;
        private Button btnRemoveAbilities;
        private Button btnAddAbilities;
        private GroupBox groupBox4;
        private TextBox txtSpeed;
        private Label label12;
        private TextBox txtSpDefense;
        private Label label11;
        private TextBox txtSpAttack;
        private Label label10;
        private TextBox txtDefense;
        private Label label9;
        private TextBox txtAttack;
        private Label label8;
        private TextBox txtHitPoint;
        private Label label7;
        private Label totalStat;
        private GroupBox groupBox5;
        private TextBox txtCatchRate;
        private Label label13;
        private Button btnRemoveCatchLocation;
        private ListBox listCatchLocation;
        private Button btnAddCatchLocation;
        private GroupBox groupBox6;
        private TextBox txtFemalePercentage;
        private Label label15;
        private TextBox txtMalePercent;
        private Label label14;
        private TextBox txtEggGroup;
        private Label label16;
        private TextBox txtHatchTime;
        private Label label17;
        private TextBox txtBaseExp;
        private Label label18;
        private TextBox txtEvolveFrom;
        private Label label19;
        private TextBox txtEvolveReason;
        private Label label20;
        private Label EV;
        private ListBox listEV;
        private Button btnRemoveEV;
        private Button btnAddEV;
        private Button btnNextPokemon;
        private TextBox txtPokeImageURL;
        private Label label21;
        private Button btnUpdateImage;
        private Button btnJSONViewer;
        private ListBox listEvolutions;
        private Label label22;
        private Button btnAddEvolution;
        private Button btnRemoveEvolution;
        private Button btnSavePokeData;
        private Button btnPublishPokeData;
        private Label label23;
        private TextBox txtJsonFile;
        private Button btnLoadJson;
        private Button btnEditPokedex;
        private Button btnCreateNew;
    }
}