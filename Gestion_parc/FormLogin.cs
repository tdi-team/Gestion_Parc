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
        private bool Check(string user, string pass)
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
        private bool Search(string user)
        {
            bool result = false;
            using (SqlConnection cnx = new SqlConnection(ConnectionManager.cs))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE (userName = '" + user + "');", cnx);
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
                if (Search(TextBoxUser.Text))
                {
                    if (Check(TextBoxUser.Text, TextBoxPass.Text))
                    {
                        this.Hide();
                        FormMain F = new FormMain();
                        F.Show();
                    }
                    else
                    {
                        guna2HtmlToolTip1.Show("Password incorrect", this, TextBoxPass.Location.X, TextBoxPass.Location.Y - TextBoxPass.Height, 3000);
                        TextBoxPass.ShadowDecoration.Color = Color.Red;
                        TextBoxPass.ShadowDecoration.Enabled = true;
                    }
                }
                else
                {
                    guna2HtmlToolTip1.Show("User doen't exist", this, TextBoxUser.Location.X, TextBoxUser.Location.Y - TextBoxUser.Height, 3000);
                    TextBoxUser.ShadowDecoration.Color = Color.Red;
                    TextBoxUser.ShadowDecoration.Enabled = true;
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

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {
            TextBoxUser.ShadowDecoration.Enabled = false;
            guna2HtmlToolTip1.Hide(this);
        }

        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            TextBoxPass.ShadowDecoration.Enabled = false;
            guna2HtmlToolTip1.Hide(this);
        }
    }
}
