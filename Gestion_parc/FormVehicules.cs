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
using System.Data.SqlClient;

namespace Gestion_parc
{
    public partial class FormVehicules : Form
    {
        public FormVehicules()
        {
            InitializeComponent();
            
        }
        SqlConnection cnx = new SqlConnection(ConnectionManager.cs);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataTable table = new DataTable();

        private bool Search(string matricule)
        {
            bool result = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicule WHERE (matricule = '" + matricule + "');", cnx);
            cnx.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                result = true;
            }
            cnx.Close();
            return result;
        }

        public void RemplirGrid()
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand("select V.matricule, V.Modele, TV.nomType, M.nomMarque, SV.nomStatus   from Vehicule V,TypeVehicule TV, Marque M, StatusVehicule SV where V.typeVehicule = TV.idType and M.idMarque = V.Marque and V.statusVehicule = SV.idStatus;", cnx);
                reader = cmd.ExecuteReader();
                table.Load(reader);
                DataGridViewVehicule.DataSource = table;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton()
        {
            DataGridViewButtonColumn VoirPlus = new DataGridViewButtonColumn();
            VoirPlus.Name = "VoirPlus";
            VoirPlus.Text = "VoirPlus";
            VoirPlus.UseColumnTextForButtonValue = true;
            //if (DataGridViewFonctionnaires.Columns["Delete"] == null)
            //{
            DataGridViewVehicule.Columns.Insert(5, VoirPlus);
            VoirPlus.FlatStyle = FlatStyle.Popup;
            VoirPlus.DefaultCellStyle.ForeColor = Color.Navy;
            VoirPlus.DefaultCellStyle.BackColor = Color.Yellow;
            //}
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.Name = "Update";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            //if (DataGridViewFonctionnaires.Columns["Delete"] == null)
            //{
            DataGridViewVehicule.Columns.Insert(6, Update);
            Update.FlatStyle = FlatStyle.Popup;
            Update.DefaultCellStyle.ForeColor = Color.Navy;
            Update.DefaultCellStyle.BackColor = Color.Yellow;
            //}
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Delete";
            uninstallButtonColumn.Text = "Delete";
            uninstallButtonColumn.UseColumnTextForButtonValue = true;
            //if (DataGridViewFonctionnaires.Columns["Delete"] == null)
            //{
            DataGridViewVehicule.Columns.Insert(7, uninstallButtonColumn);
            uninstallButtonColumn.FlatStyle = FlatStyle.Popup;
            uninstallButtonColumn.DefaultCellStyle.ForeColor = Color.Navy;
            uninstallButtonColumn.DefaultCellStyle.BackColor = Color.Yellow;
            //}
        }
        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AddVehicule add = new AddVehicule();
                add.StartPosition = FormStartPosition.CenterScreen;
                add.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FormVehicules_Load(object sender, EventArgs e)
        {
            RemplirGrid();
            addButton();
        }

        private void TextBoxMatricule_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    if (table.Rows != null)
                    {
                        table.Clear();
                    }
                    cnx.Open();
                    cmd = new SqlCommand("select V.matricule, V.Modele, TV.nomType, M.nomMarque, SV.nomStatus   from Vehicule V,TypeVehicule TV, Marque M, StatusVehicule SV where V.typeVehicule = TV.idType and M.idMarque = V.Marque and V.statusVehicule = SV.idStatus AND V.matricule='" + TextBoxMatricule.Text + "'", cnx);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    DataGridViewVehicule.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
        private void DataGridViewVehicule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var senderGrid = (DataGridView)sender;
            
            //  try 
            //  {
            //      if (e.ColumnIndex == senderGrid.Columns["VoirPlus"].Index && e.RowIndex >= 0)
            //      {
            //        EditVehicule Edit = new EditVehicule();
            //        Edit.Owner = this;
            //        Edit.StartPosition = FormStartPosition.CenterScreen;
            //        Edit.ShowDialog();
            //  }
            //      }
            //  catch (Exception ex)
            //  {
            //      MessageBox.Show(ex.Message);
            //  }

            
              if (e.ColumnIndex == ((DataGridView)sender).Columns["VoirPlus"].Index)
              {
                  try
                  {
                      AffichageVehicule Affichage = new AffichageVehicule(DataGridViewVehicule.Rows[e.RowIndex].Cells["matricule"].Value.ToString());
                      Affichage.Owner = this;
                      Affichage.StartPosition = FormStartPosition.CenterScreen;
                      Affichage.ShowDialog();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }
              }
              if (e.ColumnIndex == ((DataGridView)sender).Columns["Update"].Index)
              {
                  try
                  {
                      EditVehicule add = new EditVehicule(DataGridViewVehicule.Rows[e.RowIndex].Cells["matricule"].Value.ToString());
                      add.Owner = this;
                      add.StartPosition = FormStartPosition.CenterScreen;
                      add.ShowDialog();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }
              }
              if (e.ColumnIndex == ((DataGridView)sender).Columns["Delete"].Index)
              {
                  try
                  {
                      var value = DataGridViewVehicule.Rows[e.RowIndex].Cells["matricule"].Value.ToString();
                      cnx.Open();
                      cmd = new SqlCommand("delete from Vehicule where matricule='" + value + "'",cnx);
                      cmd.ExecuteNonQuery();
                      cnx.Close();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }
              }
        }

       
    }
}
