using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login_Account
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void label8picture_Click(object sender, EventArgs e)
        {

        }

        private void button1exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2add_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            int Id = Convert.ToInt32(textBox1_ID.Text);
            string firstname = textBox5_firstname.Text;
            string lastname = textBox4_lastname.Text;
            DateTime birthday = dateTimePicker1.Value;
            string phone = textBox3_phone.Text;
            string address = textBox2_address.Text;
            string gender = "Male";
            if (radioButton1_female.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if (this_year - born_year < 10 || this_year - born_year > 100)
            {
                MessageBox.Show("The student age must be 10 to 100 year", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if(student.AddStudent(Id, firstname, lastname, birthday, gender, phone, address, pic))
                {
                    MessageBox.Show("New student added", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Function_Login fl = new Function_Login();
                    fl.Show();
                }
                else
                {
                    MessageBox.Show("Error", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emplty fields", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool verif()
        {
            if ((textBox5_firstname.Text.Trim() == "")
                || (textBox4_lastname.Text.Trim() == "")
                || (textBox2_address.Text.Trim() == "") 
                || (textBox3_phone.Text.Trim() == "")
                || (pictureBox1.Image == null)
                )
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void button1_loadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime.UtcNow.ToShortDateString();
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Text.ToString();

        }
    }
}
