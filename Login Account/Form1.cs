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

namespace Login_Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            My_Database my_data = new My_Database();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Login1 WHERE Username = @User AND Password = @Pass", my_data.Getcon);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox1_UserName.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox2_Password.Text;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Form1 f1 = new Form1();
            //if(f1.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new Form());
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }
    }
}
