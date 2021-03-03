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
    public partial class EditVehicule : Form
    {
        public EditVehicule()
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

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
