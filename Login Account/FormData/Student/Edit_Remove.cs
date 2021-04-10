using Login_Account.FormData.CourseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Login_Account.FormData.CourseForm
{
    public partial class Edit_Remove : Form
    {
        public Edit_Remove()
        {
            InitializeComponent();
        }

        private void Edit_Remove_Load(object sender, EventArgs e)
        { 
        }

        private void Upload_bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(open.FileName);
            }
        }

        private void Edit_bt_Click(object sender, EventArgs e)
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
                command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = Firstname_TB.Text;
                command.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = Lastname_TB.Text;
                command.Parameters.Add("@Bdate", SqlDbType.DateTime).Value = dateTime.Value;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone_TB.Text;
                command.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = Address_TB.Text;
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(pictureBox.Image, typeof(byte[]));
                command.Parameters.Add("@Picture", SqlDbType.Image).Value = image;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = Id_Student_TB.Text;
                if (radioMale.Checked)
                {
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "Male";
                }
                else if (radioFemale.Checked)
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

            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
}

        private void Remove_bt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult delete = MessageBox.Show("Are you sure delete student with id: " + Id_Student_TB.Text, "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    My_Database dataBase = new My_Database();

                    SqlCommand command = new SqlCommand(
                        "DELETE FROM Add_Student" +
                        " WHERE ID = @id", dataBase.Getcon);
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = Id_Student_TB.Text;

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

        private void Find_student_Click(object sender, EventArgs e)
        {
            this.Find();
        }
        private void Find()
        {
            if (Id_Student_TB.Text.Trim() == "")
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                My_Database dataBase = new My_Database();
                SqlCommand command = new SqlCommand(
                    "SELECT id, firstname, lastname, birthday, gender, phone, address, picture FROM Add_Student WHERE id = @address or firstname = @address or lastname = @address", dataBase.Getcon);
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = Id_Student_TB.Text;

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

                    //dataGridView1.RowTemplate.Height = 80;
                    //DataTable table1 = dataSet.Tables["Add_Student"];
                    //dataGridView1.DataSource = table1;
                    //dataGridView1.ReadOnly = true;
                    //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    //imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
                    //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    //dataGridView1.AllowUserToAddRows = false;
                    Id_Student_TB.Text = table.Rows[0]["id"].ToString();
                    Firstname_TB.Text = table.Rows[0]["firstname"].ToString();
                    Lastname_TB.Text = table.Rows[0]["lastname"].ToString();
                    dateTime.Value = (DateTime)table.Rows[0]["birthday"];
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioMale.Checked = true;
                    }
                    else if (table.Rows[0]["gender"].ToString() == "Male")
                    {
                        radioFemale.Checked = true;
                    }
                    Phone_TB.Text = table.Rows[0]["phone"].ToString();
                    Address_TB.Text = table.Rows[0]["address"].ToString();
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }     
        }
        private void Find_Click(object sender, EventArgs e)
        {

        }
    }
}
