// Subject: Data-access class for the item_tbl table (insert / select / search)
// Role: Inherits connection; used by List, Item_mng, Upload_form and search_frm pages.
// -- mDev

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.CLS
{
    public class item : connection
    {


      // Inserts one item (name, price, image path) into item_tbl. -- mDev
      public  void insert_item(string item_name,int price,string img)
        {
            SqlConnection con = connect_db();

            con.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            // NOTE: SQL is built by string interpolation (SQL-injection risk); SqlParameter is the safe way. -- mDev
            com.CommandText = $"insert into item_tbl (itmname,iprice,iimg) values ('{item_name}' ,{price},'{img}' )";
            com.ExecuteNonQuery();


            con.Close();

            con.Dispose();
        }
        // Searches item_tbl by a column + condition (used by search_frm). -- mDev
        public DataTable  select_item(string searchTerm,string field)
        {
            DataTable dt = new DataTable();
            SqlConnection con = connect_db();
            con.Open();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
             // NOTE: field and searchTerm come straight from user input (SQL-injection risk). -- mDev
             com.CommandText = $" select * from Item_tbl where {field} {searchTerm}";
           
            SqlDataAdapter sda = new SqlDataAdapter(com.CommandText, con);
            sda.Fill(dt);

            con.Close();
            return dt;
        }
        // Returns every row of item_tbl (used by the product list page). -- mDev
        public DataTable select_all()
        {
            DataTable dt = new DataTable();
            SqlConnection con = connect_db();
            con.Open();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = $" select * from Item_tbl ";

            SqlDataAdapter sda = new SqlDataAdapter(com.CommandText, con);
            sda.Fill(dt);

            con.Close();
            return dt;
        }
    }
}