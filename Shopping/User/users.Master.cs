using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping.User
{
    public partial class users : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void lbn_logOut_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["isadmin"] = null;
            //Session.Abandon();
            HttpCookie coo = new HttpCookie("log");
            coo.Expires = DateTime.Now.AddDays(-5);
            Response.Cookies.Add(coo);
            Response.Redirect("~/Annonymous/Home.aspx");
        }
    }
}