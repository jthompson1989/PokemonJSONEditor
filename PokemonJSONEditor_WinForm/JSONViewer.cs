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
    public partial class JSONViewer : Form
    {
        public JSONViewer(string JSON)
        {
            InitializeComponent();
            txtJsonViewer.Text = JSON;
        }
    }
}
