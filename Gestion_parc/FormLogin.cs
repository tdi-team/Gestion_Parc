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

namespace Gestion_parc
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private bool Search(string user, string pass)
        {
            bool result = false;
            using (SqlConnection cnx = new SqlConnection(ConnectionManager.cs))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE (userName = '" + user + "' AND Pass = '" + pass + "');", cnx);
                SqlDataReader dr;
                cnx.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
                }
            }
            return result;
        }

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Search(TextBoxUser.Text, TextBoxPass.Text))
                {
                    this.Hide();
                    FormMain F = new FormMain();
                    F.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
