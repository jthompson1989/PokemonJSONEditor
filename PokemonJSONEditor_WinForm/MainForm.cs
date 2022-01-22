using Json.Net;
using Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PokemonJSONEditor_WinForm.Models;

namespace PokemonJSONEditor_WinForm
{
    public partial class MainForm : Form
    {
        private string jsonFile;//@"C:\Users\zombi\source\repos\PokemonJSONEditor_WinForm\PokemonJSONEditor_WinForm\pokemons.json";
        private Pokemon[] pokemons;
        private Pokemon selectedPokemon;
        private int selectedIndex;
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadData(Pokemon pokemon)
        {
            ClearData();
            txtPokeID.ReadOnly = true;

            txtPokeID.Text = pokemon.id;
            txtPokeHeight.Text = pokemon.height;
            txtPokeWeight.Text = pokemon.weight;
            txtCategory.Text = pokemon.category;
            txtPokeImageURL.Text = pokemon.imageurl;
            pokemonImage.ImageLocation = pokemon.imageurl;

            txtHitPoint.Text = pokemon.hp.ToString();
            txtAttack.Text = pokemon.attack.ToString();
            txtDefense.Text = pokemon.defense.ToString();
            txtSpAttack.Text = pokemon.special_attack.ToString();
            txtSpDefense.Text = pokemon.special_defense.ToString();
            txtSpeed.Text = pokemon.speed.ToString();

            txtBaseExp.Text = pokemon.base_exp.ToString();

            txtCatchRate.Text = pokemon.catch_rate.ToString();

            txtMalePercent.Text = pokemon.male_percentage.ToString();
            txtFemalePercentage.Text = pokemon.female_percentage.ToString();
            txtEggGroup.Text = pokemon.egg_groups.ToString();
            txtHatchTime.Text = pokemon.hatch_time == null ? "" : pokemon.hatch_time.ToString();

            txtEvolveFrom.Text = pokemon.evolvedfrom.ToString();
            txtEvolveReason.Text = pokemon.evolution_cause.ToString();

            int total = AddTotalStats();
            totalStat.Text = String.Format("Total: {0}", total);

            foreach(var pokeDex in pokemon.description)
            {
                if (!String.IsNullOrEmpty(pokeDex.entry))
                {
                    listPokedex.Items.Add(string.Format("Version:{0} - {1}", pokeDex.version, pokeDex.entry));
;               }
            }

            foreach(var type in pokemon.type)
            {
                listPokeTypes.Items.Add(type);
            }

            foreach(var weakness in pokemon.weaknesses)
            {
                listWeakness.Items.Add(weakness);
            }

            foreach(var ability in pokemon.abilities)
            {
                listAbilities.Items.Add(ability);
            }
            foreach (var ev in pokemon.ev)
            {
                listEV.Items.Add(String.Format("{0} - {1}", ev.stat, ev.ev_value));
            }
            foreach(var catchLoc in pokemon.catch_location)
            {
                listCatchLocation.Items.Add(string.Format("{0} - {1}", catchLoc.game, string.Join(',', catchLoc.location)));
            }
            foreach(string evolution in pokemon.evolutions)
            {
                listEvolutions.Items.Add(evolution);
            }

        }

        public void ClearData()
        {
            txtPokeID.Text = String.Empty;
            txtPokeHeight.Text = String.Empty;
            txtPokeWeight.Text = String.Empty;
            txtCategory.Text = String.Empty;
            pokemonImage.ImageLocation = String.Empty;

            txtHitPoint.Text = String.Empty;
            txtAttack.Text = String.Empty;
            txtDefense.Text = String.Empty;
            txtSpAttack.Text = String.Empty;
            txtSpDefense.Text = String.Empty;
            txtSpeed.Text = String.Empty;

            txtBaseExp.Text = String.Empty;

            txtCatchRate.Text = String.Empty;

            txtMalePercent.Text = String.Empty;
            txtFemalePercentage.Text = String.Empty;
            txtEggGroup.Text = String.Empty;
            txtHatchTime.Text = String.Empty;

            txtEvolveFrom.Text = String.Empty;
            txtEvolveReason.Text = String.Empty;

            listPokedex.Items.Clear();
            listPokeTypes.Items.Clear();
            listAbilities.Items.Clear();
            listWeakness.Items.Clear();
            listCatchLocation.Items.Clear();
            listEV.Items.Clear();
            listEvolutions.Items.Clear();
        }

        public void SaveData()
        { 
            Pokemon pokemon = new Pokemon();

            pokemon.id = txtPokeID.Text;
            pokemon.name = txtPokemonName.Text;
            pokemon.height = txtPokeHeight.Text;
            pokemon.weight = txtPokeWeight.Text;
            pokemon.category = txtCategory.Text;
            pokemon.imageurl = pokemonImage.ImageLocation;

            pokemon.hp = Convert.ToInt32(txtHitPoint.Text);
            pokemon.attack = Convert.ToInt32(txtAttack.Text);
            pokemon.defense = Convert.ToInt32(txtDefense.Text);
            pokemon.special_attack = Convert.ToInt32(txtSpAttack.Text);
            pokemon.special_defense = Convert.ToInt32(txtSpDefense.Text);
            pokemon.speed = Convert.ToInt32(txtSpeed.Text);

            pokemon.base_exp = Convert.ToInt32(txtBaseExp.Text);

            pokemon.catch_rate = Convert.ToInt32(txtCatchRate.Text);

            pokemon.male_percentage = txtMalePercent.Text;
            pokemon.female_percentage = txtFemalePercentage.Text;
            pokemon.egg_groups = txtEggGroup.Text;
            pokemon.hatch_time = txtHatchTime.Text;

            pokemon.evolvedfrom = txtEvolveFrom.Text;
            pokemon.evolution_cause = txtEvolveReason.Text;

            pokemon.description = GetPokeDexArray();
            pokemon.type = GetTypeArray();
            pokemon.abilities = GetAbilitiesArray();
            pokemon.weaknesses = GetWeaknessArray();
            pokemon.catch_location = GetCatchLocationsArray();
            pokemon.ev = GetEVArray();
            pokemon.evolutions = GetEvolutionsArray();

            if(selectedIndex != -1)
            {
                pokemons[selectedIndex] = pokemon;
            }
            else
            {
                Array.Resize<Pokemon>(ref pokemons, pokemons.Length + 1);
                pokemons[pokemons.Length - 1] = pokemon;
            }
        }

        private void ClearControl()
        {
            txtPokeID.Text = "";
            txtPokemonName.Text = "";
            txtPokeHeight.Text = "";
            txtPokeWeight.Text = "";
            txtCategory.Text = "";
            pokemonImage.ImageLocation = null;

            txtHitPoint.Text = "";
            txtAttack.Text = "";
            txtDefense.Text = "";
            txtSpAttack.Text = "";
            txtSpDefense.Text = "";
            txtSpeed.Text = "";

            txtBaseExp.Text = "";

            txtCatchRate.Text = "";

            txtMalePercent.Text = "";
            txtFemalePercentage.Text = "";
            txtEggGroup.Text = "";
            txtHatchTime.Text = "";

            txtEvolveFrom.Text = "";
            txtEvolveReason.Text = "";

            txtPokeID.Text = "";

            listPokedex.Items.Clear();
            listPokeTypes.Items.Clear();
            listAbilities.Items.Clear();
            listWeakness.Items.Clear();
            listCatchLocation.Items.Clear();
            listEV.Items.Clear();
            listEvolutions.Items.Clear();
        }

        private void PublishData()
        {
            try
            {
                string json = JsonConvert.SerializeObject(pokemons, Formatting.Indented);

                using (StreamWriter sw = new StreamWriter(jsonFile, false))
                {
                    sw.Write(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PokeDex[] GetPokeDexArray()
        {
            PokeDex[] pokeDexes = new  PokeDex[listPokedex.Items.Count];
            var index = 0;
            foreach (var item in listPokedex.Items)
            {
                string version = item.ToString().Split('-')[0].Split(':')[1].Trim();
                string pokeDexEntry = item.ToString().Split('-')[1].Trim();
                pokeDexes[index] = new PokeDex() { entry = pokeDexEntry, version = version };
                index++;
            }
            return pokeDexes;
        }

        private string[] GetTypeArray()
        {
            string[] typeArray = new string[listPokeTypes.Items.Count];
            for (int i = 0; i < listPokeTypes.Items.Count; i++)
            {
                typeArray[i] = listPokeTypes.Items[i].ToString();
            }
            return typeArray;
        }

        public string[] GetWeaknessArray()
        {
            string[] weaknessArray = new string[listWeakness.Items.Count];
            for(int i = 0;i < listWeakness.Items.Count; i++)
            {
                weaknessArray[i] = listWeakness.Items[i].ToString();
            }
            return weaknessArray;
        }

        public string[] GetAbilitiesArray()
        {
            string[] abilitiesArray = new string[listAbilities.Items.Count];
            for( int i = 0;i < listAbilities.Items.Count; i++)
            {
                abilitiesArray[i] = listAbilities.Items[i].ToString();
            }
            return abilitiesArray;
        }
        
        public EV[] GetEVArray()
        {
            EV[] evArray = new EV[listEV.Items.Count];
            for(int i = 0; i< listEV.Items.Count; i++)
            {
                string stat = listEV.Items[i].ToString().Split('-')[0].Trim();
                string evValue = listEV.Items[i].ToString().Split('-')[1].Trim();
                EV ev = new EV() { stat = stat, ev_value = Convert.ToInt32(evValue) };
                evArray[i] = ev;
            }
            return evArray;
        }

        public CatchLocation[] GetCatchLocationsArray()
        {
            CatchLocation[] catchLocationsArray = new CatchLocation[listCatchLocation.Items.Count];
            for(int i=0; i < listCatchLocation.Items.Count; i++)
            {
                string game = listCatchLocation.Items[i].ToString().Split('-')[0].Trim();
                string location = listCatchLocation.Items[i].ToString().Split('-')[1].Trim();
                CatchLocation catchLocation = new CatchLocation()
                {
                    game = game,
                    location = location.Split(',')
                };
                catchLocationsArray[i] = catchLocation;
            }
            return catchLocationsArray;
        }

        public string[] GetEvolutionsArray()
        {
            string[] evolutionsArray = new string[listEvolutions.Items.Count];
            for( int i=0; i < listEvolutions.Items.Count; i++)
            {
                evolutionsArray[i] = listEvolutions.Items[i].ToString();
            }
            return evolutionsArray;
        }

        public int AddTotalStats()
        {
            try
            {
                int hitPoint = Convert.ToInt32(txtHitPoint.Text);
                int attack = Convert.ToInt32(txtAttack.Text);
                int defense = Convert.ToInt32(txtDefense.Text);
                int spAttack = Convert.ToInt32(txtSpAttack.Text);
                int spDefense = Convert.ToInt32(txtSpDefense.Text);
                int speed = Convert.ToInt32(txtSpeed.Text);

                return hitPoint + attack + defense + spAttack + spDefense + speed;
            }
            catch(Exception ex)
            {                                                     
                return 0;
            }
        }
        private void txtHitPoint_TextChanged(object sender, EventArgs e)
        {
            int total = AddTotalStats();
            totalStat.Text = String.Format("Total: {0}", total);
        }

        private void txtSpAttack_TextChanged(object sender, EventArgs e)
        {
            int total = AddTotalStats();
            totalStat.Text = String.Format("Total: {0}", total);
        }

        private void txtSpDefense_TextChanged(object sender, EventArgs e)
        {
            int total = AddTotalStats();
            totalStat.Text = String.Format("Total: {0}", total);
        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {
            int total = AddTotalStats();
            totalStat.Text = String.Format("Total: {0}", total);
        }

        private void txtDefense_TextChanged(object sender, EventArgs e)
        {
            int total = AddTotalStats();
            totalStat.Text = String.Format("Total: {0}", total);
        }

        private void txtAttack_TextChanged(object sender, EventArgs e)
        {
            int total = AddTotalStats();
            totalStat.Text = String.Format("Total: {0}", total);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons.Where(p => p.name == txtPokemonName.Text).SingleOrDefault();
            if (selectedPokemon != null)
            {
                selectedIndex = Array.IndexOf(pokemons, selectedPokemon);
                LoadData(selectedPokemon);
            }
            else
            {
                MessageBox.Show("Pokemon Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextPokemon_Click(object sender, EventArgs e)
        {
            selectedIndex++;
            selectedPokemon = pokemons[selectedIndex];
            txtPokemonName.Text = selectedPokemon.name;
            LoadData(selectedPokemon);
        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            pokemonImage.ImageLocation = txtPokeImageURL.Text;
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(AddType.PokeTypes, listPokeTypes);
            addForm.Show();
        }

        private void btnRemoveType_Click(object sender, EventArgs e)
        {
            listPokeTypes.Items.Remove(listPokeTypes.SelectedItem);
        }

        private void btnAddWeakness_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(AddType.Weakness, listWeakness);
            addForm.Show();
        }

        private void btnRemoveWeakness_Click(object sender, EventArgs e)
        {
            listWeakness.Items.Remove(listWeakness.SelectedItem);
        }

        private void btnAddAbilities_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(AddType.Abilities, listAbilities);
            addForm.Show();
        }

        private void btnRemoveAbilities_Click(object sender, EventArgs e)
        {
            listAbilities.Items.Remove(listAbilities.SelectedItem);
        }

        private void btnAddCatchLocation_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(AddType.CatchLocation, listCatchLocation);
            addForm.Show();
        }

        private void btnRemoveCatchLocation_Click(object sender, EventArgs e)
        {
            listCatchLocation.Items.Remove(listCatchLocation.SelectedItem);
        }
        private void btnAddEV_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(AddType.EV, listEV);
            addForm.Show();
        }

        private void btnJSONViewer_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(pokemons, Formatting.Indented);
            JSONViewer jViewer = new JSONViewer(json);
            jViewer.Show();
        }

        private void btnAddEvolution_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(AddType.Evolution, listEvolutions);
            addForm.Show();
        }

        private void btnRemoveEvolution_Click(object sender, EventArgs e)
        {
            listEvolutions.Items.Remove(listEvolutions.SelectedItem);
        }

        private void btnSavePokeData_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
                MessageBox.Show("Save Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPublishPokeData_Click(object sender, EventArgs e)
        {
            try
            {
                PublishData();
                MessageBox.Show("Publish Successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            try
            {
                jsonFile = txtJsonFile.Text;
                using (StreamReader r = new StreamReader(jsonFile))
                {
                    string json = r.ReadToEnd();
                    pokemons = JsonConvert.DeserializeObject<Pokemon[]>(json);
                }
                MessageBox.Show("JSON Load Successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveEV_Click(object sender, EventArgs e)
        {
            listEV.Items.Remove(listEV.SelectedItem);
        }

        private void pokeDexEditor_Closed(dynamic sender, EventArgs e)
        {
            this.selectedPokemon.description = sender.pokeDexEntries;
            LoadData(this.selectedPokemon);
        }

        private void btnEditPokedex_Click(object sender, EventArgs e)
        {
            PokedexEditor editorForm = new PokedexEditor(this.selectedPokemon.description);
            editorForm.Show();
            editorForm.FormClosed += new FormClosedEventHandler(pokeDexEditor_Closed);
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            txtPokeID.ReadOnly = false;
            ClearControl();
            this.selectedIndex = -1;
        }
    }

}