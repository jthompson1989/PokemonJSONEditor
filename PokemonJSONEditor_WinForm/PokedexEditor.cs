using PokemonJSONEditor_WinForm.Models;
using Newtonsoft.Json;

namespace PokemonJSONEditor_WinForm
{
    public partial class PokedexEditor : Form
    {
        public PokeDex[] pokeDexEntries;
        int selectedIndex;
        public PokedexEditor(PokeDex[] pokeDexEntries)
        {
            InitializeComponent();
            this.pokeDexEntries = pokeDexEntries;
            LoadListBox();
            txtPokeDexJSON.Text = ConvertToJSON();
        }

        private void listPokeDexEntry_SelectedIndexChanged(dynamic sender, EventArgs e)
        {
            this.selectedIndex = sender.SelectedIndex;
            if(pokeDexEntries.Length > 0)
            {
                string game = sender.SelectedItem.ToString().Split('-')[0].Split(':')[1].Trim();
                string description = sender.SelectedItem.ToString().Split('-')[1].Trim();

                txtPokeDexDescription.Text = description;
                txtPokeDexGame.Text = game;
            }
        }

        private void LoadListBox()
        {
            listPokeDexEntry.Items.Clear();
            foreach(var pokeDex in this.pokeDexEntries)
            {
                string pokeDexString = string.Format("Version:{0} - {1}", pokeDex.version, pokeDex.entry);
                listPokeDexEntry.Items.Add(pokeDexString);
            }
        }

        private string ConvertToJSON()
        {
            return JsonConvert.SerializeObject(this.pokeDexEntries, Formatting.Indented);
        }

        private string[] ConvertToStringArray()
        {
            string[] vs = new string[pokeDexEntries.Length];
            int i = 0;
            foreach (var pokeDex in this.pokeDexEntries)
            {
                if (!String.IsNullOrEmpty(pokeDex.entry))
                {
                    string pokeDexString = string.Format("Version:{0} - {1}", pokeDex.version, pokeDex.entry);
                    listPokeDexEntry.Items.Add(pokeDexString);
                    vs[i] = pokeDexString;
                }
            }
            return vs;
        }

        private PokeDex[] ConvertToPokeDexArray()
        {
            string json = txtPokeDexJSON.Text;
            PokeDex[] pokeDex = JsonConvert.DeserializeObject<PokeDex[]>(json);
            return pokeDex;
        }

        private void btnSavePokeDex_Click(object sender, EventArgs e)
        {
            if(this.selectedIndex > -1)
            {
                this.pokeDexEntries[this.selectedIndex].version = txtPokeDexGame.Text;
                this.pokeDexEntries[this.selectedIndex].entry = txtPokeDexDescription.Text;
                LoadListBox();
            }
        }

        private void btnNewPokeDexEntry_Click(object sender, EventArgs e)
        {
            PokeDex pokeDex = new PokeDex();
            pokeDex.version = txtPokeDexGame.Text;
            pokeDex.entry = txtPokeDexDescription.Text;

            List<PokeDex> pd = this.pokeDexEntries.ToList<PokeDex>();
            pd.Add(pokeDex);

            this.pokeDexEntries = pd.ToArray();
            LoadListBox();
        }

        private void btnSavePokeDexJson_Click(object sender, EventArgs e)
        {
            this.pokeDexEntries = ConvertToPokeDexArray();
        }
    }
}
