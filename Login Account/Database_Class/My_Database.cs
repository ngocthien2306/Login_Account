using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Login_Account
{
    class My_Database
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-US6D43H;Initial Catalog=Manager_Student;Integrated Security=True");
        public SqlConnection Getcon
        {
            get { return this.con; }
        }
        public void Openconnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void Closeconnection()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
