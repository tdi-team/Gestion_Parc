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
    public partial class AffichageFonctionnaire : Form
    {
        SqlConnection cnx = new SqlConnection(ConnectionManager.cs);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataTable tableGrade = new DataTable();
        DataTable table = new DataTable();
        DataTable tableService = new DataTable();
        private string CIN;
        public AffichageFonctionnaire(string cin)
        {
            InitializeComponent();
            CIN = cin;
            TextBoxCIN.Text = CIN;
            RemplirCombo();
            remplire();
        }

        public void RemplirCombo()
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand("select * from _Service;", cnx);
                reader = cmd.ExecuteReader();
                tableService.Load(reader);
                ComboBoxService.DataSource = tableService;
                cmd = new SqlCommand("select * from Grade;", cnx);
                reader = cmd.ExecuteReader();
                tableGrade.Load(reader);
                ComboBoxGrade.DataSource = tableGrade;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ComboBoxGrade.ValueMember = "idGrade";
                ComboBoxGrade.DisplayMember = "nomGrade";
                ComboBoxService.ValueMember = "idService";
                ComboBoxService.DisplayMember = "nomService";
                cnx.Close();
            }
        }

        private void remplire()
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand("select * from Fonctionnaire where CIN = '" + CIN + "';", cnx);
                reader = cmd.ExecuteReader();
                //table.Load(reader);
                while (reader.Read())
                {
                    TextBoxNom.Text = reader[2].ToString();
                    TextBoxPrenom.Text = reader[3].ToString();
                    if (reader[4].ToString() == "Homme")
                        RadioButtonHomme.Checked = true;
                    if (reader[4].ToString() == "Femme")
                        RadioButtonFemme.Checked = true;
                    ComboBoxSituation.Text = reader[5].ToString();
                    DateTimePickerNaissance.Text = reader[6].ToString();
                    TextBoxLieuNaissance.Text = reader[7].ToString();
                    DateTimePickerRecruit.Text = reader[8].ToString();
                    TextBoxEmail.Text = reader[9].ToString();
                    TextBoxTel.Text = reader[10].ToString();
                    TextBoxAdresse.Text = reader[11].ToString();
                    ComboBoxGrade.SelectedValue = int.Parse(reader[12].ToString());
                    ComboBoxService.SelectedValue = int.Parse(reader[13].ToString());
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AffichageFonctionnaire_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
