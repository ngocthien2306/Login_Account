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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thien Nguyen\Downloads\Learning Document\HKII_2020-2021\Window Programming\Day1_24-2-2021\Practice\Data_Login.mdf;Integrated Security=True;Connect Timeout=30");
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
