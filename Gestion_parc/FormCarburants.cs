using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_parc.SubForms;

namespace Gestion_parc
{
    public partial class FormCarburants : Form
    {
        public FormCarburants()
        {
            InitializeComponent();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AddCarburant add = new AddCarburant();
                add.Owner = this;
                add.StartPosition = FormStartPosition.CenterScreen;
                add.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
