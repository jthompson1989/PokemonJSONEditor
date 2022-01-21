using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonJSONEditor_WinForm
{
    public partial class Add : Form
    {
        public ListBox selectedListBox;
        public Add(AddType addType, ListBox listBox)
        {
            InitializeComponent();
            this.selectedListBox = listBox;
        }

        private void btnSavePokedexEntry_Click(object sender, EventArgs e)
        {
            this.selectedListBox.Items.Add(String.Format("Version:{0} - {1}", versionDropDown.SelectedItem.ToString(), txtPokedexEntry.Text));
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

        }
    }

    public enum AddType
    {
        Pokedex,
        Weakness,
        PokeTypes,
        Abilities,
        CatchLocation,
        EV
    }
}
