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
    public partial class FormMissions : Form
    {
        public FormMissions()
        {
            InitializeComponent();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AddMission add = new AddMission();
                add.Owner = this;
                add.StartPosition = FormStartPosition.CenterScreen;
                add.TopMost = true;
                add.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
