using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Account;
using System.Data.SqlClient;
namespace Login_Account.FormData.CourseForm
{
    public partial class Addcourse : Form
    {
        Course course = new Course();
        My_Database data = new My_Database();
        //public Addcourse()
        //{
        //    InitializeComponent();
        //}
        public Addcourse()
        {
            InitializeComponent();
        }
        public bool checkBox()
        {
            if (Id_tb.Text.Trim() == "" ||
                Label_tb.Text.Trim() == ""
                || Period_tb.Text.Trim() == "" ||
                dec_richtext.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Add_bt_Click(object sender, EventArgs e)
        {
            if (checkBox())
            {
                Course course = new Course();
                int id = Convert.ToInt32(this.Id_tb.Text);
                string label = this.Label_tb.Text;
                int period = Convert.ToInt32(this.Period_tb.Text);
                string decription = this.dec_richtext.Text;
                if (course.checkCourseName(label))
                {
                    if (course.AddCoure(id, label, period, decription))
                    {
                        MessageBox.Show("Add a new course successful!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Error!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This course name already exists", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error! Should fill the information into TextBox", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Addcourse_Load(object sender, EventArgs e)
        {

        }
    }
}
