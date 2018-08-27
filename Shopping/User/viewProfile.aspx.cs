using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping.User
{
    public partial class viewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                int id = int.Parse(Session["id"].ToString());
                DataTable dt = Customer.getbyid(id);
               if (!IsPostBack)
                {
                    lbl_fname.Text = dt.Rows[0][0].ToString();
                    lbl_lname.Text = dt.Rows[0][1].ToString();
                    lbl_username.Text = dt.Rows[0][2].ToString();
                    lbl_username0.Text = dt.Rows[0][2].ToString();
                    lbl_email.Text = dt.Rows[0][3].ToString();
                    lbl_address.Text = dt.Rows[0][4].ToString();
                    lbl_phone.Text = dt.Rows[0][5].ToString();

                }
            }
            else
            {
                Response.Redirect("~/Annonymous/Home.aspx");
            }
            
        }

        protected void lnk_edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User/editProfile.aspx");
        }

        protected void lnk_chngPass_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User/change_password.aspx");
            
        }

    
    }
}