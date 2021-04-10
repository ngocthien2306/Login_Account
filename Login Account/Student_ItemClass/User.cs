using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Login_Account
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string user ="", string pass ="")
        {
            Username = user;
            Password = pass;
        }
        My_Database data = new My_Database();
        public bool Users(string user, string pass)
        {
                SqlCommand command = new SqlCommand("INSERT INTO Login (Username, Password)" + "VALUES (@user,  @pass)", data.Getcon);
                command.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
                command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
                data.Openconnection();
                if (command.ExecuteNonQuery() == 1)
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
        public DataTable getUsers(SqlCommand command)
        {
            command.Connection = data.Getcon;
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sd.Fill(table);
            return table;
        }
    }
}
