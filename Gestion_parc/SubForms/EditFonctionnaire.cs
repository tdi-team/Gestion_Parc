using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_parc.SubForms
{

    public partial class EditFonctionnaire : Form
    {
        SqlConnection cnx = new SqlConnection(ConnectionManager.cs);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataTable tableGrade = new DataTable();
        DataTable table = new DataTable();
        DataTable tableService = new DataTable();
        private string CIN;
        public EditFonctionnaire(string cin)
        {
            InitializeComponent();
            CIN = cin;
            TextBoxCIN.Text = CIN;
            RemplirCombo();
            remplire();
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
                    if (reader[4].ToString() == "HOMME")
                        RadioButtonHomme.Checked = true;
                    else
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
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCIN.Text == "")
                    throw new Exception("Merci de remplir votre CIN");
                if (TextBoxNom.Text == "")
                    throw new Exception("Merci de remplir votre NOM");
                if (TextBoxPrenom.Text == "")
                    throw new Exception("Merci de remplir votre PRENOM");
                if (TextBoxLieuNaissance.Text == "")
                    throw new Exception("Merci de remplir votre Lieu DE Naissence");
                if (int.Parse(ComboBoxGrade.SelectedValue.ToString()) == 0)
                    throw new Exception("Merci de choisir votre Grade");
                if (int.Parse(ComboBoxService.SelectedValue.ToString()) == 0)
                    throw new Exception("Merci de choisir votre SErvise");
                if (ComboBoxSituation.Text == "")
                    throw new Exception("Merci de choisir votre Situation");
                if (DateTimePickerNaissance.Value > DateTime.Today)
                    throw new Exception("Merci d'ajouter une valide date");
                if (TextBoxAdresse.Text == "")
                    throw new Exception("Merci de remplir votre Adresse");
                if (TextBoxTel.Text == "")
                    throw new Exception("Merci de remplir votre Tele");
                if (TextBoxEmail.Text == "")
                    throw new Exception("Merci de remplir votre Email");
                if (RadioButtonHomme.Checked == false && RadioButtonFemme.Checked == false)
                    throw new Exception("Merci de remplir votre genre");
                else
                {
                    string Genre = "";
                    if (RadioButtonHomme.Checked == true)
                    {
                        Genre = "Homme";
                    }
                    if (RadioButtonFemme.Checked == true)
                    {
                        Genre = "Femme";
                    }
                    cnx.Close();
                    cnx.Open();
                    DateTime DateNaissance = Convert.ToDateTime(DateTimePickerNaissance.Text);
                    DateTime DateRecrutement = Convert.ToDateTime(DateTimePickerRecruit.Text);
                    string Requtte = "update Fonctionnaire set Nom='" + TextBoxNom.Text + "',Prenom='" + TextBoxPrenom.Text + "',Sexe='" + Genre + "',SituationFamiliale='" + ComboBoxSituation.Text + "',DateNaissance='" + DateNaissance.ToString("yyyy-MM-dd") + "',LieuNaissance='" + TextBoxLieuNaissance.Text + "',DateRecrutement='" + DateRecrutement.ToString("yyyy-MM-dd") + "',Email='" + TextBoxEmail.Text + "',Tel='" + TextBoxTel.Text + "',Adresse='" + TextBoxAdresse.Text + "',idGrade='" + ComboBoxGrade.SelectedValue.ToString() + "',idService='" + ComboBoxService.SelectedValue.ToString() + "'where CIN='" + TextBoxCIN.Text + "'";
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
                this.Close();
                FormFonctionnaires FF = new FormFonctionnaires();
                FF.RemplirGrid();
            }
        }
        public void RemplirCombo()
        {
            try
            {
                //tableGrade.Columns.Add("idType", typeof(int));
                //tableGrade.Columns.Add("nomType", typeof(string));
                //tableGrade.Rows.Add(0, "select");
                //tableService.Columns.Add("idMarque", typeof(int));
                //tableService.Columns.Add("nomMarque", typeof(string));
                //tableService.Rows.Add(0, "select");
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
    }
}
