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


      public  void insert_item(string item_name,int price,string img)
        {
            SqlConnection con = connect_db();

            con.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = $"insert into item_tbl (itmname,iprice,iimg) values ('{item_name}' ,{price},'{img}' )";
            com.ExecuteNonQuery();


            con.Close();

            con.Dispose();
        }
        public DataTable  select_item(string searchTerm,string field)
        {
            DataTable dt = new DataTable();
            SqlConnection con = connect_db();
            con.Open();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
             com.CommandText = $" select * from Item_tbl where {field} {searchTerm}";
           
            SqlDataAdapter sda = new SqlDataAdapter(com.CommandText, con);
            sda.Fill(dt);

            con.Close();
            return dt;
        }
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