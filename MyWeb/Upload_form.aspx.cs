// Subject: Code-behind of the image-upload form
// Role: Saves the image to ~/upload with a timestamp name, then inserts the item in the database.
// -- mDev

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace MyWeb
{
    public partial class Upload_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = "";
                if (FileUpload1.HasFile == true)
                {
                    // NOTE: no file-type check (the commented ext check is not active). -- mDev
                    FileUpload1.SaveAs(Server.MapPath("~/upload/" + filename(FileUpload1.FileName)));
                    filepath = "../upload/" + filename(FileUpload1.FileName);


                }
              
                //if (ext == ".jpg")
                //{
                //    return;
                //}

                
                CLS.item ii = new CLS.item();
                ii.insert_item(name_txt.Text, Int32.Parse(price_txt.Text), filepath);

                msg_lbl.Text = "successfull";
            }
            catch (Exception ex)
            {
                msg_lbl.Text = ex.Message;
            }


        }

        // Builds a new file name from the current date/time + original extension. -- mDev
        // NOTE: two uploads within the same second would get the same name. -- mDev
        string filename(string filename)
        {
            string output = "";
            string ext = Path.GetExtension(FileUpload1.FileName);
            DateTime dt = DateTime.Now;
            output = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString()+ext;
            
           
            return output;
        }

    }
}