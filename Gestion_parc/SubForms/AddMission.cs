using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DataLibrary.Models;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace Gestion_parc.SubForms
{
    public partial class AddMission : Form
    {
        List<Fonctionnaire> listF = new List<Fonctionnaire>();
        List<Vehicule> listV = new List<Vehicule>();
        AutoCompleteStringCollection acFonctionnaires = new AutoCompleteStringCollection();
        AutoCompleteStringCollection acVehicules = new AutoCompleteStringCollection();
        public AddMission()
        {
            InitializeComponent();
            using (IDbConnection connection = new SqlConnection(ConnectionManager.cs))
            {
                listV = connection.Query<Vehicule>("SELECT * FROM Vehicule;").ToList();
                listF = connection.Query<Fonctionnaire>("SELECT * FROM Fonctionnaire;").ToList();
            }
            foreach (string item in listF.Select(x => x.FullName).ToList())
            {
                acFonctionnaires.Add(item);
            }
            foreach (var item in listV.Select(x => x.Modele).ToList())
            {
                acVehicules.Add(item);
            }
            TextBoxFonctionnaires.AutoCompleteCustomSource = acFonctionnaires;
            TextBoxVehicules.AutoCompleteCustomSource = acVehicules;
        }

        private void TextBoxFonctionnaires_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxFonctionnaires.Text != "" && acFonctionnaires.Contains(TextBoxFonctionnaires.Text))
                {
                    Guna2Chip chip = new Guna2Chip();
                    chip.Text = TextBoxFonctionnaires.Text;
                    chip.FillColor = Color.FromArgb(247, 158, 62);
                    PanelFonctionnaires.Controls.Add(chip);
                    TextBoxFonctionnaires.Clear();
                    acFonctionnaires.Remove(chip.Text);
                }

            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionManager.cs))
            {
                Mission M = new Mission();
                M.LieuDepart = TextBoxDepart.Text;
                M.Destination = TextBoxDestination.Text;
                M._Object = TextBoxObjet.Text;
                M.DateDepart = DateTimePickerDepart.Value.Date;
                M.DateRetour = DateTimePickerRetour.Value.Date;
                M.Distance = int.Parse(TextBoxDistance.Text);
            }
        }

        private void PanelFonctionnaires_ControlRemoved(object sender, ControlEventArgs e)
        {
            acFonctionnaires.Add(e.Control.Text);
        }
    }
}
