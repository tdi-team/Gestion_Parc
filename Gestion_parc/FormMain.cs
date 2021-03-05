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
        string currentForm = "";
        public FormMain()
        {
            InitializeComponent();
        }
        private void ApplyTheme(Themes.ColorTheme T)
        {
            MyTheme.SelectedTheme = T;
            PanelMenu.FillColor = MyTheme.Primary1;
        }
        private void LoadForm(Form form)
        {
            if (form.Name != currentForm)
            {
                ButtonDisconnect.Controls.Clear();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                ButtonDisconnect.Controls.Add(form);
                labelTitle.Hide();
                form.Show();
                currentForm = form.Name;
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void ButtonHome_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFonctionnaires_Click(object sender, EventArgs e)
        {
            LoadForm(new FormFonctionnaires());
        }

        private void ButtonMissions_Click(object sender, EventArgs e)
        {
            LoadForm(new FormMissions());
        }

        private void ButtonCarburants_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMaintenance_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
