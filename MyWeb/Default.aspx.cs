// Subject: Code-behind of the home page
// Role: Button1_Click only creates an empty Class1 object (demo of calling a CLS class).
// -- mDev

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Runs only on the first load of the page, not on button postbacks. -- mDev
            if(! Page.IsPostBack)   //ispostback==false
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CLS.Class1 obj = new CLS.Class1();
           


        }
    }
}