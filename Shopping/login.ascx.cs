using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingOnline
{
    public partial class login : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["log"] != null)
            {

                Session.Add("id", Request.Cookies["log"].Values["id"]);
                MultiView1.ActiveViewIndex = 1;
            }
            if (Session["id"] != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select cust_username from customer  where cust_Id = @id");
                    cmd.Parameters.AddWithValue("@id", Session["id"].ToString());
                    DataTable dt = DBlayer.Sel(cmd);
                    lbl_name.Text = dt.Rows[0]["cust_username"].ToString();
                    MultiView1.ActiveViewIndex = 1;
                }
                catch (Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                }




            }
          
        }

        protected void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != "" && txt_pass.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("select cust_Id ,isadmin from customer where cust_username=@username and cust_pass=@pass ");
                    cmd.Parameters.AddWithValue("@username", txt_name.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                    DataTable dt = DBlayer.Sel(cmd);
                    if (dt.Rows.Count != 0)
                    {
                        MultiView1.ActiveViewIndex = 1;
                        Session.Add("id", dt.Rows[0][0].ToString());
                        Session.Add("isadmin", int.Parse(dt.Rows[0][1].ToString()));


                        if (ch_rem.Checked)
                        {
                            HttpCookie co = new HttpCookie("log");
                            co.Expires = DateTime.Now.AddDays(10);
                            co.Values.Add("id", dt.Rows[0][0].ToString());
                            co.Values.Add("isadmin", dt.Rows[0][1].ToString());

                            Response.Cookies.Add(co);


                        }
                        if (int.Parse(Session["isadmin"].ToString()) == 1)
                        {

                            Response.Redirect("~/Admin/HomeAdmin.aspx", false);
                        }
                        else
                        {
                            Response.Redirect("~/Annonymous/Home.aspx", false);

                        }



                    }
                    else
                    {
                        lbl_msg.Text = "invalid UserName or Password";
                    }
                }


            }
            catch (Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }



        }

        protected void lbtn_logout_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["isadmin"] = null;
            //Session.Abandon();
            HttpCookie coo = new HttpCookie("log");
            coo.Expires = DateTime.Now.AddDays(-5);
            Response.Cookies.Add(coo);
            MultiView1.ActiveViewIndex = 0;
            Response.Redirect("~/Annonymous/Home.aspx");
        }

        protected void lbtn_forget_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
            {
                SqlCommand c = new SqlCommand("select cust_pass,cust_mail from customer where cust_username = @mail");
                c.Parameters.AddWithValue("@mail", txt_name.Text);
                DataTable d = DBlayer.Sel(c);
                if (d.Rows.Count > 0)
                {
                    MailMessage msg = new MailMessage();
                    msg.To.Add(d.Rows[0]["cust_mail"].ToString());
                    msg.From = new MailAddress("mahmud.tiger2012@gmail.com");
                    msg.Subject = "recover your mail";
                    msg.Body = "this is your password:  " + d.Rows[0]["cust_pass"].ToString();
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 25;
                    smtp.Credentials = new System.Net.NetworkCredential("mahmud.tiger2012@gmail.com", "01226783114");
                    smtp.EnableSsl = true;

                    smtp.Send(msg);
                    lbl_mail_stutes.Text = " message sent succesfully";


                }

            }

        }
    }
}