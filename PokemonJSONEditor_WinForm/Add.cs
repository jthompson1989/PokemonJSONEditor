

namespace PokemonJSONEditor_WinForm
{
    public partial class Add : Form
    {
        public ListBox selectedListBox;
        public Add(AddType addType, ListBox listBox)
        {
            InitializeComponent();
            this.selectedListBox = listBox;
            switch (addType)
            {
                case AddType.PokeTypes:
                    pokeTypeBox.Visible = true;
                    pokeTypeBox.Location = new Point(12, 12);
                    break;
                case AddType.Pokedex:
                    pokeDexAddBox.Visible = true;
                    pokeDexAddBox.Location = new Point(12, 12);
                    break;
                case AddType.Weakness:
                    weaknessBox.Visible = true;
                    weaknessBox.Location = new Point(12, 12);
                    break;
                case AddType.CatchLocation:
                    captureLocationBox.Visible = true;
                    captureLocationBox.Location = new Point(12, 12);
                    break;
                case AddType.Abilities:
                    abilitiesBox.Visible = true;
                    abilitiesBox.Location = new Point(12, 12);
                    break;
                case AddType.EV:
                    evBox.Visible = true;
                    evBox.Location = new Point(12, 12);
                    break;
                case AddType.Evolution:
                    evolutionBox.Visible = true;
                    evolutionBox.Location = new Point(12, 12);
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void btnSavePokedexEntry_Click(object sender, EventArgs e)
        {
            this.selectedListBox.Items.Add(String.Format("Version:{0} - {1}", 
                versionDropDown.SelectedItem.ToString(), txtPokedexEntry.Text));
            this.Close();
        }

        private void btnSavePokeType_Click(object sender, EventArgs e)
        {
            this.selectedListBox.Items.Add(txtPokeType.Text);
            this.Close();
        }

        private void btnSaveWeakness_Click(object sender, EventArgs e)
        {
            this.selectedListBox.Items.Add(txtWeakness.Text);
            this.Close();
        }

        private void btnSaveAbility_Click(object sender, EventArgs e)
        {
            this.selectedListBox.Items.Add(txtAbility.Text);
            this.Close();
        }

        private void btnSaveCaptureLocation_Click(object sender, EventArgs e)
        {
            this.selectedListBox.Items.Add(string.Format("{0} - {1}",
                locCapVersionDropDown.SelectedItem.ToString(), txtCaptureLocation.Text));
            this.Close();
        }

        private void btnSaveEV_Click(object sender, EventArgs e)
        {
            string stat = evStatDropDown.SelectedItem.ToString();
            string evValue = txtEVValue.Text;
            this.selectedListBox.Items.Add(string.Format("{0} - {1}", stat, evValue));
            this.Close();
        }

        private void btnSaveEvolutions_Click(object sender, EventArgs e)
        {
            this.selectedListBox.Items.Add(txtPokeIDEvolution.Text);
            this.Close();
        }
    }

    public enum AddType
    {
        Pokedex,
        Weakness,
        PokeTypes,
        Abilities,
        CatchLocation,
        EV,
        Evolution
    }
}
