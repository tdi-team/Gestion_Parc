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

        //private void RempirGrid()
        //{
        //    try
        //    {
        //        cnx.Open();
        //        cmd = new SqlCommand("select * from Vehicule;", cnx);
        //        reader = cmd.ExecuteReader();
        //        table.Load(reader);
        //        DataGridViewVehicule.DataSource = table;
        //        cnx.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void Had lcod ghadi ykon fost TextBoxChanged machi fonction()
        //{ 
        //    ---ndiro recheche b matricule machi modele----
        //    try
        //    {
        //        if (Search(TextBoxModele.Text))
        //            throw new Exception("matricule dejâ exist");
        //        else
        //        {
        //            if (table.Rows != null)
        //            {
        //                table.Clear();
        //            }
        //            cnx.Open();
        //            cmd = new SqlCommand("select * from Vehicule where matricule='" + TextBoxModele.Text + "'", cnx);
        //            reader = cmd.ExecuteReader();
        //            table.Load(reader);
        //            DataGridViewVehicule.DataSource = table;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        cnx.Close();
        //    }
        //}
        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AddVehicule add = new AddVehicule();
                add.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void FormVehicules_Load(object sender, EventArgs e)
        {
            //RempirGrid();
        }

       
    }
}
