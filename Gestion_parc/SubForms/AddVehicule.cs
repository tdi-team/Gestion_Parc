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
            TrackBarNivCarb.Value = int.Parse(TextBoxNivCarb.Text);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            CustomMessageBox cf = new CustomMessageBox("are you sure?", "hhh");
            if (cf.DialogResult == System.Windows.Forms.DialogResult.Yes)
                MessageBox.Show("hhhhhhhhh");
        }
    }
}
