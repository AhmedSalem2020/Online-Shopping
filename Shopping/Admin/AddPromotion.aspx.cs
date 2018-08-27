using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using ShoppingOnline.AppCode;
using System.Data;

namespace Shopping.Admin
{
    public partial class AddPromotion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if(!IsPostBack)
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
                    ddl_product.DataSource = products.getAll();
                    ddl_product.DataTextField = "prod_name";
                    ddl_product.DataValueField = "prod_id";
                    ddl_product.DataBind();
                    if (Session["prodid"] != null)
                    {
                        ddl_product.SelectedValue = Session["prodid"].ToString();
                    }
                }
                catch(Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
            }
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    products.editprom(txt_promotion.Text, int.Parse(ddl_product.SelectedValue));
                }catch(Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
            }
        }

        protected void lbtn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                MultiView1.ActiveViewIndex = 1;
                int prodid = int.Parse(ddl_product.SelectedValue);
                txt_prom.Text = lbl_promotion.Text = products.prom(prodid).Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }
        }

        protected void ddl_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            int prodid = int.Parse(ddl_product.SelectedValue);
            if (products.prom(prodid).Rows[0][0].GetType().Name!="DBNull")
            {
                MultiView1.ActiveViewIndex = 0;
                lbl_promotion.Text = products.prom(prodid).Rows[0][0].ToString();
            }
            else
            {
                MultiView1.ActiveViewIndex = -1;
            }
        }

        protected void lbtn_cancel_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void lbtn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int prodid = int.Parse(ddl_product.SelectedValue);
                products.editprom(txt_prom.Text, prodid);
                MultiView1.ActiveViewIndex = 0;
                lbl_promotion.Text = products.prom(prodid).Rows[0][0].ToString();
            }catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }
        }

        protected void lbtn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int prodid = int.Parse(ddl_product.SelectedValue);
                products.editprom("NULL", prodid);
                MultiView1.ActiveViewIndex = -1;
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }

        }
    }
}