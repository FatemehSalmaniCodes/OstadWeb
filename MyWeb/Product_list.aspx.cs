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
            Response.Redirect("Product_dtl.aspx?ID="+id_txt.Text);
       

            //Server.Transfer("Product_dtl.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["ID"] = id_txt.Text;
            Server.Transfer("Product_dtl.aspx");
        }
    }
}