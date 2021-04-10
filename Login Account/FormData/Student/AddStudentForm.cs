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
using Login_Account.FormData.CourseForm;
using Login_Account.FormData;

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
            int Id = Convert.ToInt32(ID_student.Text);
            string firstname = this.firstname.Text;
            string lastname = this.lastname.Text;
            DateTime birthday = datetime.Value;
            string phone = this.address1.Text;
            string address = this.phone.Text;
            string gender = "Female";
            if (malebutton.Checked)
            {
                gender = "Male";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = datetime.Value.Year;
            int this_year = DateTime.Now.Year;
            if (this_year - born_year < 10 || this_year - born_year > 100)
            {
                MessageBox.Show("The student age must be 10 to 100 year", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                picture.Image.Save(pic, picture.Image.RawFormat);
                if(student.AddStudent(Id, firstname, lastname, birthday, gender, phone, address, pic))
                {
                    MessageBox.Show("New student added", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
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
                MessageBox.Show("Empty fields", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool verif()
        {
            if ((firstname.Text.Trim() == "")
                || (lastname.Text.Trim() == "")
                || (phone.Text.Trim() == "") 
                || (address1.Text.Trim() == "")
                || (picture.Image == null)
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
                picture.Image = Image.FromFile(open.FileName);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            
        }
        ErrorProvider error1 = new ErrorProvider();
        private void textBox1_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled =! char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                error1.SetError(errorID, "Only Number");
                errorID.Text = "Only Number";
            }
            else
            {
                error1.SetError(errorID, "");
                errorID.Text = "";
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled =! char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                error1.SetError(errorphone, "Only Number");
                errorphone.Text = "Only Number";
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
