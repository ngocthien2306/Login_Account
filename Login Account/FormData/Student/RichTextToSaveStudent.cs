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

namespace Login_Account.FormData
{
    public partial class RichTextToSaveStudent : Form
    {
        public RichTextToSaveStudent()
        {
            InitializeComponent();
        }
        void GetTable(string MY_SQL) {
            My_Database data = new My_Database();
            richTextBox1.Clear();
            SqlCommand command = new SqlCommand(MY_SQL, data.Getcon);
            data.Openconnection();
            SqlDataReader read = command.ExecuteReader();

            try
            {
                
                while(read.Read())
                {
                    //int dataid = (int)read[0];
                    //richTextBox1.Text += " " + dataid;
                    //continue;
                    for (int i = 1; i < 3; i++)
                    {
                        string datafname = (string)read[i];

                        richTextBox1.Text += " " + datafname;
                    }


                }
                
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextToSaveStudent_Load(object sender, EventArgs e)
        {

        }
        public void SavePicture()
        {
            My_Database data = new My_Database();
            data.Openconnection();
            SqlCommand command = new SqlCommand("SELECT picture FROM Add_Student", data.Getcon);
            ImageConverter convert = new ImageConverter();
            Image image = (Image)convert.ConvertFrom(command.ExecuteScalar());
            image.Save(@"D:\picture.jpg");
            image.Save(@"D:\picture.docx");
            image.Save(@"D:\picture.pdf");
            data.Closeconnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string SQL = "select * from Add_Student";
            GetTable(SQL);
            SavePicture();
        }
    }
}
