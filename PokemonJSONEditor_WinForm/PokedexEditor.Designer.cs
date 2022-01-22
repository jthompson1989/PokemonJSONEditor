namespace PokemonJSONEditor_WinForm
{
    partial class PokedexEditor
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
            this.pokedexTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNewPokeDexEntry = new System.Windows.Forms.Button();
            this.btnSavePokeDex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPokeDexDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPokeDexGame = new System.Windows.Forms.TextBox();
            this.listPokeDexEntry = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPokeDexJSON = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSavePokeDexJson = new System.Windows.Forms.Button();
            this.pokedexTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pokedexTabs
            // 
            this.pokedexTabs.Controls.Add(this.tabPage1);
            this.pokedexTabs.Controls.Add(this.tabPage2);
            this.pokedexTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokedexTabs.Location = new System.Drawing.Point(0, 0);
            this.pokedexTabs.Name = "pokedexTabs";
            this.pokedexTabs.SelectedIndex = 0;
            this.pokedexTabs.Size = new System.Drawing.Size(859, 538);
            this.pokedexTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNewPokeDexEntry);
            this.tabPage1.Controls.Add(this.btnSavePokeDex);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPokeDexDescription);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtPokeDexGame);
            this.tabPage1.Controls.Add(this.listPokeDexEntry);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PokeDex List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNewPokeDexEntry
            // 
            this.btnNewPokeDexEntry.Location = new System.Drawing.Point(737, 290);
            this.btnNewPokeDexEntry.Name = "btnNewPokeDexEntry";
            this.btnNewPokeDexEntry.Size = new System.Drawing.Size(75, 23);
            this.btnNewPokeDexEntry.TabIndex = 6;
            this.btnNewPokeDexEntry.Text = "Add New";
            this.btnNewPokeDexEntry.UseVisualStyleBackColor = true;
            this.btnNewPokeDexEntry.Click += new System.EventHandler(this.btnNewPokeDexEntry_Click);
            // 
            // btnSavePokeDex
            // 
            this.btnSavePokeDex.Location = new System.Drawing.Point(584, 290);
            this.btnSavePokeDex.Name = "btnSavePokeDex";
            this.btnSavePokeDex.Size = new System.Drawing.Size(75, 23);
            this.btnSavePokeDex.TabIndex = 5;
            this.btnSavePokeDex.Text = "Save";
            this.btnSavePokeDex.UseVisualStyleBackColor = true;
            this.btnSavePokeDex.Click += new System.EventHandler(this.btnSavePokeDex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // txtPokeDexDescription
            // 
            this.txtPokeDexDescription.Location = new System.Drawing.Point(584, 105);
            this.txtPokeDexDescription.Name = "txtPokeDexDescription";
            this.txtPokeDexDescription.Size = new System.Drawing.Size(228, 168);
            this.txtPokeDexDescription.TabIndex = 3;
            this.txtPokeDexDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game:";
            // 
            // txtPokeDexGame
            // 
            this.txtPokeDexGame.Location = new System.Drawing.Point(584, 40);
            this.txtPokeDexGame.Name = "txtPokeDexGame";
            this.txtPokeDexGame.Size = new System.Drawing.Size(198, 23);
            this.txtPokeDexGame.TabIndex = 1;
            // 
            // listPokeDexEntry
            // 
            this.listPokeDexEntry.FormattingEnabled = true;
            this.listPokeDexEntry.ItemHeight = 15;
            this.listPokeDexEntry.Location = new System.Drawing.Point(8, 6);
            this.listPokeDexEntry.Name = "listPokeDexEntry";
            this.listPokeDexEntry.Size = new System.Drawing.Size(468, 499);
            this.listPokeDexEntry.TabIndex = 0;
            this.listPokeDexEntry.SelectedIndexChanged += new System.EventHandler(this.listPokeDexEntry_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPokeDexJSON);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PokeDex Json";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPokeDexJSON
            // 
            this.txtPokeDexJSON.BackColor = System.Drawing.Color.Black;
            this.txtPokeDexJSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPokeDexJSON.ForeColor = System.Drawing.Color.Lime;
            this.txtPokeDexJSON.Location = new System.Drawing.Point(3, 47);
            this.txtPokeDexJSON.Name = "txtPokeDexJSON";
            this.txtPokeDexJSON.Size = new System.Drawing.Size(845, 460);
            this.txtPokeDexJSON.TabIndex = 1;
            this.txtPokeDexJSON.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSavePokeDexJson);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSavePokeDexJson
            // 
            this.btnSavePokeDexJson.Location = new System.Drawing.Point(23, 15);
            this.btnSavePokeDexJson.Name = "btnSavePokeDexJson";
            this.btnSavePokeDexJson.Size = new System.Drawing.Size(75, 23);
            this.btnSavePokeDexJson.TabIndex = 0;
            this.btnSavePokeDexJson.Text = "Save";
            this.btnSavePokeDexJson.UseVisualStyleBackColor = true;
            this.btnSavePokeDexJson.Click += new System.EventHandler(this.btnSavePokeDexJson_Click);
            // 
            // PokedexEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 538);
            this.Controls.Add(this.pokedexTabs);
            this.Name = "PokedexEditor";
            this.Text = "PokedexEditor";
            this.pokedexTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl pokedexTabs;
        private TabPage tabPage1;
        private Button btnNewPokeDexEntry;
        private Button btnSavePokeDex;
        private Label label2;
        private RichTextBox txtPokeDexDescription;
        private Label label1;
        private TextBox txtPokeDexGame;
        private ListBox listPokeDexEntry;
        private TabPage tabPage2;
        private RichTextBox txtPokeDexJSON;
        private GroupBox groupBox1;
        private Button btnSavePokeDexJson;
    }
}