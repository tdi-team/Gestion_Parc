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
    public partial class AddFonctionnaire : Form
    {
        public AddFonctionnaire()
        {
            InitializeComponent();
            RemplirCombo();
        }
        SqlConnection cnx = new SqlConnection(ConnectionManager.cs);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataTable tableGrade = new DataTable();
        DataTable tableService = new DataTable();

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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCIN.Text == "")
                    throw new Exception("Merci de remplir votre CIN");
                if (Search(TextBoxCIN.Text))
                    throw new Exception("CIN dejâ exist");
                if (TextBoxNOM.Text == "")
                    throw new Exception("Merci de remplir votre NOM");
                if (TextBoxPRENOM.Text == "")
                    throw new Exception("Merci de remplir votre PRENOM");
                if (TextBoxLieuNaissance.Text == "")
                    throw new Exception("Merci de remplir votre Lieu DE Naissence");
                if (int.Parse(ComboBoxGrade.SelectedValue.ToString()) == 0)
                    throw new Exception("Merci de choisir votre Grade");
                if (int.Parse(ComboBoxService.SelectedValue.ToString()) == 0)
                    throw new Exception("Merci de choisir votre SErvise");
                if (ComboBoxSituation.Text == "")
                    throw new Exception("Merci de choisir votre Situation");
                if (DateTimePickernaissance.Value > DateTime.Today)
                    throw new Exception("Merci d'ajouter une valide date");
                if (TextBoxADRESSE.Text == "")
                    throw new Exception("Merci de remplir votre Adresse");
                if (TextBoxTEL.Text == "")
                    throw new Exception("Merci de remplir votre Tele");
                if (TextBoxEMAIL.Text == "")
                    throw new Exception("Merci de remplir votre Email");
                if (RadioButtonHomme.Checked == false && RadioButtonFemme.Checked == false)
                    throw new Exception("Merci de remplir votre genre");
                else
                {
                    string genre;
                    if (RadioButtonHomme.Checked)
                        genre = "Homme";
                    else
                        genre = "Femme";
                    cnx.Open();
                    DateTime DateN = Convert.ToDateTime(DateTimePickernaissance.Text);
                    DateTime Daterecu = Convert.ToDateTime(DateTimePickerRecruit.Text);
                    string Requtte = "insert into Fonctionnaire values('" + TextBoxCIN.Text + "','" + TextBoxNOM.Text + "','" + TextBoxPRENOM.Text + "','" + genre + "','" + ComboBoxSituation.Text + "','" + DateN.ToString("yyyy-MM-dd") + "','" + TextBoxLieuNaissance.Text + "', '" + Daterecu.ToString("yyyy-MM-dd") + "','" + TextBoxEMAIL.Text + "','" + TextBoxTEL.Text + "','" + TextBoxADRESSE.Text + "'," + int.Parse(ComboBoxGrade.SelectedValue.ToString()) + "," + int.Parse(ComboBoxService.SelectedValue.ToString()) + ")";
                    cmd = new SqlCommand(Requtte, cnx);
                    cmd.ExecuteNonQuery();
                    FormFonctionnaires FF = new FormFonctionnaires();
                    FF.RemplirGrid();
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

        private void ButtonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
