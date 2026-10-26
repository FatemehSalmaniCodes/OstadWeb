// Subject: Code-behind of the add-item form
// Role: Parses the price, inserts the item with an empty image, shows a Persian success message.
// -- mDev

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class Item_mng : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CLS.item ii = new CLS.item();

            try
            {
                // Int32.Parse throws on bad input; the catch below shows the error in msg_lbl. -- mDev
                ii.insert_item(itmname_txt.Text, Int32.Parse(price_txt.Text),"");

                msg_lbl.Text = "ثبت انجام شد";
            }
            catch (Exception ex)
            {
                msg_lbl.Text = ex.Message;
            }

        }
    }
}