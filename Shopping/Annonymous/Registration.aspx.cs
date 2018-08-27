using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingOnline.Annonymous
{
    public partial class Registration : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Session["id"] != null)
            {
                Response.Redirect("~/Annonymous/Home.aspx");
                
            }


        }
        protected void btn_register_Click(object sender, EventArgs e)
        {
            try
            {

                string path = "~/userImages/" + fu_image.FileName;
                if (fu_image.HasFile)
                {
                    string ext = Path.GetExtension(fu_image.FileName);
                    if (ext == ".jpg" || ext == ".png" || ext == ".PNG" || ext == ".JPG")
                    {
                        fu_image.SaveAs(Server.MapPath(path));

                        string state = "pending";

                        if (user.checkEmail(txt_mail.Text) == false)
                        {

                            if (user.checkUserName(txt_uname.Text) == false)
                            {
                                user.insert(txt_ID.Text, 0, txt_pass.Text, txt_fname.Text, txt_lname.Text, txt_mail.Text, txt_uname.Text, path, txt_address.Text, state, txt_phone.Text, int.Parse(txt_code.Text));
                                lbl_result.Text = "successful registeration you can login now";

                            }
                            else
                            {
                                lbl_result.Text = "This UserName is exists ,Please sign in";
                            }

                        }
                        else
                        {

                            lbl_result.Text = "This email is exists ,Please sign in";

                        }
                    }
                    else
                        lbl_result.Text = "Please choose an image";

                }

            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }
        }    
    }
            
   
}
    
