// Subject: Database connection helper (base class for data-access classes)
// Role: Builds the SqlConnection to the local "shop" SQL Server database.
// -- mDev

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
       // Creates and returns an unopened SqlConnection (caller opens/closes it). -- mDev
       protected SqlConnection connect_db()
        {
            SqlConnection con = new SqlConnection();
            // NOTE: connection string is hard-coded; Web.config <connectionStrings> is the usual home. -- mDev
            con.ConnectionString = "Data Source=.;Initial Catalog=shop;Integrated Security=True";


            return con;

        }

    }
}