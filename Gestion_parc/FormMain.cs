using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Gestion_parc
{
    public partial class FormMain : Form
    {
        Themes MyTheme = new Themes();
        public FormMain()
        {
            InitializeComponent();
        }
        private void ApplyTheme(Themes.ColorTheme T)
        {
            MyTheme.SelectedTheme = T;
            PanelMenu.FillColor = MyTheme.Primary1;
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadForm(Form form)
        {
            PanelContent.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(form);
            labelTitle.Hide();
            form.Show();
        }
        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                ButtonMaximize.BackgroundImage = Properties.Resources.shrink_Standard;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                ButtonMaximize.BackgroundImage = Properties.Resources.maximize_Standard;
            }
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonVehicule_Click(object sender, EventArgs e)
        {
            LoadForm(new FormVehicules());
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyTheme(Themes.ColorTheme.Standard);
        }

    }
}
