using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_parc.SubForms
{
    public partial class AddVehicule : Form
    {
        public AddVehicule()
        {
            InitializeComponent();
        }

        private void TrackBarNivCarb_Scroll(object sender, ScrollEventArgs e)
        {
            TextBoxNivCarb.Text = TrackBarNivCarb.Value.ToString();
        }

        private void TextBoxNivCarb_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxNivCarb.Text != string.Empty)
            {
                int nc = int.Parse(TextBoxNivCarb.Text);
                if (nc >= 0 && nc <= 100)
                {
                    TrackBarNivCarb.Value = nc;
                }
                else
                {
                    MessageBox.Show("Valeur doit etre entre 0 et 100");
                }
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNivCarb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
