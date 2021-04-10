using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using Login_Account.FormData;
using Login_Account.FormData.CourseForm;

namespace Login_Account
{
    public partial class displaylist_student : Form
    {

        public displaylist_student()
        {
            InitializeComponent();
        }

        private void button1_refesh_Click(object sender, EventArgs e)
        {
            {
                dataGridView_Student.DataSource = null;
                ShowList();
            }
        }

        private void displaylist_student_Load(object sender, EventArgs e)
        {
            ShowList();

        }
        private bool ShowList()
        {
            try
            {
                My_Database dataBase = new My_Database();
                dataBase.Openconnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Add_Student", dataBase.Getcon);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Add_Student");
                dataBase.Closeconnection();

                dataGridView_Student.RowTemplate.Height = 80;
                DataTable table = dataSet.Tables["Add_Student"];
                dataGridView_Student.DataSource = table;
                dataGridView_Student.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView_Student.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView_Student.AllowUserToAddRows = false;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        private bool OpenEdit()
        {
            try
            {
                Edit_Remove editDelete = new Edit_Remove();
                editDelete.Id_Student_TB.Text = dataGridView_Student.CurrentRow.Cells[0].Value.ToString().Trim();
                editDelete.Firstname_TB.Text = dataGridView_Student.CurrentRow.Cells[1].Value.ToString().Trim();
                editDelete.Lastname_TB.Text = dataGridView_Student.CurrentRow.Cells[2].Value.ToString().Trim();
                editDelete.dateTime.Value = (DateTime)dataGridView_Student.CurrentRow.Cells[3].Value;
                if (dataGridView_Student.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
                {
                    editDelete.radioMale.Checked = true;
                }
                else if (dataGridView_Student.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
                {
                    editDelete.radioFemale.Checked = true;
                }
                editDelete.Address_TB.Text = dataGridView_Student.CurrentRow.Cells[5].Value.ToString().Trim();
                editDelete.Phone_TB.Text = dataGridView_Student.CurrentRow.Cells[6].Value.ToString().Trim();
                byte[] byteImage = (byte[])dataGridView_Student.CurrentRow.Cells[7].Value;
                MemoryStream stream = new MemoryStream(byteImage);
                editDelete.pictureBox.Image = Image.FromStream(stream);
                editDelete.Show();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenEdit();
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }

        private void RemoveStudent_Click(object sender, EventArgs e)
        {
            Edit_Remove edit = new Edit_Remove();
            edit.Hide();
            edit.Show();
            
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            Edit_Remove edit = new Edit_Remove();
            edit.Show();
        }


    }
}
