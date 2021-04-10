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
using System.IO;

namespace Login_Account.FormData.CourseForm
{
    public class Student : Course
    {
        List<Course> courses { get; set; }
        public int ID { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public DateTime Bdate { get; set; }
        public char Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public MemoryStream Picture { get; set; }
        public Student(int id = 0, string firstname = "", string lastname = "",
            DateTime date = default, char gender = '\0', string phone = "", string address = "", MemoryStream picture = default)
        {
            ID = id;
            Fname = firstname;
            Lname = lastname;
            Bdate = date;
            Gender = gender;
            Phone = phone;
            Address = address;
            Picture = picture;
        }
        My_Database data = new My_Database();
        public bool AddStudent(int id, string firstname, string lastname, DateTime birthday, string gender, 
            string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Add_Student (id, firstname, lastname, birthday, gender, phone, address, picture)" +
                "VALUES (@id, @fn, @ln, @bday, @gen, @add, @ph, @pic)", data.Getcon);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NChar).Value = firstname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lastname;
            command.Parameters.Add("@bday", SqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@gen", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            data.Openconnection();
            if(command.ExecuteNonQuery() == 1)
            {
                data.Closeconnection();
                return true;
            }
            else
            {
                data.Closeconnection();
                return false;
            }                     
        }
        public object TotalStudent()
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand(@"select count(*) from Add_Student", data.Getcon);
            data.Openconnection();
            command.CommandText = @"select count(*) from Add_Student";
            return command.ExecuteScalar();
        }
        public object TotalMaleStudent()
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand(@"select count(*) from Add_Student where gender = 'male'", data.Getcon);
            data.Openconnection();
            command.CommandText = @"select count(*) from Add_Student where gender = 'male'";
            return command.ExecuteScalar();
        }
        public object TotalFemaleStudent()
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand(@"select count(*) from Add_Student where gender = 'female'", data.Getcon);
            data.Openconnection();
            command.CommandText = @"select count(*) from Add_Student where gender = 'female'";
            try
            {
                return command.ExecuteScalar();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                data.Closeconnection();
            }
            return command.ExecuteScalar();
            
        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = data.Getcon;
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sd.Fill(table);
            return table;
        }

    }
}
