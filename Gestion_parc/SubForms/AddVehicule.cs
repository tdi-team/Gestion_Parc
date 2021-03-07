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
    public partial class AddVehicule : Form
    {
        public AddVehicule()
        {
            InitializeComponent();
            RemplirCombo();
        }

        SqlConnection cnx = new SqlConnection(ConnectionManager.cs);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataTable tableType = new DataTable();
        DataTable tableMarqe = new DataTable();
        DataTable tableSatut = new DataTable();

        public void RemplirCombo()
        {
            try
            {
                tableType.Columns.Add("idType", typeof(int));
                tableType.Columns.Add("nomType", typeof(string));
                tableType.Rows.Add(0,"select");
                tableMarqe.Columns.Add("idMarque", typeof(int));
                tableMarqe.Columns.Add("nomMarque", typeof(string));
                tableMarqe.Rows.Add(0, "select");
                tableSatut.Columns.Add("idStatus", typeof(int));
                tableSatut.Columns.Add("nomStatus", typeof(string));
                tableSatut.Rows.Add(0, "select");
                cnx.Open();
                cmd = new SqlCommand("select * from TypeVehicule;",cnx);
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
                ComboBoxType.ValueMember     = "idType";
                ComboBoxType.DisplayMember   = "nomType";
                ComboBoxMarque.ValueMember   = "idMarque";
                ComboBoxMarque.DisplayMember = "nomMarque";
                ComboBoxStatut.ValueMember   = "idStatus";
                ComboBoxStatut.DisplayMember = "nomStatus";
                cnx.Close();
            }
        }

        private bool Search(string matricule)
        {
            bool result = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicule WHERE (matricule = '" + matricule + "');", cnx);
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Search(TextBoxMatricule.Text))
                    throw new Exception("matricule dejâ exist");
                if (TextBoxMatricule.Text == "")
                    throw new Exception("Merci de remplir votre matricule");
                if (int.Parse(ComboBoxType.SelectedValue.ToString()) == 0)
                    throw new Exception("Merci de choisir votre type");
                if (int.Parse(ComboBoxMarque.SelectedValue.ToString()) == 0)
                    throw new Exception("Merci de choisir votre marque");
                if (int.Parse(ComboBoxStatut.SelectedValue.ToString()) == 0)
                    throw new Exception("Merci de choisir votre status");
                if (DateTimePickerAquisition.Value > DateTime.Today)
                    throw new Exception("Merci d'ajouter une valide date");
                if (TextBoxModele.Text == "")
                    throw new Exception("Merci de remplir votre modele");
                if (TextBoxKilometrage.Text == "")
                    throw new Exception("Merci de remplir votre Kilometrage");
                if (TextBoxCapacite.Text == "")
                    throw new Exception("Merci de remplir votre Capacite");
                if (TextBoxHorsePower.Text == "")
                    throw new Exception("Merci de remplir votre HorsePower");
                if (TextBoxConsomage.Text == "" || TextBoxConsomage.Text.Length>2)
                    throw new Exception("Merci de remplir votre Consomage");
                else
                {
                    cnx.Open();
                    DateTime DateAquisition = Convert.ToDateTime(DateTimePickerAquisition.Text);
                    string Requtte = "insert into Vehicule values('" + TextBoxMatricule.Text + "'," + ComboBoxType.SelectedValue.ToString() + ",'" + DateAquisition.ToString("yyyy-MM-dd") + "'," + ComboBoxMarque.SelectedValue.ToString() + ",'" + TextBoxModele.Text + "'," + ComboBoxStatut.SelectedValue.ToString() + "," + TrackBarNivCarb.Value.ToString() + ", " + TextBoxKilometrage.Text + "," + TextBoxConsomage.Text + "," + TextBoxHorsePower.Text + "," + TextBoxCapacite.Text + ")";
                    cmd = new SqlCommand(Requtte, cnx);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cnx.Close();
            }
        }

        private void TextBoxNivCarb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
