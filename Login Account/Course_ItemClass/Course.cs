using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Login_Account.FormData.CourseForm
{
    public class Course
    {
        public int ID_Course { get; set; }
        public string Label { get; set; }
        public int Period { get; set; }
        public string Decription { get; set; }
        public Course(int id, string la, int period, string dec)
        {
            this.ID_Course = id;
            this.Label = la;
            this.Period = period;
            this.Decription = dec;
        }

    public Course()
    {

    }
        public bool checkCourseName(string coursename, int id = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course Where lable = @CheckName and Id <> @CheckId", data.Getcon);
            command.Parameters.Add("@CheckName", SqlDbType.NVarChar).Value = coursename;
            command.Parameters.Add("@CheckId", SqlDbType.Int).Value = id;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            data.Openconnection();
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        My_Database data = new My_Database();
        public bool AddCoure(int id, string label, int period, string decription)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (Id, lable, period, description)" + "VALUES (@ID, @Label, @Period, @Dec)", data.Getcon);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@Period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@Dec", SqlDbType.NText).Value = decription;
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
        public DataTable GetCourse(SqlCommand command)
        {
            command.Connection = data.Getcon;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sda.Fill(table);
            return table;
        }
    }
}
