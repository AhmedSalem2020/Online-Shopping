using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping.Annonymous
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {

            if (Request.QueryString["lang"] != null)
            {
                
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Request.QueryString["lang"]);

            }
           
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["id"] != null) //check the user weather user is logged in or not
                this.Page.MasterPageFile = "~/User/users.Master";
            else
                this.Page.MasterPageFile = "~/Annonymous/Master.Master";
            if (Request.QueryString["theme"] != null)
            {
                Page.Theme = Request.QueryString["theme"];
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Request.QueryString["lang"] != null)
            {
                if (Request.QueryString["lang"] == "ar")
                {
                    lbtn_lang.Text = "English";

                }
            }
            else
            {
                if (Request.QueryString["lang"] == "ar")
                {
                    lbtn_lang.Text = "عربي";
                }
            }
        }
        protected void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {

                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("samouramohammed@gmail.com");
                    mailMessage.To.Add(txt_email.Text);
                    mailMessage.Subject = txt_subject.Text;
                    mailMessage.Body = "<b>Sender Name:</b>" + txt_name.Text + "<br/>" +
                        "<b> Sender Email:</b>" + txt_email.Text + "<br/>" + "<b>Message :</b>"
                        + txt_message.Text;
                    mailMessage.IsBodyHtml = true;
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential("samouramohammed@gmail.com", "");
                    smtpClient.Send(mailMessage);
                    lbl_contact.Text = "Your message is delivered ,Thank you for contacting us";
                    txt_email.Enabled = false;
                    txt_message.Enabled = false;
                    txt_name.Enabled = false;
                    txt_subject.Enabled = false;
                    btn_submit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }


        }

        protected void lbtn_lang_Click(object sender, EventArgs e)
        {
            if(lbtn_lang.Text=="English")
                Response.Redirect("~/Annonymous/ContactUs.aspx");

            else
                Response.Redirect("~/Annonymous/ContactUs.aspx?lang=ar&theme=ShopPoliciesTheme");


        }
    }
}