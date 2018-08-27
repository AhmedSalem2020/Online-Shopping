using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping.Admin
{
    public partial class PenOrder : System.Web.UI.Page
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
                    gv_pendingorder.DataSource = Order.Pending();
                    gv_pendingorder.DataBind();
                gv_approvedorder.DataSource = Order.Approved();
                gv_approvedorder.DataBind();
                gv_blocked.DataSource = Order.Blocked();
                gv_blocked.DataBind();
                }

                catch (Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
            }

        }

        protected void gv_pendingorder_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "approve")
            {
                try
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    //int index = (int)gv_pendingorder.DataKeys[e.RowIndex].Value;
                    int id = (int)gv_pendingorder.DataKeys[index].Value;
                    Order.UpdateStatus(id, "Approved");
                    gv_pendingorder.DataSource = Order.Pending();
                    gv_pendingorder.DataBind();
                    gv_approvedorder.DataSource = Order.Approved();
                    gv_approvedorder.DataBind();
                }
                catch (Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
            }

            if (e.CommandName == "rejectOrder")
            {
                try
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    int id = (int)gv_pendingorder.DataKeys[index].Value;
                    Order.UpdateStatus(id, "Blocked");
                    gv_pendingorder.DataSource = Order.Pending();
                    gv_pendingorder.DataBind();
                    gv_approvedorder.DataSource = Order.Approved();
                    gv_approvedorder.DataBind();
                    gv_blocked.DataSource = Order.Blocked();
                    gv_blocked.DataBind();
                }
                catch (Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }

            }
        }
    }
}