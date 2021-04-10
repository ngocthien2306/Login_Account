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
using Login_Account.FormData;
using Login_Account.FormData.CourseForm;

namespace Login_Account
{
    public partial class Function_Login : Form
    {
        public Function_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void addAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.Show(this);
        }

        private void Function_Login_Load(object sender, EventArgs e)
        {

        }

        private void listStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displaylist_student display = new displaylist_student();
            display.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagermentStudent edit = new ManagermentStudent();
            edit.Show();
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            My_Database data = new My_Database();
            data.Closeconnection();
            Login login = new Login();
            Hide();
            login.Show();


        }

        private void managerStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statics statics = new Statics();
            statics.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print_Student print = new Print_Student();
            print.Show();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCourse list = new ListCourse();
            list.Show();
        }

        private void addNewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addcourse addcourse = new Addcourse();
            addcourse.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourse edit = new EditCourse();
            edit.Show();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            PrintCourse print = new PrintCourse();
            print.Show();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager edit = new Manager();
            edit.Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Remove edit = new Edit_Remove();
            edit.ShowDialog();
        }
    }
}
