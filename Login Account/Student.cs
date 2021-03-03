using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login_Account
{
    class Student
    {
        My_Database data = new My_Database();
        public bool AddStudent(int id, string firstname, string lastname, DateTime birthday, string gender, 
            string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO AddStudent (id, firstname, lastname, birthday, gender, phone, address, picture)" +
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
    }
}
