using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingOnline.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = Order.numofpending();
            lbtn_pendorder.Text = "order " + dt.Rows[0][0].ToString();
        }

        protected void lbtn_pendorder_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/pendingorders.aspx");
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