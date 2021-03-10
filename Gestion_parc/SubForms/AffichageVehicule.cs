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
    public partial class AffichageVehicule : Form
    {
        public AffichageVehicule(string matricule)
        {
            InitializeComponent();
            Matricule = matricule;
            TextBoxMatricule.Text = Matricule;
            RemplirCombo();
            remplire();
        }
        SqlConnection cnx = new SqlConnection(ConnectionManager.cs);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataTable tableType = new DataTable();
        DataTable tableMarqe = new DataTable();
        DataTable tableSatut = new DataTable();
        private string Matricule;

        public void RemplirCombo()
        {
            try
            {
                tableType.Columns.Add("idType", typeof(int));
                tableType.Columns.Add("nomType", typeof(string));
                tableType.Rows.Add(0, "select");
                tableMarqe.Columns.Add("idMarque", typeof(int));
                tableMarqe.Columns.Add("nomMarque", typeof(string));
                tableMarqe.Rows.Add(0, "select");
                tableSatut.Columns.Add("idStatus", typeof(int));
                tableSatut.Columns.Add("nomStatus", typeof(string));
                tableSatut.Rows.Add(0, "select");
                cnx.Open();
                cmd = new SqlCommand("select * from TypeVehicule;", cnx);
                reader = cmd.ExecuteReader();
                tableType.Load(reader);
                ComboBoxType.DataSource = tableType;
                cmd = new SqlCommand("select * from Marque;", cnx);
                reader = cmd.ExecuteReader();
                tableMarqe.Load(reader);
                ComboBoxMarque.DataSource = tableMarqe;
                cmd = new SqlCommand("select * from StatusVehicule;", cnx);
                reader = cmd.ExecuteReader();
                tableSatut.Load(reader);
                ComboBoxStatut.DataSource = tableSatut;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ComboBoxType.ValueMember = "idType";
                ComboBoxType.DisplayMember = "nomType";
                ComboBoxMarque.ValueMember = "idMarque";
                ComboBoxMarque.DisplayMember = "nomMarque";
                ComboBoxStatut.ValueMember = "idStatus";
                ComboBoxStatut.DisplayMember = "nomStatus";
                cnx.Close();
            }
        }
        private void remplire()
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand("select * from Vehicule where matricule = '" + Matricule + "';", cnx);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TextBoxMatricule.Text = reader[1].ToString();
                    ComboBoxType.SelectedValue = int.Parse(reader[2].ToString());
                    DateTimePickerAquisition.Text = reader[3].ToString();
                    ComboBoxMarque.SelectedValue = int.Parse(reader[4].ToString());
                    TextBoxModele.Text = reader[5].ToString();
                    ComboBoxStatut.SelectedValue = int.Parse(reader[6].ToString());
                    TextBoxNivCarb.Text = reader[7].ToString();
                    TrackBarNivCarb.Value = int.Parse(reader[7].ToString());
                    TextBoxKilometrage.Text = reader[8].ToString();
                    TextBoxConsomage.Text = reader[9].ToString();
                    TextBoxHorsePower.Text = reader[10].ToString();
                    TextBoxCapacite.Text = reader[11].ToString();
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TrackBarNivCarb_Scroll(object sender, ScrollEventArgs e)
        {
            TextBoxNivCarb.Text = TrackBarNivCarb.Value.ToString();
        }

        private void TextBoxNivCarb_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxNivCarb.Text != string.Empty)
            {
                int nc = int.Parse(TextBoxNivCarb.Text);
                if (nc >= 0 && nc <= 100)
                {
                    TrackBarNivCarb.Value = nc;
                }
                else
                {
                    MessageBox.Show("Valeur doit etre entre 0 et 100");
                }
            }
        }

        private void TrackBarNivCarb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
