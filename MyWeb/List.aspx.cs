// Subject: Code-behind of the product list page
// Role: Loads all items from the database and binds them to ListView1.
// -- mDev

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Data-access object from CLS/item.cs. -- mDev
                CLS.item ii = new CLS.item();

                ListView1.DataSource = ii.select_all();
                ListView1.DataBind();
            }

        }
    }
}