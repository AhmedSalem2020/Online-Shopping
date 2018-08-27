using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping.Admin
{
    public partial class HomeAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isadmin"]!=null)
            {
                if(Session["isadmin"].ToString()!="1")
                Response.Redirect("~/Annonymous/Home.aspx");

            }
            if (Session["id"] == null)
            {
                Response.Redirect("~/Annonymous/Home.aspx");
            }
          
}
    }
}