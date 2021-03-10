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
    public partial class FormFonctionnaires : Form
    {
        public FormFonctionnaires()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(ConnectionManager.cs);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataTable table = new DataTable();

        private bool Search(string CIN)
        {
            bool result = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Fonctionnaire WHERE (CIN = '" + CIN + "');", cnx);
            SqlDataReader dr;
            cnx.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
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
                if (table.Rows.Count != 0)
                {
                    table.Clear();
                }
                cnx.Open();
                cmd = new SqlCommand("select F.CIN,F.Nom,F.Prenom,F.Sexe ,G.nomGrade,S.nomService from  Fonctionnaire F,Grade G ,_Service S where F.idGrade=G.idGrade and F.idService=S.idService;", cnx);
                reader = cmd.ExecuteReader();
                table.Load(reader);
                DataGridViewFonctionnaires.DataSource = table;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addButon()
        {
            DataGridViewButtonColumn VoirPlus = new DataGridViewButtonColumn();
            VoirPlus.Name = "VoirPlus";
            VoirPlus.Text = "VoirPlus";
            VoirPlus.UseColumnTextForButtonValue = true;
            //if (DataGridViewFonctionnaires.Columns["Delete"] == null)
            //{
            DataGridViewFonctionnaires.Columns.Insert(6, VoirPlus);
            VoirPlus.FlatStyle = FlatStyle.Popup;
            VoirPlus.DefaultCellStyle.ForeColor = Color.Navy;
            VoirPlus.DefaultCellStyle.BackColor = Color.Yellow;
            //}
            DataGridViewButtonColumn Upadte = new DataGridViewButtonColumn();
            Upadte.Name = "Update";
            Upadte.Text = "Update";
            Upadte.UseColumnTextForButtonValue = true;
            //if (DataGridViewFonctionnaires.Columns["Delete"] == null)
            //{
            DataGridViewFonctionnaires.Columns.Insert(7, Upadte);
            Upadte.FlatStyle = FlatStyle.Popup;
            Upadte.DefaultCellStyle.ForeColor = Color.Navy;
            Upadte.DefaultCellStyle.BackColor = Color.Yellow;
            //}
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Delete";
            uninstallButtonColumn.Text = "Delete";
            uninstallButtonColumn.UseColumnTextForButtonValue = true;
            //if (DataGridViewFonctionnaires.Columns["Delete"] == null)
            //{
            DataGridViewFonctionnaires.Columns.Insert(8, uninstallButtonColumn);
            uninstallButtonColumn.FlatStyle = FlatStyle.Popup;
            uninstallButtonColumn.DefaultCellStyle.ForeColor = Color.Navy;
            uninstallButtonColumn.DefaultCellStyle.BackColor = Color.Yellow;
            //}
        }
        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AddFonctionnaire add = new AddFonctionnaire();
                add.Owner = this;
                add.StartPosition = FormStartPosition.CenterScreen;
                add.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormFonctionnaires_Load(object sender, EventArgs e)
        {
            RemplirGrid();
            addButon();
        }

        private void DataGridViewFonctionnaires_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ((DataGridView)sender).Columns["VoirPlus"].Index)
            {
                try
                {
                    AffichageFonctionnaire add = new AffichageFonctionnaire(DataGridViewFonctionnaires.Rows[e.RowIndex].Cells["CIN"].Value.ToString());
                    add.Owner = this;
                    add.StartPosition = FormStartPosition.CenterScreen;
                    add.ShowDialog();
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
                    EditFonctionnaire add = new EditFonctionnaire(DataGridViewFonctionnaires.Rows[e.RowIndex].Cells["CIN"].Value.ToString());
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
                    var Ci = DataGridViewFonctionnaires.Rows[e.RowIndex].Cells["CIN"].Value.ToString();
                    cnx.Open();
                    cmd = new SqlCommand("delete from Fonctionnaire where CIN = '" + Ci + "' ", cnx);
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    RemplirGrid();
                    MessageBox.Show("Delete Sucssefly");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TextBoxCIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (table.Rows != null)
                {
                    table.Clear();
                }
                cnx.Open();
                cmd = new SqlCommand("select F.CIN,F.Nom,F.Prenom,F.Sexe ,G.nomGrade,S.nomService from  Fonctionnaire F,Grade G ,_Service S where F.idGrade=G.idGrade and F.idService=S.idService AND F.CIN='" + TextBoxCIN.Text + "'", cnx);
                reader = cmd.ExecuteReader();
                table.Load(reader);
                DataGridViewFonctionnaires.DataSource = table;
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
    }
}
