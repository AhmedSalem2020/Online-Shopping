using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingOnline.AppCode;


namespace Shopping.Admin
{
    public partial class blockedUsers : System.Web.UI.Page
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
                    lstView_data.DataSource = Customer.getBlockedUsers();
                    lstView_data.DataBind();
                }
                catch(Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
            }

        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/view_users.aspx");

        }

        protected void btn_unblock_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)(sender);
                int id = int.Parse(btn.CommandArgument.ToString());


                string NewStatus = "approved";

                Customer.editstatus(id, NewStatus);


                Response.Redirect("~/Admin/blockedUsers.aspx");
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }

        }
        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)(sender);
                int id = int.Parse(btn.CommandArgument.ToString());

                Customer.remove(id);

                Response.Redirect("~/Admin/blockedUsers.aspx");
            }catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }
        }
    }
}