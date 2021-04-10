using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Account.FormData.CourseForm
{
    public partial class ListCourse : Form
    {
        public ListCourse()
        {
            InitializeComponent();
        }

        private void Refersh_bt_Click(object sender, EventArgs e)
        {
            dataGridView_Course.DataSource = null;
            this.ShowList();
        }

        private void ListCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet2.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.manager_StudentDataSet2.Course);
            // TODO: This line of code loads data into the 'manager_StudentDataSet2.Course' table. You can move, or remove it, as needed.
            this.ShowList();
        }
        private bool ShowList()
        {
            try
            {
                My_Database dataBase = new My_Database();
                dataBase.Openconnection();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Course", dataBase.Getcon);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Course");
                dataGridView_Course.RowTemplate.Height = 80;
                DataTable table = dataSet.Tables["Course"];
                dataGridView_Course.DataSource = table;
                dataGridView_Course.ReadOnly = true;
                dataGridView_Course.AllowUserToAddRows = false;
                dataBase.Closeconnection();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }

        private void dataGridView_Course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void OpenEdit()
        {
            try
            {
                EditCourse edit = new EditCourse();
                edit.Id_tb.Text = dataGridView_Course.CurrentRow.Cells[0].Value.ToString().Trim();
                edit.Label_tb.Text = dataGridView_Course.CurrentRow.Cells[1].Value.ToString().Trim();
                edit.Period_tb.Text = dataGridView_Course.CurrentRow.Cells[2].Value.ToString().Trim();
                edit.dec_richtext.Text = dataGridView_Course.CurrentRow.Cells[3].Value.ToString().Trim();
                edit.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void dataGridView_Course_DoubleClick(object sender, EventArgs e)
        {
            this.OpenEdit();
        }
    }
}
