using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ShoppingOnline.AppCode;

namespace ShoppingOnline.User
{
    public partial class history : System.Web.UI.Page
    {
        SqlCommand cmd;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isadmin"] != null)
            {
                if (int.Parse(Session["isadmin"].ToString()) == 1)
                {
                    Response.Redirect("~/Admin/HomeAdmin.aspx");
                }
            }
            if (Session["id"] != null)
            {
                cmd = new SqlCommand("SELECT Order_id, state, Packing_Date, Deliver_Date FROM[Order] where Cust_id =@id");
                cmd.Parameters.AddWithValue("@id", int.Parse(Session["id"].ToString()));
                dt = DBlayer.Sel(cmd);

                gv_history_show.DataSource = dt;

                gv_history_show.DataBind();
                for (int i = 0; i < gv_history_show.Rows.Count; i++)
                {
                    string state = ((Label)gv_history_show.Rows[i].FindControl("lbl_state")).Text;
                    LinkButton btn = (LinkButton)gv_history_show.Rows[i].FindControl("lbl_delete");
                    if (state == "pending")
                    {
                        btn.Visible = true;
                    }
                    else
                    {
                        btn.Visible = false;
                    }
                }
            }
            else
            {
                Response.Redirect("~/Annonymous/Home.aspx");
            }
            
        }

        protected void gv_history_show_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)gv_history_show.DataKeys[e.RowIndex].Value;
            cmd = new SqlCommand("delete from [OrderItem] where order_id=@id");


            cmd.Parameters.AddWithValue("@id", id);

            DBlayer.Dml(cmd);
            cmd = new SqlCommand("delete from [order] where order_id=@id");
            cmd.Parameters.AddWithValue("@id", id);

            DBlayer.Dml(cmd);



            cmd = new SqlCommand("SELECT Order_id, state, Packing_Date, Deliver_Date FROM[Order] where Cust_id =@id");
            cmd.Parameters.AddWithValue("@id",int.Parse( Session["id"].ToString()));
            dt = DBlayer.Sel(cmd);

            gv_history_show.DataSource = dt;

            gv_history_show.DataBind();
            for (int i = 0; i < gv_history_show.Rows.Count; i++)
            {
                string state = ((Label)gv_history_show.Rows[i].FindControl("lbl_state")).Text;
                LinkButton btn = (LinkButton)gv_history_show.Rows[i].FindControl("lbl_delete");
                if (state == "pending")
                {
                    btn.Visible = true;
                }
                else
                {
                    btn.Visible = false;
                }
            }

        }
    }
}