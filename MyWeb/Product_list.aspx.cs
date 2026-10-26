// Subject: Code-behind for the ID-passing demo
// Role: Button1 sends the ID in the URL; Button2 sends it through Session + Server.Transfer.
// -- mDev

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class Product_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Method 1: QueryString redirect (visible in the URL, new request). -- mDev
            Response.Redirect("Product_dtl.aspx?ID="+id_txt.Text);
       

            //Server.Transfer("Product_dtl.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Method 2: Session + Server.Transfer (hidden from URL, same request). -- mDev
            Session["ID"] = id_txt.Text;
            Server.Transfer("Product_dtl.aspx");
        }
    }
}