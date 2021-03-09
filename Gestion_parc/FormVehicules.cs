using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Dapper;
using DataLibrary.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_parc.SubForms;
using Guna.UI2.WinForms;

namespace Gestion_parc
{
    public partial class FormVehicules : Form
    {
        public FormVehicules()
        {
            InitializeComponent();
            using (IDbConnection connection = new SqlConnection(ConnectionManager.cs))
            {
                List<Vehicule> list = connection.Query<Vehicule>("SELECT * FROM Vehicule;").ToList();
                DataGridViewVehicule.DataSource = list.Select(x => new
                {
                    x.matricule,
                    x.Marque,
                    x.Modele,
                    status = x.statusVehicule
                }).ToList();
            }
            //add columns to dgv
            DataGridViewButtonColumn c = new DataGridViewButtonColumn();
            c.Name = "Delete";
            c.FlatStyle = FlatStyle.Popup;
            c.Text = "Delete";
            c.UseColumnTextForButtonValue = true;
            DataGridViewVehicule.Columns.Add(c);
            DataGridViewButtonColumn c2 = new DataGridViewButtonColumn();
            c2.Name = "Update";
            c2.FlatStyle = FlatStyle.Popup;
            c2.Text = "Update";
            c2.UseColumnTextForButtonValue = true;
            DataGridViewVehicule.Columns.Add(c2);
            
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AddVehicule add = new AddVehicule();
                add.Owner = this;
                add.StartPosition = FormStartPosition.CenterScreen;
                add.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewVehicule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridViewVehicule.Columns["Update"].Index && e.RowIndex >= 0)
            {
                EditVehicule f = new EditVehicule();
                f.ShowDialog();
            }
            if (e.ColumnIndex == DataGridViewVehicule.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("You sure ?", "Delete", MessageBoxButtons.YesNo);
            }
        }
    }
}
