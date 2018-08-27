using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingOnline.AppCode;


namespace Shopping.Admin
{
    public partial class view_users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    if (Session["isadmin"] != null)
                    {
                        if (Session["isadmin"].ToString() != "1")
                            Response.Redirect("~/Annonymous/Home.aspx");

                    }
                    if (Session["id"] == null)
                    {
                        Response.Redirect("~/Annonymous/Home.aspx");
                    }
                    lstView_data.DataSource = Customer.getUsers();
                    lstView_data.DataBind();
                }catch(Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
            }
        }

        protected void lnk_viewBlocked_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/blockedUsers.aspx");

        }

        protected void lnk_viewPending_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/pendingUsers.aspx");


        }
    }
}