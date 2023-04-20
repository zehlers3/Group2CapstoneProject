using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Group2CapstoneProj;

namespace WinFormsApp1
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon =
                   new SqlConnection(@"Data Source=DESKTOP-3EG3DKH;Initial " +
                                     "Catalog=storeDB;Integrated Security=true"))
            {
                sqlCon.Open();
                string query = "SELECT * From loginTable WHERE username=@username AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", usernameTxt.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", passwordTxt.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    CatagoriesForm cat = new CatagoriesForm();
                    cat.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
    }
}