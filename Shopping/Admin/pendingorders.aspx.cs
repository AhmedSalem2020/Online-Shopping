using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using ShoppingOnline.AppCode;

namespace ShoppingOnline.Admin
{
    public partial class pendingorders : System.Web.UI.Page
    {
       
        
            protected void Page_Load(object sender, EventArgs e)
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
                lstView_data.DataSource = Order.pendingOrdecustomer();
                    lstView_data.DataBind();
                }
                catch(Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }

            }


            protected void btn_details_Click(object sender, EventArgs e)
            {
            try
            {
                Button btn = sender as Button;
                int id = int.Parse(btn.CommandArgument.ToString());


                DataTable dt = new DataTable();
                dt = Order.pendingOrders_detailsbyid(id);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }



        }

            protected void btn_Add_Click(object sender, EventArgs e)
            {
            try
            {
                Button btn = sender as Button;
                int id = int.Parse(btn.CommandArgument.ToString());


                int result = Order.approvingorder(id);
                if (result == 1)
                {
                    lbl_result.Text = "order approved successfully";

                }

                DataTable dt = Order.pendingOrdecustomer();
                if (dt.Rows.Count > 0)
                {
                    lstView_data.DataSource = dt;
                    lstView_data.DataBind();

                    lbl_result.Text = " ";

                    GridView1.DataSource = null;
                    GridView1.DataBind();

                }

                else
                {
                    lstView_data.DataSource = dt;
                    lstView_data.DataBind();
                    lbl_result.Text = "No pending orders ";
                    GridView1.DataSource = null;
                    GridView1.DataBind();

                }

            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }






             }
        }
    }
