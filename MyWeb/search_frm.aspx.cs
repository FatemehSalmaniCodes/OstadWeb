// Subject: Code-behind of the search page
// Role: Chooses the column from the dropdown, builds the condition, binds results to grid1.
// -- mDev

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class search_frm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CLS.item ii = new CLS.item();

            try {

                if (drop1.SelectedIndex > 0)
                {

                    // Search by name: LIKE with wildcards on ItmName. -- mDev
                    // NOTE: TextBox text goes directly into the SQL (SQL-injection risk). -- mDev
                    if (drop1.SelectedValue == "name")
                    {
                        grid1.DataSource = ii.select_item($" like N'%{TextBox1.Text}%'", "ItmName");
                        grid1.DataBind();
                    }
                    // Search by ID: exact match on ItemID. -- mDev
                    if (drop1.SelectedValue == "ID")
                    {
                        grid1.DataSource = ii.select_item($" ={TextBox1.Text}", "ItemID");
                        grid1.DataBind();
                    }
                }
                else
                {
                    msg_lbl.Text = "نوع فیلتر را مشخص کنید";
                }

             
            }
            catch(Exception ex) { msg_lbl.Text = ex.Message; }
        }
    }
}