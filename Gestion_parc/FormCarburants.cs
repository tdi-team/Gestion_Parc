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
    public partial class FormCarburants : Form
    {
        public FormCarburants()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(ConnectionManager.cs);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataTable table = new DataTable();
        public void RempirGrid()
        {
            try
            {
                if (table.Rows.Count != 0)
                {
                    table.Clear();
                }
                cnx.Open();
                cmd = new SqlCommand("select * from Carburants;", cnx);
                reader = cmd.ExecuteReader();
                table.Load(reader);
                DataGridViewCarburants.DataSource = table;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AddCarburant add = new AddCarburant();
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

        private void FormCarburants_Load(object sender, EventArgs e)
        {
            RempirGrid();
        }
    }
}
