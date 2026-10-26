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