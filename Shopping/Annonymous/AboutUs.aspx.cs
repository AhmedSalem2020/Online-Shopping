using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingOnline.Annonymous
{
    public partial class AboutUs : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {

            base.InitializeCulture();
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
        protected void lbtn_lang_Click(object sender, EventArgs e)
        {
            if (lbtn_lang.Text == "English")
                Response.Redirect("~/Annonymous/AboutUs.aspx");

            else
                Response.Redirect("~/Annonymous/AboutUs.aspx?lang=ar&theme=ShopPoliciesTheme");


        }
    }
}