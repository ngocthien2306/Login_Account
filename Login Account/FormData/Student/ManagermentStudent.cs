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
using Login_Account;
using System.IO;
using Login_Account.FormData.CourseForm;
using Login_Account.FormData;

namespace Login_Account
{
    public partial class ManagermentStudent : Form
    {
       
        public ManagermentStudent()
        {
            InitializeComponent();
        }
        public void DataStudent()
        {
            
        }
        private void Remove_student_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult delete = MessageBox.Show("Are you sure delete student with id: " + ID_Student.Text, "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    My_Database dataBase = new My_Database();

                    SqlCommand command = new SqlCommand(
                        "DELETE FROM Add_Student" +
                        " WHERE ID = @id", dataBase.Getcon);
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID_Student.Text;

                    dataBase.Openconnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Complete", "Delete complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Delete fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataBase.Closeconnection();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
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

                dataGridView1.RowTemplate.Height = 80;
                DataTable table = dataSet.Tables["Add_Student"];
                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        private void edit_remove_datagrid_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            double total = Convert.ToDouble(student.TotalStudent());
            Total_Student.Text = "Total: " + total + " Student";
            this.ShowList();
        }

        private void Edit_student_Click(object sender, EventArgs e)
        {
            try
            {
                My_Database data = new My_Database();
                SqlCommand command = new SqlCommand("UPDATE Add_Student" + " SET " +
                    "firstname = @Fname," +
                    "lastname = @Lname," +
                    "birthday = @Bdate," +
                    "gender = @Gender," +
                    "phone = @Phone," +
                    "address = @Adress," +
                    "picture = @Picture" +
                    " WHERE id = @ID", data.Getcon);
                command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = Firstname.Text;
                command.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = Lastname.Text;
                command.Parameters.Add("@Bdate", SqlDbType.DateTime).Value = daytime.Value;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Address.Text;
                command.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = PhoneNumber.Text;
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(picturestudent.Image, typeof(byte[]));
                command.Parameters.Add("@Picture", SqlDbType.Image).Value = image;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = ID_Student.Text;

                if (RadioMale.Checked)
                {
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "Male";
                }
                else if (RadioFemale.Checked)
                {
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "Female";
                }
                else
                {
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "Male";
                }


                data.Openconnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Complete", "Edit completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR", "Edit failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                data.Closeconnection();
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            
            if (searchtext.Text.Trim() == "")
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                My_Database dataBase = new My_Database();
                SqlCommand command = new SqlCommand(
                    "SELECT id, firstname, lastname, birthday, gender, phone, address, picture FROM Add_Student WHERE address = @address or firstname = @address or lastname = @address", dataBase.Getcon);
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = searchtext.Text;

                dataBase.Openconnection();
                Student student = new Student();
                DataTable table = student.getStudents(command);
                if (table.Rows.Count > 0)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Add_Student");
                    dataBase.Closeconnection();

                    dataGridView1.RowTemplate.Height = 80;
                    DataTable table1 = dataSet.Tables["Add_Student"];
                    dataGridView1.DataSource = table1;
                    dataGridView1.ReadOnly = true;
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridView1.AllowUserToAddRows = false;
                    //textBox1.Text = table.Rows[0]["id"].ToString();
                    //textBox2.Text = table.Rows[0]["firstname"].ToString();
                    //textBox3.Text = table.Rows[0]["lastname"].ToString();
                    //dateTimePicker1.Value = (DateTime)table.Rows[0]["birthday"];
                    //if (table.Rows[0]["gender"].ToString() == "Female")
                    //{
                    //    radioButton1.Checked = true;
                    //}
                    //else if (table.Rows[0]["gender"].ToString() == "Male")
                    //{
                    //    radioButton2.Checked = true;
                    //}
                    //textBox5.Text = table.Rows[0]["phone"].ToString();
                    //textBox4.Text = table.Rows[0]["address"].ToString();
                    //byte[] pic = (byte[])table.Rows[0]["picture"];
                    //MemoryStream picture = new MemoryStream(pic);
                    //pictureBox1.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureUp_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picturestudent.Image = Image.FromFile(open.FileName);
            }
        } 
        public bool verif()
        {
            if ((Firstname.Text.Trim() == "")
                || (Lastname.Text.Trim() == "")
                || (PhoneNumber.Text.Trim() == "")
                || (Address.Text.Trim() == "")
                || (picturestudent.Image == null)
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            int Id = Convert.ToInt32(ID_Student.Text);
            string firstname = this.Firstname.Text;
            string lastname = this.Lastname.Text;
            DateTime birthday = daytime.Value;
            string phone = this.PhoneNumber.Text;
            string address = this.Address.Text;
            string gender = "Female";
            if (RadioMale.Checked)
            {
                gender = "Male";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = daytime.Value.Year;
            int this_year = DateTime.Now.Year;
            if (this_year - born_year < 10 || this_year - born_year > 100)
            {
                MessageBox.Show("The student age must be 10 to 100 year", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                picturestudent.Image.Save(pic, picturestudent.Image.RawFormat);
                if (student.AddStudent(Id, firstname, lastname, birthday, gender, phone, address, pic))
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
                MessageBox.Show("Emplty fields", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void resetlist_Click(object sender, EventArgs e)
        {
            ID_Student.Clear();
            Firstname.Clear();
            Lastname.Clear();
            PhoneNumber.Clear();
            Address.Clear();
            picturestudent.Image = null;
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
        }
    }
}
