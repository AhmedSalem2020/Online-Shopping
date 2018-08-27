using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingOnline.AppCode;


namespace Shopping.Admin
{
    public partial class pendingUsers : System.Web.UI.Page
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
                    lstView_data.DataSource = Customer.getPendingUsers();
                    lstView_data.DataBind();
                }catch(Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
            }
        }

        protected void btn_approve_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)(sender);
                int id = int.Parse(btn.CommandArgument.ToString());
                string NewStatus = "approved";
                Customer.editstatus(id, NewStatus);
                Response.Redirect("~/Admin/pendingUsers.aspx");
            }catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }
        }

        protected void btn_block_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)(sender);
                int id = int.Parse(btn.CommandArgument.ToString());
                string NewStatus = "blocked";
                Customer.editstatus(id, NewStatus);
                Response.Redirect("~/Admin/pendingUsers.aspx");
            }catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/view_users.aspx");

        }
    }
}