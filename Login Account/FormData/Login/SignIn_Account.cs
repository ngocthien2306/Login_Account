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
using System.Data.Sql;

namespace Login_Account
{
    public partial class SignIn_Account : Form
    {
        public SignIn_Account()
        {
            InitializeComponent();
        }

        private void SignIn_Account_Load(object sender, EventArgs e)
        {


        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signin_bt_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = user_text.Text;
            string password = pass_text.Text;
            if(check())
            {
                if(user.Users(username, password))
                {
                    MessageBox.Show("Added successful", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your username or password has existed", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //try
            //{
            //    My_Database data = new My_Database();
            //    SqlCommand icommand = new SqlCommand("INSERT INTO Login " + "username, " + "password" + "VALUES" + "username = @Username" + "username = @Password", data.Getcon);
            //    SqlCommand checkCommand = new SqlCommand("SELECT *FROM Login " + " WHERE User = @Username", data.Getcon);
            //    checkCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user_text.Text;
            //    data.Openconnection();
            //    if (checkCommand.ExecuteNonQuery() < 1)
            //    {
            //        if (pass_text.Text == repass_text.Text)
            //        {
            //            icommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user_text.Text;
            //            icommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = pass_text;
            //            if (checkCommand.ExecuteNonQuery() == 1)
            //            {
            //                MessageBox.Show("Added new account successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Add new account was failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }

            //    }
            //    else
            //    {
            //        MessageBox.Show("Your username was used!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    data.Closeconnection();
            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine(E.Message);
            //    throw;
            //}
        }
        public bool check()
        {
            if(user_text.Text.Trim() == "" || pass_text.Text.Trim() == "")
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
