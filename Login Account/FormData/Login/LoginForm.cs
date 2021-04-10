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
using System.Threading;
using Login_Account.FormData;

namespace Login_Account
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            My_Database data = new My_Database();
            data.Closeconnection();
            this.Close();
        }
        void SaveData()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ProgressBarForm bar = new ProgressBarForm(SaveData) )
            {
                bar.ShowDialog(this);
            }
            My_Database my_data = new My_Database();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE Username = @User AND Password = @Pass", my_data.Getcon);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = Username_tb.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Password_tb.Text;
            sda.SelectCommand = command;
            sda.Fill(table);
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Ok, Login Successful");
                Function_Login fl = new Function_Login();
                this.Hide();
                fl.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please create new account!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Function_Login fl = new Function_Login();
                //fl.Show();
            }
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Increment(i);
            }
            
        }
        private void addUser_Click(object sender, EventArgs e)
        {
            SignIn_Account singin = new SignIn_Account();
            singin.Hide();
            singin.Show();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
