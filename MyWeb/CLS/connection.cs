using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.CLS
{
    public class connection
    {
       protected SqlConnection connect_db()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=shop;Integrated Security=True";


            return con;

        }

    }
}