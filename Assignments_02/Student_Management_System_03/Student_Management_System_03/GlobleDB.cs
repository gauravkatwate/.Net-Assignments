using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Student_Management_System_03
{
    class GlobleDB
    {
        public static string strcon = (@"Data Source=LAPTOP-D2SMNN1L\SQLEXPRESS;Initial Catalog=Student_Management_System_03_DB;Integrated Security=True");

        public SqlConnection con = new SqlConnection(strcon);

        public void con_open()
        {
           if(con.State == ConnectionState.Closed)
           {
               con.Open();
           }
        }

        public void con_close()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
