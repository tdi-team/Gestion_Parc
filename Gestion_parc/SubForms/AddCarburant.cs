using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Gestion_parc.SubForms
{
    public partial class AddCarburant : Form
    {
        public AddCarburant()
        {
            InitializeComponent();
        }
        DataTable Vehicule = new DataTable();
        AutoCompleteStringCollection autoVehicule = new AutoCompleteStringCollection();
        SqlDataReader reader;
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(DateTimePickerRemplissage.Text);
            using (SqlConnection cnx = new SqlConnection(ConnectionManager.cs))
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("insert into Carburants values('" + ComboBoxTypeC.Text + "','" + TextBoxPrix.Text + "',(select idVehicule from Vehicule where matricule='" + TextBoxMatricule.Text + "'),'" + date.ToString("yyyy-MM-dd") + "','" + TextBoxQuantité.Text + "')");
                cmd.Connection = cnx;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                MessageBox.Show("ajout avec succé");
            }
        }

        private void AddCarburant_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionManager.cs))
            {
                cnx.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT matricule  from Vehicule ", cnx);
                reader = cmd2.ExecuteReader();
                Vehicule.Load(reader);

            }
            foreach (DataRow R in Vehicule.Rows)
            {
                int i = Vehicule.Rows.IndexOf(R);
                autoVehicule.Add(Vehicule.Rows[i]["matricule"].ToString());
            }
            TextBoxMatricule.AutoCompleteCustomSource = autoVehicule;
            DateTime date = Convert.ToDateTime(DateTimePickerRemplissage.Text);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');
        }

        private void TextBoxQuantité_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');
        }
    }
}
