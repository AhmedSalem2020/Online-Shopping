using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ShoppingOnline.AppCode;

namespace ShoppingOnline.User
{
    public partial class editProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                if(Session["id"]!=null)
                {
                    int id = int.Parse( Session["id"].ToString());

                    DataTable dt = user.getbyid(id);
                    txt_fname.Text = dt.Rows[0]["cust_fname"].ToString();
                    txt_lname.Text = dt.Rows[0]["cust_lname"].ToString();
                    txt_username.Text = dt.Rows[0]["cust_username"].ToString();
                    txt_email.Text = dt.Rows[0]["cust_mail"].ToString();
                    txt_address.Text = dt.Rows[0]["cust_address"].ToString();
                    txt_phone.Text = dt.Rows[0]["cust_phone"].ToString();

                }
                else
                {
                    Response.Redirect("~/Annonymous/Home.aspx");
                }
            }

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            int result=0;

                try
                {

                    string fname = txt_fname.Text;
                    string lname = txt_lname.Text;
                    string username = txt_username.Text;
                    string email = txt_email.Text;
                    string address = txt_address.Text;
                    string phone = txt_phone.Text;
                    int id = int.Parse(Session["id"].ToString ());
                    DataTable dr = user.emailsearch(email, id);
                    DataTable dr2 = user.usersearch(username,id);
                    if (dr.Rows.Count == 0 && dr2.Rows.Count == 0)
                    {
                        result = user.change(id, fname, lname, username, email, address, phone);


                        if (result == 1)
                        {
                            Response.Redirect("~/User/viewProfile.aspx");
                        }

                    }
                    else
                    {
                        if (dr.Rows.Count > 0 && dr2.Rows.Count > 0)
                        {
                            lbl_result.Text = "this email and user name is already exist before...";
                        }
                        else if (dr.Rows.Count > 0)
                        {
                            lbl_result.Text = "this email is already exist before...";
                        }
                        else
                        {
                            lbl_result.Text = "this user name is already exist before...";

                        }

                    }







                }

                catch
                {
                    if (result == 0)
                    {

                        lbl_result.Text = "can't save data enter correct data ...";
                    }
                }

                finally
                {

                }


            
           

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User/viewprofile.aspx");
        }
    }
}