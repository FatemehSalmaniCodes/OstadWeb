// Subject: Code-behind of the product detail page
// Role: Reads ID from the QueryString and shows it in Label1 (Session version is commented out).
// -- mDev

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class Product_dtl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                // Guard: only use the ID if it was actually sent in the URL. -- mDev
                if (Request.QueryString["ID"] != null)
                {
                    Label1.Text = Request.QueryString["ID"].ToString().Trim();
                }

                //if (Session["ID"] != null)
                //{
                //    Label1.Text =(string) Session["ID"];
                //    Session.Remove("ID");
                //}

            }
            
        }
    }
}