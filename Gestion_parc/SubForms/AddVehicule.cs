using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DataLibrary.Models;
using System.Data.SqlClient;

namespace Gestion_parc.SubForms
{
    public partial class AddVehicule : Form
    {
        public AddVehicule()
        {
            InitializeComponent();
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

        private void TextBoxNivCarb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionManager.cs))
            {
                Vehicule v = new Vehicule();
                v.CapaciteReservoir = int.Parse(TextBoxCapacite.Text);
                float f;
                float.TryParse(TextBoxConsomage.Text.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture,out f);
                v.Consomage = f;
                MessageBox.Show(v.Consomage.ToString());
                v.DateAquisition = DateTimePickerAquisition.Value.Date;
                v.HorsePower = int.Parse(TextBoxHorsePower.Text);
                v.Kilometrage = int.Parse(TextBoxKilometrage.Text);
                v.matricule = TextBoxMatricule.Text;
                v.Modele = TextBoxModele.Text;
                v.niveauCarburant = TrackBarNivCarb.Value;

                string query = @"INSERT INTO [dbo].[Vehicule]
                                       ([matricule]
                                       ,[typeVehicule]
                                       ,[DateAquisition]
                                       ,[Marque]
                                       ,[Modele]
                                       ,[statusVehicule]
                                       ,[niveauCarburant]
                                       ,[Kilometrage]
                                       ,[Consomage]
                                       ,[HorsePower]
                                       ,[CapaciteReservoir])
                                 VALUES
                                       (@matricule
                                       ,@typeVehicule
                                       ,@DateAquisition
                                       ,@Marque
                                       ,@Modele
                                       ,@statusVehicule
                                       ,@niveauCarburant
                                       ,@Kilometrage
                                       ,@Consomage
                                       ,@HorsePower
                                       ,@CapaciteReservoir)
                            ";
                connection.Execute(query, v);
            }
        }
    }
}
