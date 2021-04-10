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
using Login_Account.FormData.CourseForm;
namespace Login_Account.FormData.CourseForm
{
    public partial class EditCourse : Form
    {
        public EditCourse()
        {
            InitializeComponent();
        }
        My_Database data = new My_Database();
        private void Edit_bt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE Course" + " SET " + "lable = @Label," + "period = @Period," + "description = @Des" + " WHERE id = @ID", data.Getcon);
                command.Parameters.Add("@Label", SqlDbType.NVarChar).Value = Label_tb.Text;
                command.Parameters.Add("@Period", SqlDbType.Int).Value = Period_tb.Text;
                command.Parameters.Add("@Des", SqlDbType.Text).Value = dec_richtext.Text;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = Id_tb.Text;
                data.Openconnection();
                if(command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Edit Successful!", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!\nTip: You should be checking the textbox!", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        public bool checkBox()
        {
            if (Id_tb.Text.Trim() == "" ||
                Label.Text.Trim() == ""
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
        private void Find_course_Click(object sender, EventArgs e)
        {
            if(Id_tb.Text.Trim() == "" && !checkBox())
            {
                MessageBox.Show("Error! Invalid in the textbox", "Search Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlCommand command = new SqlCommand("SELECT Id, lable, period, description FROM Course WHERE Id = @ID",data.Getcon);
                command.Parameters.Add("@ID", SqlDbType.Int).Value = Id_tb.Text;
                data.Openconnection();
                Course course = new Course();
                DataTable table = course.GetCourse(command);
                if(table.Rows.Count > 0)
                {
                    Id_tb.Text = table.Rows[0]["Id"].ToString();
                    Label_tb.Text = table.Rows[0]["lable"].ToString();
                    Period_tb.Text = table.Rows[0]["period"].ToString();
                    dec_richtext.Text = table.Rows[0]["description"].ToString();
                }
                else
                {
                    MessageBox.Show("Not found", "Search course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void remove_bt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult delete = MessageBox.Show("Are you sure delete the course with id: " + Id_tb.Text, "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    My_Database dataBase = new My_Database();

                    SqlCommand command = new SqlCommand(
                        "DELETE FROM Course" +
                        " WHERE Id = @ID", dataBase.Getcon);
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = Id_tb.Text;
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
            Id_tb.Clear();
            Label_tb.Clear();
            Period_tb.Clear();
            dec_richtext.Clear();
        }
    }
}
